using System;
using Entidades;

namespace Ejercicio_ViajarEsUnPlacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camioncito = new Camion(8, 2, VehiculoTerrestre.Colores.Azul, 5000,8);
            Automovil autito = new Automovil(4, 5, VehiculoTerrestre.Colores.Blanco, 3, 5);
            Moto motito = new Moto(2, 0, VehiculoTerrestre.Colores.Rojo, 1000);

            Console.WriteLine($"Camion Kenworth " +
                $"\nCantidad Ruedas: {camioncito.CantidadRuedas}" +
                $"\nCantidad Puertas: {camioncito.CantidadPuertas}" +
                $"\nColor: {camioncito.Color}\nCantidad Marchas: {camioncito.CantidadMarchas}" +
                $"\nPeso Carga {camioncito.PesoCarga}");
            
            Console.WriteLine($"---------------\nAutomovil Peugeot" +
                $"\nCantidad Ruedas: {autito.CantidadRuedas}" +
                $"\nCantidad Puertas: {autito.CantidadPuertas}" +
                $"\nColor: {autito.Color}\nCantidad Marchas: {autito.CantidadMarchas}" +
                $"\nCantidad Pasajeros: {autito.CantidadPasajeros}");
            
            Console.WriteLine($"---------------\nMoto Motomel" +
                $"\nCantidad Ruedas: {motito.CantidadRuedas}" +
                $"\nCantidad Puertas: {motito.CantidadPuertas}" +
                $"\nColor: {motito.Color}" +
                $"\nCilindrada: {motito.Cilindrada}");
        }
    }
}