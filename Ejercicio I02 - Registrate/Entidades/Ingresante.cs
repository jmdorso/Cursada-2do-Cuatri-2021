using System;
using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine($"Nombre: {this.nombre}");
            auxRetorno.AppendLine($"Direccion: {this.direccion}");
            auxRetorno.AppendLine($"Edad: {this.edad}");
            auxRetorno.AppendLine($"Género: {this.genero}");
            auxRetorno.AppendLine($"País: {this.pais}");
            auxRetorno.AppendLine($"Curso/s:");
            foreach (string curso in this.cursos)
            {
                auxRetorno.AppendLine($"{curso}");
            }
            

            return auxRetorno.ToString();
        }
       
    }
}
