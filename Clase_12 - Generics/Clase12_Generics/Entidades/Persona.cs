using System;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public string Dni { get { return dni; } }

        public override string ToString()
        {
            return $"Soy una Persona \n Nombre:{this.Nombre} Apellido: {this.Apellido} Dni: {this.Dni}";
        }
    }
}
