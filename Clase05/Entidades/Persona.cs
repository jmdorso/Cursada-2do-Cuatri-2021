using System;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }


    }
}
