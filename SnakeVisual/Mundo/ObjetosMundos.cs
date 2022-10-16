using System;
using System.Collections.Generic;

namespace Mundo
{
    public abstract class ObjetosMundos
    {
    }

    public class CabezaSerpiente : ObjetosMundos
    {
        /// <summary>
        /// Representa las direcciones que puede tener la Serpiente
        /// </summary>
        public enum Direccion
        {
            Arriba,
            Abajo,
            Derecha,
            Izquierda
        }

        /// <summary>
        /// Propiedad que devuelve la dirección actual de la Serpiente
        /// </summary>
        public Direccion Dir { get; private set; }
        
        /// <summary>
        /// Método para cambiar la Dirección fuera de esta clase
        /// </summary>
        /// <param name="direccion">Dirección que se le quiere dar</param>
        public void DarDireccion(Direccion direccion)
        {
            Dir = direccion;
        }

        /// <summary>
        /// Lista que contiene las Posiciones de la serpiente en el mundo
        /// </summary>
        public List<Tuple<int, int>> PosicionSerpiente { get; private set; }

        /// <summary>
        /// Constructor de la clase Serpiente. La cabeza
        /// </summary>
        /// <param name="direccion">Dirección que tendrá la Serpiente</param>
        public CabezaSerpiente(Direccion direccion)
        {
            Dir = direccion;
            PosicionSerpiente = new List<Tuple<int, int>>();
        }
    }

    public class CuerpoSerpiente : ObjetosMundos
    {
        public CuerpoSerpiente()
        {
        }
    }

    public class Obstaculos : ObjetosMundos
    {
        public Obstaculos()
        {
        }
    }

    public class Huevos : ObjetosMundos
    {
        /// <summary>
        /// Propiedad que devuelve el numero de cada Huevo
        /// </summary>
        public int Numero { get; private set; }
        public Huevos(int numero)
        {
            Numero = numero;
        }
    }
}
