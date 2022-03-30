using System;
using Billetes;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peso p = new Peso(225);
            Euro e = new Euro(8);
            Dolar d = new Dolar(50);
            Peso p2 = new Peso(5132.5);

            Console.WriteLine("\nCONVERSIONES: \n");
            Console.WriteLine($"Cantidad de dolares: {d.GetCantidad()}"+
                $"\n En pesos: {((Peso)d).GetCantidad()}" +
                $"\n En euros: {((Euro)d).GetCantidad()}");

            Console.WriteLine($"Cantidad de pesos: {p.GetCantidad()}" +
                $"\n En dolares: {((Dolar)p).GetCantidad()}"+
                $"\n En euros: {((Euro)p).GetCantidad()}");
           
            Console.WriteLine($"Cantidad de euros: {e.GetCantidad()}" +
                $"\n En dolares: {((Dolar)e).GetCantidad()}" +
                $"\n En pesos: {((Peso)e).GetCantidad()}");


            Console.WriteLine("\nOPERADORES: \n");
            Console.WriteLine($"Cantidad de dolares es igual a cantidad de pesos: {d==p}");//false
            Console.WriteLine($"Cantidad de dolares es igual a cantidad de pesos2: {d == p2}");//true
            Console.WriteLine($"Cantidad de dolares es igual a cantidad de pesos2: {d != p2}");//false


            Console.WriteLine("\nSUMAS Y RESTAS: \n");
            Console.WriteLine("En euros: ");
            Console.WriteLine($"Resta entre euros y dolares: {(e - d).GetCantidad()}"+
                              $"\nResta entre euros y pesos: {(e - p).GetCantidad()}"+
                              $"\nSuma entre euros y dolares: {(e + d).GetCantidad()}"+
                              $"\nSuma entre euros y dolares: {(e + d).GetCantidad()}");

            Console.WriteLine("\nEn dolares: ");
            Console.WriteLine($"Resta entre dolar y pesos: {(d - p).GetCantidad()}" +
                              $"\nResta entre dolar y euros: {(d - e).GetCantidad()}" +
                              $"\nSuma entre dolar y pesos: {(d + p).GetCantidad()}" +
                              $"\nSuma entre dolar y euros: {(d + e).GetCantidad()}");

            Console.WriteLine("\nEn pesos: ");
            Console.WriteLine($"Resta entre pesos y dolares: {(p - d).GetCantidad()}" +
                              $"\nResta entre pesos y euros: {(p - e).GetCantidad()}" +
                              $"\nSuma entre pesos y dolares: {(p + d).GetCantidad()}" +
                              $"\nSuma entre pesos y euros: {(p + e).GetCantidad()}");
            Console.ReadKey();
        }
    }
}
