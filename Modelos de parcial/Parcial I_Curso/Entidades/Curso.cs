using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profesor)
            : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        public string AnioDivision
        {
            get
            {
                return String.Format($"{this.anio}°{this.division}");
            }
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Curso: {c.AnioDivision}");
            sb.AppendLine($"Profesor: {c.profesor.ExponerDatos()}");
            sb.AppendLine("Alumnos:");
            foreach (Alumno alumno in c.alumnos)
            {
                sb.AppendLine(alumno.ExponerDatos());
            }
            return sb.ToString();

        }
        public static bool operator ==(Curso c, Alumno a)
        {
            if (c.AnioDivision == a.AnioDivision)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }
    }
}
