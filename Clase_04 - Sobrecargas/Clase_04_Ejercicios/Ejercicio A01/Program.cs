using System;
using Fahrenheit451;

namespace Ejercicio_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius c = new Celsius(28);
            Kelvin k = new Kelvin(320);
            Farenheit f = new Farenheit(245);


            Console.WriteLine("\nCONVERSIONES: \n");
            Console.WriteLine($"Grados Celsius: {c.GetGrados()}" +
                $"\n En grados Farenheit: {((Farenheit)c).GetGrados()}" +
                $"\n En grados Kelvin: {((Kelvin)c).GetGrados()}");

            Console.WriteLine($"\nGrados Farenheit: {f.GetGrados()}" +
                $"\n En grados Celsius: {((Celsius)f).GetGrados()}" +
                $"\n En grados Kelvin: {((Kelvin)f).GetGrados()}");

            Console.WriteLine($"\nGrados Kelvin: {k.GetGrados()}" +
                $"\n En grados Celsius: {((Celsius)k).GetGrados()}" +
                $"\n En grados Farenheit: {((Farenheit)k).GetGrados()}");
        }
    }
}
