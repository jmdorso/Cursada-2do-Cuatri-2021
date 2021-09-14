using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                _ = this + value;
            }
        }
            

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool auxRetorno = false;

            foreach (Cliente cliente in n.clientes)
            {
                if (c == cliente)
                {
                    auxRetorno = true;
                }
            }

            return auxRetorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool auxRetorno = false;

            if(n != c)
            {
                n.clientes.Enqueue(c);
                auxRetorno = true;
            }

            return auxRetorno;
        }

        /*public static bool operator ~(Negocio n)
        {
            //bool auxRetorno = false;

            if()
        }*/

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }
    }
}
