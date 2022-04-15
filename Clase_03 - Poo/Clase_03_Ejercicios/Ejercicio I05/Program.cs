using System;
using Entidades;
using Geometria;

namespace Ejercicio_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r = new Rectangulo(new Punto(8, 5), new Punto(3, 2));
            
            Console.WriteLine($"El area del rectangulo: {r.GetArea()}"
                            + $"\nEl Perimetro: {r.GetPerimetro()}");
        }
    }
}
