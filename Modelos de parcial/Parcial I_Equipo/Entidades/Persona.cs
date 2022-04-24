using System;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre 
        { 
            get 
            { 
                return this.nombre;
            } 
        }
        public string Apellido
        { 
            get
            { 
                return this.apellido; 
            } 
        }

        protected virtual string NombreCompleto()
        {
            return String.Format($"{this.Nombre} {this.Apellido}");
        }

        protected abstract string FichaTecnica();
    }
}
