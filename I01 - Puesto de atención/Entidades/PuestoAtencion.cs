using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto { Caja1, Caja2}

        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual 
        {
            get
            {
                return numeroActual + 1;
            }
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            bool auxRetorno = false;

            if(cli is not null)
            {
                Console.WriteLine("Usted sera atendido en 5 segundos...");
                Thread.Sleep(5000);
                auxRetorno = true;
            }

            return auxRetorno;
        }
    }
}
