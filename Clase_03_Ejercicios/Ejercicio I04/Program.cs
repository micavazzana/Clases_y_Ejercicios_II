using System;
using Entidades;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo b1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo b2 = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;

            Console.WriteLine($"Cantidad de tinta de b1 antes de pintar: {b1.GetTinta()}");
            b1.Pintar(100,out dibujo);//uso 100 de tinta
            Console.ForegroundColor = b1.GetColor();
            Console.WriteLine(dibujo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Cantidad de tinta de b1 despues de pintar usando 100: {b1.GetTinta()}");
            b1.Recargar();
            Console.WriteLine($"Cantidad de tinta de b1 despues de recarga: {b1.GetTinta()}");

            Console.WriteLine($"\nCantidad de tinta de b2 antes de pintar: {b2.GetTinta()}");
            b2.Pintar(47, out dibujo);
            Console.ForegroundColor = b2.GetColor();
            Console.WriteLine(dibujo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Cantidad de tinta de b2 despues de pintar usando 47: {b2.GetTinta()}");
            Console.WriteLine("Intento pintar 10:");
            b2.Pintar(10, out dibujo);
            Console.ForegroundColor = b2.GetColor();
            Console.WriteLine(dibujo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Cantidad de tinta de b2 despues de pintar: {b2.GetTinta()}");
            b2.Recargar();
            Console.WriteLine($"Cantidad de tinta de b2 despues de recarga: {b1.GetTinta()}");
            b2.Pintar(58, out dibujo);
            Console.ForegroundColor = b2.GetColor();
            Console.WriteLine(dibujo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Cantidad de tinta de b2 despues de pintar: {b2.GetTinta()}");
            b2.Recargar();
            Console.WriteLine($"Cantidad de tinta de b2 despues de recarga: {b1.GetTinta()}");
        }

    }
}
