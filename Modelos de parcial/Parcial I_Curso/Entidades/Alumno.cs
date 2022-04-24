using System;
using System.Text;

namespace Entidades
{
    public enum Divisiones
    {
        A, B, C, D, E
    }
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;
        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public string AnioDivision
        {
            get
            {
                return String.Format($"{this.anio}°{this.division}");
            }
        }
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ExponerDatos());
            sb.AppendLine($"Año y Division: {this.AnioDivision}");
            return sb.ToString();
        }
        protected override bool ValidarDocumentacion(string documento)
        {
            if(documento[2] != '-' || documento[7] != '-')
            {
                return false;
            }
            return true;
        }

    }
}
