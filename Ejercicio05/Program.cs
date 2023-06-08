using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    interface Entregable
    {
        string isEntregado();
        bool Entregar();
        bool Devolver();
        string Mostrar();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Videojuego> videojuegos = new List<Videojuego>();
            List<Serie> series = new List<Serie>();
            Random rnd = new Random();
            int cant = 0;
            int n = 0;
            
            
            videojuegos.Add(new Videojuego("Resident Evil 4", 15, "Accion", "Capcom"));
            series.Add(new Serie("Breaking Bad", "Vince Gillegan"));
            videojuegos.Add(new Videojuego("God Of War II", 13, "Violencia", "Santa Monica"));
            series.Add(new Serie("South Park", 20, "comedia", "Erick Cartman"));
            series.Add(new Serie("The Amazing SpiderMan", 3, "Ficcion", "Stan Lee"));
            videojuegos.Add(new Videojuego("Black", 16));
            videojuegos.Add(new Videojuego("Call Of Duty", 25, "Accion", "Activision"));
            videojuegos.Add(new Videojuego());
            series.Add(new Serie());
            Videojuego jue = videojuegos[0];
            Serie ser = series[0];
            Console.Clear();
                    for (int i = 0; i < videojuegos.Count; i++)
                    {
                        videojuegos[rnd.Next(0, 4)].Entregar();
                        
                        if (videojuegos[i].entregado == true)
                        {
                            cant++;
                        videojuegos[i].Devolver();
                        }
                         Console.WriteLine(videojuegos[i].Mostrar() + "  " + videojuegos[i].isEntregado());
                    }
                    for (int j = 0; j < series.Count; j++)
                    {
                        series[rnd.Next(0, 4)].Entregar();

                        if (series[j].entregado == true)
                        {
                            n++;
                            series[j].Devolver();
                        }
                        Console.WriteLine(series[j].Mostrar() + "  " + series[j].isEntregado());
                    }
                    foreach(Videojuego juego in videojuegos)
                    {
                        if(jue.horas_estimadas < juego.horas_estimadas)
                        {
                            jue = juego;
                        }
                    }
                    foreach(Serie serie in series)
                    {
                        if(ser.cant_temporadas < serie.cant_temporadas)
                        {
                            ser = serie;
                        }
                    }
                    Console.WriteLine("La cantidad de juegos entregados fueron: " + cant);
                    Console.WriteLine("La cantidad de series entregados fueron: " + n);
            Console.ReadKey();
            Console.Clear();
                    Console.WriteLine("El juego con mas horas es: ");
                    Console.WriteLine(jue.Mostrar());
                    Console.WriteLine("La serie con mas temporadas es: ");
                    Console.WriteLine(ser.Mostrar());
            Console.ReadKey();

        }
    }
}
