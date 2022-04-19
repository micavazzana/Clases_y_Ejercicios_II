using System;
using Biblioteca;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaDeFiguras = new List<Figura>();
            Circulo circulito = new Circulo(5);
            Cuadrado cuadradito = new Cuadrado(2, 3);
            Rectangulo rectangulito = new Rectangulo(5, 9);
            int i = 0;

            listaDeFiguras.Add(circulito);
            listaDeFiguras.Add(cuadradito);
            listaDeFiguras.Add(rectangulito);

            foreach(Figura f in listaDeFiguras)
            {
                Console.WriteLine($"\n------------- FIGURA {++i} -------------");
                Console.WriteLine($"Tipo: {f.GetType()}");
                Console.WriteLine(f.Dibujar());
                Console.WriteLine($"Area: {Math.Round(f.CalcularSuperficie())}");
                Console.WriteLine($"Perimetro: {Math.Round(f.CalcularPerimetro())}");
                Console.WriteLine($"------------------------------------\n");
            }
        }
    }
}
