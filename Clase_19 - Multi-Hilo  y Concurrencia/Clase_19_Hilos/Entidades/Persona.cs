using System;

namespace Entidades
{
    public class Persona
    {
        private int edad;
        public Persona(int edad) => this.edad = edad;
        public int Edad { get => edad; set => edad = value; }

        public static explicit operator Persona(int edad)  => new Persona(edad);
    }
}
