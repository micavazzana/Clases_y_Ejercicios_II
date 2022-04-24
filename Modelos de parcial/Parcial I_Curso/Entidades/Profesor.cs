using System;
using System.Text;

namespace Entidades
{
    public class Profesor : Persona
    {
        DateTime fechaIngreso;

        
        public Profesor(string nombre, string apellido, string documento) 
            : base(nombre, apellido, documento)
        {
        }
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            :this(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        public int Antiguedad
        {
            get
            {
                TimeSpan intervalo = DateTime.Now - fechaIngreso;
                return intervalo.Days;
            }
        }
       
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ExponerDatos());
            sb.AppendLine($"Fecha de ingreso: {this.fechaIngreso}");
            return sb.ToString();
        }
        protected override bool ValidarDocumentacion(string documento)
        {
            int documentoAuxiliar;
            if (int.TryParse(documento, out documentoAuxiliar) && documento.Length == 8)
            {
                return true;
            }
            return false;
        }
    }
}
