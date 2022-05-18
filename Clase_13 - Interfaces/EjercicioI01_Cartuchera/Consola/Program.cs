using Entidades;
using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            /*********************************/
            
            CartucheraMultiuso cartu = new CartucheraMultiuso();
            CartucheraSimple cartuSimple = new CartucheraSimple();

            cartu.Aniadir(miLapiz);
            cartu.Aniadir(miBoligrafo);
            cartuSimple.AniadirLapiz(miLapiz);
            cartuSimple.AniadirBoli(miBoligrafo);

            Console.WriteLine($"Pude escribir con cada uno de los items de mi Cartuchera Multiuso:{cartu.RecorrerElementos()}");
            Console.WriteLine($"Pude escribir con cada uno de los items de mi Cartuchera Simple:{cartu.RecorrerElementos()}");

            Console.ReadKey();
        }
    }
}
