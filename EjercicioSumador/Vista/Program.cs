using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioSumador;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(5);
            Sumador s2 = new Sumador();

            Console.WriteLine(s1.Sumar(5, 5));
            Console.WriteLine(s2.Sumar("hola", "mundo"));

            Console.ReadKey();

        }
    }
}
