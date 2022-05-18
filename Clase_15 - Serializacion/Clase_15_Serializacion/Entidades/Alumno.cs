using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Alumno : Persona
    {
        private List<string> materias;
        private float nota;
        public Alumno() : base()
        {
            this.materias = new List<string>();
        }

        public Alumno(string nombre, int edad, float nota) : base(nombre, edad)
        {

            this.materias = new List<string>();
            this.nota = nota;
        }
        public float Nota { get => this.nota; set => this.nota = value; }
        public override string Nombre { get => this.nombre; set => this.nombre = value; }
        public override int Edad { get => this.edad; set => this.edad = value; }
        public List<string> Materias { get => this.materias; set => this.materias = value; }

        public override string ToString()
        {
            string materias = String.Empty;
            this.materias.ForEach(m => materias += " " + m);
            return $"{base.nombre}, {base.edad}, {materias}";
        }
    }
}
