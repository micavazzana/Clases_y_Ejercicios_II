using System;
using Entidades;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EquipoFutbol equipoFutbol1 = new EquipoFutbol("Los Pikachu", new DateTime(1989, 09, 28));
            EquipoFutbol equipoFutbol2 = new EquipoFutbol("Los Bulbasaur", new DateTime(1999, 09, 28));
            EquipoFutbol equipoFutbol3 = new EquipoFutbol("Los Charmander", new DateTime(1986, 09, 28));
            EquipoBasket equipoBasket1 = new EquipoBasket("Los Chicorita", new DateTime(1998, 09, 28));
            EquipoBasket equipoBasket2 = new EquipoBasket("Los Cindaquil", new DateTime(1994, 09, 28));
            EquipoBasket equipoBasket3 = new EquipoBasket("Los Totodile", new DateTime(1983, 09, 28));

            Torneo<EquipoFutbol> torneoFut = new Torneo<EquipoFutbol>("TorneoFut");
            Torneo<EquipoBasket> torneoBasket = new Torneo<EquipoBasket>("TorneoBasket");

            torneoFut += equipoFutbol1;
            torneoFut += equipoFutbol2;
            torneoFut += equipoFutbol3;
            torneoBasket += equipoBasket1;
            torneoBasket += equipoBasket2;
            torneoBasket += equipoBasket3;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"\nTorneo Futbol: {torneoFut.Mostrar()}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"\nTorneo Basket: {torneoBasket.Mostrar()}");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(torneoFut.JugarPartido);
            Console.WriteLine(torneoFut.JugarPartido);
            Console.WriteLine(torneoFut.JugarPartido);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(torneoBasket.JugarPartido);
            Console.WriteLine(torneoBasket.JugarPartido);
            Console.WriteLine(torneoBasket.JugarPartido);
        }
    }
}
