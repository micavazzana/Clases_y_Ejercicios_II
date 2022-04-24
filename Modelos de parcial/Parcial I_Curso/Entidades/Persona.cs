using System;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.Documento = documento;
            this.apellido = apellido;
        }

        public string Apellido
        {
            get { return this.apellido; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Documento
        {
            get 
            { 
                return this.documento; 
            }
            set
            {
                if (ValidarDocumentacion(value))
                    this.documento = value;
            }
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Documento: {this.Documento}");
            return sb.ToString();
        }

        protected abstract bool ValidarDocumentacion(string documento);
    }
}
