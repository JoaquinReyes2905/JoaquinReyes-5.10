using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Cuenta
    {
        public string titular;
        public double cantidad;

        public Cuenta() { }

        public Cuenta(string titular , double cantidad = 0)
        {
            this.cantidad = cantidad;
            this.titular = titular;
        }
       public string mostrarTodo()
        {
            return titular + " | Saldo: " + cantidad;
        }

       public double Ingresar(double num)
        {
            return this.cantidad = this.cantidad + num;
        }
        public double Retirar(double ret)
        {
            this.cantidad = this.cantidad - ret;

            if(this.cantidad < 0 ){
                return this.cantidad = 0;
            }

            return this.cantidad;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            Cuenta cuenta = new Cuenta();
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();
            Console.WriteLine("Ingrese el nombre de cuenta: ");
            name = Console.ReadLine();
            cuenta.titular = name;
            Console.Clear();
           

            while (true)
            {
                Console.Clear();
                Console.WriteLine(cuenta.mostrarTodo());
                
                Console.WriteLine("1. ingresar");
                Console.WriteLine("2. Retirar");
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("ingrese la cantidad: ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    if(num > 0)
                    {
                        cuenta.Ingresar(num);
                    }
                }
                if(tecla.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.WriteLine("ingresar la cantidad a retirar: ");
                    double ret = Convert.ToDouble(Console.ReadLine());
                    if (ret > 0)
                    {
                        cuenta.Retirar(ret);
                    }
                }
                
                Console.ReadKey();
            }
        }
    }
}
