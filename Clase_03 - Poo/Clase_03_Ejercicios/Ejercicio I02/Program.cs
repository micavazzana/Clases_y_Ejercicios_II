using System;
using Entidades;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Robocop", "28/09/1989", 34526588);
            Persona p2 = new Persona("Robotina", "13/04/1993", 34212525);
            Persona p3 = new Persona("R2D2", "23/07/2015", 32351512);

            Console.WriteLine(Persona.Mostrar(p1));
            Console.WriteLine(Persona.EsMayorDeEdad(p1));
            Console.WriteLine(Persona.Mostrar(p2));
            Console.WriteLine(Persona.EsMayorDeEdad(p2));
            Console.WriteLine(Persona.Mostrar(p3));
            Console.WriteLine(Persona.EsMayorDeEdad(p3));
        }
    }
}
