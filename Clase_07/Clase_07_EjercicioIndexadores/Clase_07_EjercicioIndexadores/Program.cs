using System;
using Entidades;

namespace Clase_07_EjercicioIndexadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "a";
            libro[1] = "b";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            libro[1] = "c";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
        }
    }
}
