using System;
using System.Collections.Generic;

namespace Mundo
{
    public class Mundos
    {
        /// <summary>
        /// Propiedad que devuelve la Puntuación que va teniendo el Juego
        /// </summary>
        public double DarPuntuacion { get; private set; }

        /// <summary>
        /// Propiedad que devuelve la cantidad de Huevos para el constructor 2
        /// </summary>
        public int Cantidad { get; private set; }

        /// <summary>
        /// Propiedad que devuelve la velocidad para el constructor 2
        /// </summary>
        public int Velocidad { get; private set; }

        /// <summary>
        /// Método que cambia la puntuación dependiendo del número
        /// </summary>
        /// <param name="numero">Número que se desea incrementar</param>
        public void Puntuacion(double numero)
        {
            DarPuntuacion += numero;
        }

        /// <summary>
        /// Propiedad que refleja el mundo de objetos
        /// </summary>
        public ObjetosMundos[,] ObjetosMundo { get; private set; }

        /// <summary>
        /// Constructor de la clase Mundos
        /// </summary>
        /// <param name="filas">Representa la cantidad de filas que establece el usuario</param>
        /// <param name="columnas">Representa la cantidad de columnas que establece el usuario</param>
        public Mundos(int filas, int columnas)
        {
            ObjetosMundo = new ObjetosMundos[filas, columnas];
        }

        /// <summary>
        /// Constructor de la clase Mundos 2
        /// </summary>
        /// <param name="filas">Representa la cantidad de filas</param>
        /// <param name="columnas">Representa la cantidad de columnas</param>
        /// <param name="posiciones">Representa las posiciones de los obstaculos</param>
        /// <param name="cantidad">Representa la cantidad de huevos</param>
        /// <param name="velocidad">Representa la velocidad del movimiento</param>
        public Mundos(int filas, int columnas, List<Tuple<int, int>> obstaculos, int cantidad, int velocidad)
        {
            ObjetosMundo = new ObjetosMundos[filas, columnas];
            for (int i = 0; i < obstaculos.Count; i++)
            {
                ObjetosMundo[obstaculos[i].Item1, obstaculos[i].Item2] = new Obstaculos();
            }
            Cantidad = cantidad;
            Velocidad = velocidad;
        }

        /// <summary>
        /// Agrega un obstáculo al mundo
        /// </summary>
        /// <param name="fila">Posición fila en la que se desea agregar</param>
        /// <param name="columna">Posición columna en la que se desea agregar</param>
        public void AgregaObstaculo(int fila, int columna)
        {
            ObjetosMundo[fila, columna] = new Obstaculos();
        }

        /// <summary>
        /// Elimina un obstáculo del mundo
        /// </summary>
        /// <param name="fila">Posición fila en la que se desea eliminar</param>
        /// <param name="columna">Posición columna en la que se desea eliminar</param>
        public void EliminaObstaculo(int fila, int columna)
        {
            ObjetosMundo[fila, columna] = null;
        }
    }
}
