using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Serie : Videojuego
    {
        private string titulo = null;
        private int cant_temporadas = 3;
        private bool entregado = false;
        private string genero = null;
        private string creador = null;

        public Serie() { }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, int cant_temporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.cant_temporadas = cant_temporadas;
            this.genero = genero;
            this.creador = creador;

        }
    }
}
