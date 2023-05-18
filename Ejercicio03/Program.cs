using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Videojuego> videojuegos = new List<Videojuego>();
            List<Serie> series = new List<Serie>();
            Random rnd = new Random();
            videojuegos.Add(new Videojuego("Resident Evil 4" , 15 , "Accion" , "Capcom"));
            series.Add(new Serie("Breaking Bad" , "Vince Gillegan"));
            videojuegos.Add(new Videojuego("God Of War II" , 13 , "Violencia" , "Santa Monica"));
            series.Add(new Serie("South Park", 20, "comedia", "Erick Cartman"));
            series.Add(new Serie("The Amazing SpiderMan" , 3 , "Ficcion" , "Stan Lee"));
            videojuegos.Add(new Videojuego("Black", 16));
            videojuegos.Add(new Videojuego("Call Of Duty" , 25 , "Accion" , "Activision"));
            videojuegos.Add(new Videojuego());
            series.Add(new Serie());
            series.Add(new Serie("Better Call Saul", 4, "Suspenso", "Vince Gillegan"));
        }
    }
}
