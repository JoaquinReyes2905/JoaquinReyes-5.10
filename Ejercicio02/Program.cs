using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{

    
    class Persona
    {
        public string nombre = "";
        public int edad = 0;
        int dni;
        public char sexo = 'H';
        public double peso = 0;
        public double altura = 0;
        Random rnd = new Random();

        public Persona() { }

        public Persona(string nombre , int edad , char sexo) 
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }
        public Persona(string nombre, int edad, int dni , char sexo , double peso , double altura)
        {
            this.nombre= nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public bool EsMayorEdad(int age)
        {
            if(this.edad > 18)
            {
                return true;
            }
            return false;
        }

        public char comprobarSexo(char sex)
        {
            if(sex == 'H' || sex == 'M')
            {
                return this.sexo = sex;
            }
            return this.sexo = 'H';
        }

        public int generarDNI()
        {
            return rnd.Next(10000000, 99999999);
        }
        public double calcularIMC(double imc)
        {
            if(imc < 20)
            {
                return -1;
            }
            if(imc > 20 && imc < 25)
            {
                return 0;
            }
            if(imc > 25)
            {
                return 1;
            }
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            Console.WriteLine("Colocar nombre: ");
            string name = Console.ReadLine();
            persona.nombre = name;
           

            Console.WriteLine("Pon tu edad: ");
            string linea = Console.ReadLine();
            int age = int.Parse(linea);
            persona.edad = age;
           

            Console.WriteLine("Pon su sexo(H - hombre o M - mujer): ");
            char sex = Convert.ToChar(Console.ReadLine());
            persona.sexo = sex;

            Console.WriteLine("Pon el peso: ");
            double pes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pon la altura: ");
            double alt = Convert.ToDouble(Console.ReadLine());

            double imc = pes / alt;

            Console.Clear();
            Console.WriteLine("Nombre: " + persona.nombre);
            if (persona.EsMayorEdad(age) == true)
            {
                Console.WriteLine("Es mayor de edad");
            }
            Console.WriteLine("IMC: " + persona.calcularIMC(imc));
            Console.WriteLine("DNI: "+ persona.generarDNI() + " , SEXO: " + persona.sexo);
            Console.WriteLine("");
            Persona persona2 = new Persona(name , age , sex);
            Console.WriteLine(persona2.nombre);
            if (persona2.EsMayorEdad(age) == true)
            {
                Console.WriteLine("es mayor");
            }
            Console.WriteLine("DNI: " + persona2.generarDNI() + " , SEXO: " + persona2.sexo);
            Console.WriteLine("");
            Persona persona3 = new Persona();

            Console.WriteLine("Nombre: " + persona3.nombre);
            Console.WriteLine("Edad: " + persona3.edad);
            Console.WriteLine("SEXO: "+persona3.sexo);
            Console.WriteLine("PESO: "+persona3.peso);
            Console.WriteLine("ALTURA: "+persona3.altura);
            Console.ReadKey();
        }
    }
}
