using System;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(string nombre, int numero)
           : this(numero)
        {
            this.nombre = nombre;
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool auxRetorno = false;

            if(c1.Numero == c2.Numero)
            {
                auxRetorno = true;
            }

            return auxRetorno;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }


    }
}
