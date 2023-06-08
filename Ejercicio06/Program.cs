using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Libro
    {
        private int isbn;
        private string titulo;
        private string autor = "autor";
        private int paginas = 0;

        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value;}
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }

        public Libro() { }
        public Libro(int isbn, string autor, int paginas)
        {
            this.isbn = isbn;
            this.autor = autor;
            this.paginas = paginas;
        }
        public Libro(int isbn,string titulo,string autor, int paginas)
        {
            this.isbn=isbn;
            this.autor = autor;
            this.paginas=paginas;
            this.titulo = titulo;
        }
        public string Mostrar()
        {
            return "El libro con " + isbn + " creado por " + autor + " tiene " + paginas + " paginas";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Libro libro1 = new Libro(94658115, "Sherlock holmes", "Arthur Conan Doyle", rnd.Next(1, 999));
            Libro libro2 = new Libro(44550013, "JK.Rowling", rnd.Next(1, 999));
                Console.WriteLine(libro1.Mostrar());
                Console.WriteLine(libro2.Mostrar());
                Console.ReadKey();
                Console.Clear();
                if (libro1.Paginas > libro2.Paginas)
                {
                    Console.WriteLine("El libro con mas paginas es: ");
                    Console.WriteLine(libro1.Mostrar());
                }
                else
                {
                    Console.WriteLine("El libro con mas paginas es: ");
                    Console.WriteLine(libro2.Mostrar());
                }
                Console.ReadKey();
        }
    }
}
