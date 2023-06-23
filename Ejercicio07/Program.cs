using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Raices
    {
        public double a;
        public double b;
        public double c;
        public bool estado = false;

        public Raices() { }
        public Raices(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public double getDescriminante()
        {
            double descriminante = (Math.Pow(b, 2) - (4 * a * c));
            if (descriminante < 0 || descriminante == double.NaN)
            {
                this.estado = true;
            }
            else
            {
                estado = false;
            }
            return descriminante;
        }
        public void Calcular()
        {
            if (estado == true)
            {
                Console.WriteLine("no hay soluciones");
            }
            if ((Math.Pow(b, 2) - (4 * a * c)) > 0)
            {
                if (estado == false)
                {
                    double raiz1 = (b - (Math.Sqrt((Math.Pow(b, 2) - (4 * a * c))))) / (2 * a);
                    double raiz2 = (b + (Math.Sqrt((Math.Pow(b, 2) - (4 * a * c))))) / (2 * a);
                    Console.WriteLine("S: {" + raiz1 + " ; " + raiz2 + "}");
                }
            }
            else if ((Math.Pow(b, 2) - (4 * a * c)) == 0)
            {
                double raiz = (b / (2 * a));
                Console.WriteLine("S: {"+ raiz +"}");
            }
        }
        public double Clacular()
        {
            double raiz = (b / (2 * a));
            if ((Math.Pow(b, 2) - (4 * a * c)) == 0)
            {
                return raiz;
            }
            return 0;
        }
        public string Una()
        {
             
            if((Math.Pow(b, 2) - (4 * a * c)) == 0)
            {
                return "tiene una raiz";
            }
            return "no tiene una raiz";
        }
        public string dos()
        {
            double descriminante = (Math.Pow(b, 2) - (4 * a * c));
            if (descriminante > 0)
            {
                return "tiene dos raices";
            }
            return "no tiene dos raices";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices mike = new Raices();
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();
            Console.WriteLine("coloca el valor de a: ");
            mike.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("coloca el valor de b: ");
            mike.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("coloca el valor de c: ");
            mike.c = Convert.ToDouble(Console.ReadLine());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Obtener raices");
                Console.WriteLine("2. Obtener Raiz");
                Console.WriteLine("3. Discriminante");
                Console.WriteLine("4. tiene raices");
                Console.WriteLine("5. tiene raiz");
                Console.WriteLine("6. Calcular");
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    mike.Calcular();
                }
                if (tecla.Key == ConsoleKey.D6)
                {
                    Console.Clear();
                    mike.Calcular();
                }
                if(tecla.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.WriteLine(mike.getDescriminante());
                }
                if(tecla.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    Console.WriteLine(mike.dos());
                }
                if(tecla.Key == ConsoleKey.D5)
                {
                    Console.Clear();
                    Console.WriteLine(mike.Una());
                }
                if(tecla.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                   Console.WriteLine(mike.Clacular());
                }
                    Console.ReadKey();
            }
            
            
            
            
           
            
        }
    }
}
