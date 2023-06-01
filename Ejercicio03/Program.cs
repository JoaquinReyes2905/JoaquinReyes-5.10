using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Password
    {
        public double logintud = 8;
        public string contraseña;
        Random rnd = new Random();
        public Password() { }

        public Password(int longitud)
        {
            this.logintud = longitud;
        }
        public Password(string contraseña)
        {
            this.contraseña = contraseña;
        }

        public string generarPassword(int longe)
        {
            this.logintud = longe;
            const string password = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            contraseña = "";
            for (int i = 0; i < logintud; i++)
            {
                
                contraseña += password[rnd.Next(0,password.Length - 1)];
            }
            return contraseña;
        }

        public bool EsFuerte()
        {
            int mayus = 0;
            int minus = 0;
            int decim = 0;

            foreach (char caracter in contraseña)
            {
                if (char.IsUpper(caracter))
                {
                    mayus++;
                }
                if (char.IsLower(caracter))
                {
                    minus++;
                }
                if (char.IsNumber(caracter))
                {
                    decim++;
                }

                if (mayus >= 2 && minus >= 1 && decim >= 5) 
                {
                    return true;
                }
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar la cantidad de contraeñas: ");
            int cant = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ingresar la longitud de las contraseñas: ");
            int longe = Convert.ToInt16(Console.ReadLine());
            Password contraseña = new Password();
            List<Password> contraseñas = new List<Password>();
            for (int j = 0; j < cant; j++)
            {
                contraseñas.Add(new Password(contraseña.generarPassword(longe)));
            }
                while (true)
                {
                    Console.Clear();
                    for (int i = 0; i < contraseñas.Count; i++)
                    {
                        Console.WriteLine(contraseñas[i].contraseña);
                        if (contraseñas[i].EsFuerte() == true)
                        {
                            Console.WriteLine("Es fuerte");
                        }
                        else
                        {
                            Console.WriteLine("Es debil");
                        }
                    Console.WriteLine("");
                    }
                    Console.ReadKey();
            }
        }
    }
}
