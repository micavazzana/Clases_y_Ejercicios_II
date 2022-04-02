using System;
using Entidades;

namespace Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I01 - Creo que necesito un préstamo";

            Cuenta c1 = new Cuenta("Mica", 500);
            Console.WriteLine($"Cuenta 1: \n{c1.Mostrar()}");
            c1.Ingresar(110);
            Console.WriteLine($"Luego de hacer ingreso:\n{c1.Mostrar()}");
            c1.Retirar(650);
            Console.WriteLine($"Luego de hacer retiro:  \n{c1.Mostrar()}");

            Console.ReadKey();
        }
    }
}
