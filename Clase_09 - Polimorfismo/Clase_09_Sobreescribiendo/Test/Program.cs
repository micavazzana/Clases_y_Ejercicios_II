using System;
using Biblioteca;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            //Sobrescrito objetoSobrescrito = new Sobrescrito();
            Sobrescrito sobreSobre = new SobreSobreescrito();

            Console.WriteLine(sobreSobre.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobreSobre.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobreSobre.GetHashCode());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobreSobre.MiMetodo());

            Console.ReadKey();
        }
    }
}
