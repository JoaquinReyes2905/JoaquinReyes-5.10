using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Videojuego
    {
        private string titulo = null;
        private int horas_estimadas = 10;
        private bool entregado = false;
        private string genero = null;
        private string compañia = null;

        public Videojuego() { }

        public Videojuego(string titulo, int horas_estimadas)
        {
            this.titulo = titulo;
            this.horas_estimadas = horas_estimadas;
        }

        public Videojuego(string titulo, int horas_estimadas, string genero, string compañia)
        {
            this.titulo = titulo;
            this.horas_estimadas = horas_estimadas;
            this.genero = genero;
            this.compañia = compañia;
        }

        public string isEntregado()
        {
            return "Estado: " + this.entregado;
        }

        public bool Entregar()
        {
            return entregado = true;
        }
        public bool Devolver()
        {
            return entregado = false;
        }
    }
}
