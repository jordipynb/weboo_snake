using System;
using System.Collections.Generic;

namespace Mundo
{
    public class Juego
    {
        /// <summary>
        /// Mundo en el que se está jugando
        /// </summary>
        readonly Mundos mundo;

        /// <summary>
        /// Para conocer donde está la Cabeza en el Mundo durante el Juego
        /// </summary>
        public CabezaSerpiente cabezaS;

        /// <summary>
        /// Refleja el creciemiento que de la serpiente por movimientos
        /// </summary>
        int incremento;

        /// <summary>
        /// Propiedad que conoce la Cantidad de Huevos que debe tener el mundo
        /// </summary>
        public int Cantidad { get; private set; }

        /// <summary>
        /// Propiedad que devuelve verdadero o falso según si ganas el Juego
        /// </summary>
        public bool Ganas { get; private set; }

        /// <summary>
        /// Propiedad que devuelve verdadero o falso según si se puede jugar
        /// </summary>
        public bool PuedesJugar { get; private set; }

        /// <summary>
        /// Lista de posiciones de los Huevos en el mundo
        /// </summary>
        List<Tuple<int, int>> PosicionesHuevos { get; set; }

        /// <summary>
        /// Constructor para comenzar el Juego
        /// </summary>
        /// <param name="mundo">Mundo con el que se desea jugar</param>
        public Juego(Mundos mundo)
        {
            this.mundo = mundo;
            Cantidad = mundo.Cantidad;
            bool existeLaCabeza = false;
            for (int i = 0; i < mundo.ObjetosMundo.GetLength(0); i++)
            {
                if (existeLaCabeza) break;
                for (int j = 0; j < mundo.ObjetosMundo.GetLength(1); j++)
                {
                    if(mundo.ObjetosMundo[i,j] is CabezaSerpiente)
                    {
                        cabezaS = (CabezaSerpiente)mundo.ObjetosMundo[i, j];
                        existeLaCabeza = true;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Devuelve verdadero o false según si el mundo es válido o no
        /// </summary>
        /// <returns></returns>
        public bool EsValido()
        {
            int[] dfilas = { -1, 0, 1, 0 };
            int[] dcols = { 0, 1, 0, -1 };
            int filas = mundo.ObjetosMundo.GetLength(0);
            int columnas = mundo.ObjetosMundo.GetLength(1);
            int[,] distancia = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (mundo.ObjetosMundo[i, j] is Obstaculos) distancia[i, j] = -1;
                }
            }
            bool huboCambio = false;
            for (int i = 0; i < filas; i++)
            {
                if (huboCambio == true) break;
                for (int j = 0; j < columnas; j++)
                {
                    if (mundo.ObjetosMundo[i, j] == null)
                    {
                        distancia[i, j] = 1;
                        huboCambio = true;
                        break;
                    }
                }
            }
            if (huboCambio == false) return false;
            huboCambio = false;
            for (int i = 0; i < filas; i++)
            {
                if (huboCambio == true) break;
                for (int j = 0; j < columnas; j++)
                {
                    if (distancia[i, j] == 0) { huboCambio = true; break; }
                }
            }
            if (huboCambio == false) return false;
            do
            {
                huboCambio = false;
                for (int f = 0; f < filas; f++)
                {
                    for (int c = 0; c < columnas; c++)
                    {
                        if (distancia[f, c] == 0 || distancia[f, c] == -1) continue;
                        for (int d = 0; d < dfilas.Length; d++)
                        {
                            int vf = f + dfilas[d];
                            int vc = c + dcols[d];
                            if (vf == -1) vf = filas - 1;
                            if (vf == filas) vf = 0;
                            if (vc == -1) vc = columnas - 1;
                            if (vc == columnas) vc = 0;
                            if (distancia[vf, vc] == 0)
                            {
                                distancia[vf, vc] = distancia[f, c] + 1;
                                huboCambio = true;
                            }
                        }
                    }
                }
            }
            while (huboCambio);
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (distancia[i, j] == 0) return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Establece si el mundo tiene todas sus casillas ocupadas
        /// </summary>
        /// <returns></returns>
        private bool EstaLleno()
        {
            for (int i = 0; i < mundo.ObjetosMundo.GetLength(0); i++)
            {
                for (int j = 0; j < mundo.ObjetosMundo.GetLength(1); j++)
                {
                    if (mundo.ObjetosMundo[i, j] == null) return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Genera la cantidad de Huevos en la Simulación 
        /// </summary>
        /// <param name="cantidad">Cantidad de Huevos que se desea tener en el mundo</param>
        public void GeneraHuevo(int cantidad)
        {
            Cantidad = cantidad;
            PuedesJugar = true;
            PosicionesHuevos = new List<Tuple<int, int>>(Cantidad);
            Random random = new Random();
            int n = 1;
            while (n <= cantidad)
            {
                int huevoFila = random.Next(0, mundo.ObjetosMundo.GetLength(0));
                int huevoColumna = random.Next(0, mundo.ObjetosMundo.GetLength(1));
                if (mundo.ObjetosMundo[huevoFila, huevoColumna] == null)
                { 
                    mundo.ObjetosMundo[huevoFila, huevoColumna] = new Huevos(n);
                    PosicionesHuevos.Add(new Tuple<int,int>(huevoFila, huevoColumna));
                    n++;
                }
                if (EstaLleno() && n < cantidad + 1)
                {
                    Ganas = true;
                    return;
                }
            }
        }

        /// <summary>
        /// Método que inserta la serpiente una vez creado el mundo
        /// </summary>
        public void InsertarSerpiente()
        {
            Random random = new Random();
            int cabezaFila;
            int cabezaColumna;
            while (true)
            {
                cabezaFila = random.Next(0, mundo.ObjetosMundo.GetLength(0));
                cabezaColumna = random.Next(0, mundo.ObjetosMundo.GetLength(1));
                int cabFilaneg = cabezaFila - 1;
                int cabFilapos = cabezaFila + 1;
                int cabColmneg = cabezaColumna - 1;
                int cabColmpos = cabezaColumna + 1;
                if (mundo.ObjetosMundo[cabezaFila, cabezaColumna] == null)
                {

                    if (cabFilaneg == -1) cabFilaneg = mundo.ObjetosMundo.GetLength(0) - 1;
                    if (cabFilapos == mundo.ObjetosMundo.GetLength(0)) cabFilapos = 0;
                    if(cabColmneg == -1) cabColmneg = mundo.ObjetosMundo.GetLength(1) - 1;
                    if (cabColmpos == mundo.ObjetosMundo.GetLength(1)) cabColmpos = 0;
                    if (mundo.ObjetosMundo[cabFilaneg, cabezaColumna] == null)
                    {
                        mundo.ObjetosMundo[cabezaFila, cabezaColumna] = new CabezaSerpiente(CabezaSerpiente.Direccion.Abajo);
                        mundo.ObjetosMundo[cabFilaneg, cabezaColumna] = new CuerpoSerpiente();
                        cabezaS = (CabezaSerpiente)mundo.ObjetosMundo[cabezaFila, cabezaColumna];
                        cabezaS.PosicionSerpiente.Insert(0, new Tuple<int, int>(cabFilaneg, cabezaColumna));
                        cabezaS.PosicionSerpiente.Insert(0, new Tuple<int, int>(cabezaFila, cabezaColumna));
                        return;
                    }
                    if (mundo.ObjetosMundo[cabFilapos, cabezaColumna] == null)
                    { 
                        mundo.ObjetosMundo[cabezaFila, cabezaColumna] = new CabezaSerpiente(CabezaSerpiente.Direccion.Arriba);
                        mundo.ObjetosMundo[cabFilapos, cabezaColumna] = new CuerpoSerpiente();
                        cabezaS = (CabezaSerpiente)mundo.ObjetosMundo[cabezaFila, cabezaColumna];
                        cabezaS.PosicionSerpiente.Insert(0, new Tuple<int, int>(cabFilapos, cabezaColumna));
                        cabezaS.PosicionSerpiente.Insert(0, new Tuple<int, int>(cabezaFila, cabezaColumna));
                        return;
                    }
                    if (mundo.ObjetosMundo[cabezaFila, cabColmpos] == null)
                    {
                        mundo.ObjetosMundo[cabezaFila, cabezaColumna] = new CabezaSerpiente(CabezaSerpiente.Direccion.Izquierda);
                        mundo.ObjetosMundo[cabezaFila, cabColmpos] = new CuerpoSerpiente();
                        cabezaS = (CabezaSerpiente)mundo.ObjetosMundo[cabezaFila, cabezaColumna];
                        cabezaS.PosicionSerpiente.Insert(0, new Tuple<int, int>(cabezaFila, cabColmpos));
                        cabezaS.PosicionSerpiente.Insert(0, new Tuple<int, int>(cabezaFila, cabezaColumna));
                        return;
                    }
                    if (mundo.ObjetosMundo[cabezaFila, cabColmneg] == null)
                    {
                        mundo.ObjetosMundo[cabezaFila, cabezaColumna] = new CabezaSerpiente(CabezaSerpiente.Direccion.Derecha);
                        mundo.ObjetosMundo[cabezaFila, cabColmneg] = new CuerpoSerpiente();
                        cabezaS = (CabezaSerpiente)mundo.ObjetosMundo[cabezaFila, cabezaColumna];
                        cabezaS.PosicionSerpiente.Insert(0, new Tuple<int, int>(cabezaFila, cabColmneg));
                        cabezaS.PosicionSerpiente.Insert(0, new Tuple<int, int>(cabezaFila, cabezaColumna));
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Devuelve el huevo más cercano
        /// </summary>
        /// <param name="iPos">Posición en fila del Huevo</param>
        /// <param name="jPos">Posición en columna del Huevo</param>
        /// <returns></returns>
        private int HuevoCercano(int iPos, int jPos)
        {
            int[] dfilas = { -1, 0, 1, 0 };
            int[] dcols = { 0, 1, 0, -1 };
            int filas = mundo.ObjetosMundo.GetLength(0);
            int columnas = mundo.ObjetosMundo.GetLength(1);
            int[,] distancia = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (mundo.ObjetosMundo[i, j] is Obstaculos) distancia[i, j] = -1;
                }
            }
            distancia[iPos, jPos] = 1;
            bool huboCambio;
            do
            {
                huboCambio = false;
                for (int f = 0; f < filas; f++)
                {
                    for (int c = 0; c < columnas; c++)
                    {
                        if (distancia[f, c] == 0 || distancia[f, c] == -1) continue;
                        for (int d = 0; d < dfilas.Length; d++)
                        {
                            int vf = f + dfilas[d];
                            int vc = c + dcols[d];
                            if (vf == -1) vf = filas - 1;
                            if (vf == filas) vf = 0;
                            if (vc == -1) vc = columnas - 1;
                            if (vc == columnas) vc = 0;
                            if (distancia[vf, vc] == 0)
                            {
                                distancia[vf, vc] = distancia[f, c] + 1;
                                huboCambio = true;
                            }
                            if (distancia[vf, vc] > 1 && distancia[f, c] + 1 < distancia[vf, vc])
                            {
                                distancia[vf, vc] = distancia[f, c] + 1;
                                huboCambio = true;
                            }
                        }
                    }
                }
            }
            while (huboCambio);
            int min = int.MaxValue;
            for (int i = 0; i < PosicionesHuevos.Count; i++)
            {
                if (mundo.ObjetosMundo[PosicionesHuevos[i].Item1, PosicionesHuevos[i].Item2] is Huevos && distancia[PosicionesHuevos[i].Item1, PosicionesHuevos[i].Item2] != 1 && distancia[PosicionesHuevos[i].Item1, PosicionesHuevos[i].Item2] < min)
                { min = distancia[PosicionesHuevos[i].Item1, PosicionesHuevos[i].Item2]; }
            }
            int numero = 0;
            for (int i = 0; i < PosicionesHuevos.Count; i++)
            {
                if (mundo.ObjetosMundo[PosicionesHuevos[i].Item1, PosicionesHuevos[i].Item2] is Huevos && distancia[PosicionesHuevos[i].Item1, PosicionesHuevos[i].Item2] == min)
                {
                    if (((Huevos)mundo.ObjetosMundo[PosicionesHuevos[i].Item1, PosicionesHuevos[i].Item2]).Numero > numero)
                    { numero = ((Huevos)mundo.ObjetosMundo[PosicionesHuevos[i].Item1, PosicionesHuevos[i].Item2]).Numero; }
                }
            }
            return numero;
        }

        /// <summary>
        /// Devuelve verdadero o falso según si hay huevos o no en el mundo
        /// </summary>
        /// <returns></returns>
        private bool NoHayHuevos()
        {
            for (int i = 0; i < mundo.ObjetosMundo.GetLength(0); i++)
            {
                for (int j = 0; j < mundo.ObjetosMundo.GetLength(1); j++)
                {
                    if (mundo.ObjetosMundo[i, j] is Huevos) return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Método que realiza el movimiento de la Serpiente
        /// </summary>
        /// <param name="direccion">Dirección en el que se desea mover a la Serpiente</param>
        public void Movimiento(CabezaSerpiente.Direccion direccion)
        {
            bool comio = false;
            cabezaS.DarDireccion(direccion);
            int newserposF = ValorF(cabezaS.PosicionSerpiente[0].Item1 + RepresentaPosicion(direccion).Item1);
            int newserposC = ValorC(cabezaS.PosicionSerpiente[0].Item2 + RepresentaPosicion(direccion).Item2);
            if (mundo.ObjetosMundo[newserposF, newserposC] is Obstaculos) { PuedesJugar = false; return; }
            if (mundo.ObjetosMundo[newserposF, newserposC] is CuerpoSerpiente)
            {
                if (incremento > 0 || (newserposF != cabezaS.PosicionSerpiente[cabezaS.PosicionSerpiente.Count - 1].Item1 || newserposC != cabezaS.PosicionSerpiente[cabezaS.PosicionSerpiente.Count - 1].Item2))
                {
                    PuedesJugar = false;
                    return;
                }
            }
            if (mundo.ObjetosMundo[newserposF, newserposC] is Huevos) comio = true;
            Ejecuta(comio, newserposF, newserposC);
        }

        /// <summary>
        /// Metodo que ejecuta el movimiento
        /// </summary>
        /// <param name="comio">Representa si la serpiente comio un huevo</param>
        /// <param name="newserposF">Nueva posicion Fila a tomar por la serpiente</param>
        /// <param name="newserposC">Nueva posicion Columna a tomar por la serpiente</param>
        private void Ejecuta(bool comio, int newserposF, int newserposC)
        {
            if (incremento > 0)
            {
                if (comio)
                {
                    incremento += ((Huevos)mundo.ObjetosMundo[newserposF, newserposC]).Numero;
                    mundo.Puntuacion(HuevoCercano(newserposF, newserposC) * 100);
                    mundo.ObjetosMundo[newserposF, newserposC] = null;
                }
                cabezaS.PosicionSerpiente.Insert(0, new Tuple<int, int>(newserposF, newserposC));
                mundo.ObjetosMundo[newserposF, newserposC] = cabezaS;
                for (int i = 1; i < cabezaS.PosicionSerpiente.Count; i++)
                {
                    mundo.ObjetosMundo[cabezaS.PosicionSerpiente[i].Item1, cabezaS.PosicionSerpiente[i].Item2] = new CuerpoSerpiente();
                }
                incremento--;
                if (NoHayHuevos()) GeneraHuevo(Cantidad);
                return;
            }
            else
            {
                if (comio)
                {
                    incremento = ((Huevos)mundo.ObjetosMundo[newserposF, newserposC]).Numero;
                    mundo.Puntuacion(HuevoCercano(newserposF, newserposC) * 100);
                    mundo.ObjetosMundo[newserposF, newserposC] = null;
                }
                mundo.ObjetosMundo[cabezaS.PosicionSerpiente[cabezaS.PosicionSerpiente.Count - 1].Item1, cabezaS.PosicionSerpiente[cabezaS.PosicionSerpiente.Count - 1].Item2] = null;
                cabezaS.PosicionSerpiente.Remove(cabezaS.PosicionSerpiente[cabezaS.PosicionSerpiente.Count - 1]);
                cabezaS.PosicionSerpiente.Insert(0, new Tuple<int, int>(newserposF, newserposC));
                mundo.ObjetosMundo[newserposF, newserposC] = cabezaS;
                for (int i = 1; i < cabezaS.PosicionSerpiente.Count; i++)
                {
                    mundo.ObjetosMundo[cabezaS.PosicionSerpiente[i].Item1, cabezaS.PosicionSerpiente[i].Item2] = new CuerpoSerpiente();
                }
                if (NoHayHuevos()) GeneraHuevo(Cantidad);
                return;
            }
        }

        /// <summary>
        /// Metodo que representa la nueva Posicion fila
        /// </summary>
        /// <param name="valorDireccional">Valor correspondiente a la suma</param>
        /// <returns></returns>
        private int ValorF(int valorDireccional)
        {
            if (valorDireccional == -1) return mundo.ObjetosMundo.GetLength(0) - 1;
            else if (valorDireccional == mundo.ObjetosMundo.GetLength(0)) return 0;
            return valorDireccional;
        }

        /// <summary>
        /// Metodo que representa la nueva Posicion fila
        /// </summary>
        /// <param name="valorDireccional">Valor correspondiente a la suma</param>
        /// <returns></returns>
        private int ValorC(int valorDireccional)
        {
            if (valorDireccional == -1) return mundo.ObjetosMundo.GetLength(1) - 1;
            else if (valorDireccional == mundo.ObjetosMundo.GetLength(1)) return 0;
            return valorDireccional;
        }

        /// <summary>
        /// Devuelve la tupla que representa el array direccional
        /// </summary>
        /// <param name="direccion">Direccion en que se quiere mover la serpiente</param>
        /// <returns></returns>
        private Tuple<int, int> RepresentaPosicion(CabezaSerpiente.Direccion direccion)
        {
            Tuple<int, int> tuple = new Tuple<int, int>(0, 0);
            if (direccion == CabezaSerpiente.Direccion.Abajo) tuple = new Tuple<int, int>(1, 0);
            if (direccion == CabezaSerpiente.Direccion.Arriba) tuple = new Tuple<int, int>(-1, 0);
            if (direccion == CabezaSerpiente.Direccion.Derecha) tuple = new Tuple<int, int>(0, 1);
            if (direccion == CabezaSerpiente.Direccion.Izquierda) tuple = new Tuple<int, int>(0, -1);
            return tuple;
        }
    }
}
