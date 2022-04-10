using System;
using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private string nombre;
        private string direccion;
        private int edad;
        private string genero;
        private string[] cursos;
        private string pais;

        public Ingresante(string nombre, string direccion, int edad, string genero, string[] cursos, string pais)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.cursos = cursos;
            this.pais = pais;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Dirección: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Género: {this.genero}");
            sb.AppendLine($"País: {this.pais}");
            sb.AppendLine($"Curso/s:");
            foreach (string curso in this.cursos)
            {
                if(curso is not null)
                    sb.AppendLine(curso);
            }        
            return sb.ToString();
        }
    }
}
