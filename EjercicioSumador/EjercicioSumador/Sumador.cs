using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSumador
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador()
            : this (0)
        {

        }

        public long Sumar(long a, long b)
        {
            long auxRetorno;

            this.cantidadSumas++;

            auxRetorno = a + b;

            return auxRetorno;
        }

        public string Sumar(string a, string b)
        {
            string auxRetorno;

            this.cantidadSumas++;

            auxRetorno = a+b;

            return auxRetorno;
        }
    }
}
