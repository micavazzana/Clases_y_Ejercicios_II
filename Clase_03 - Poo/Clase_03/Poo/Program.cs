using System;
using Entidades;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////EJEMPLO DE DECLARACION DE OBJETOS CON CONSTRUCTORES - CLASE MASCOTA//////////////
            Mascota gato = new Mascota("Bola de nieve", "Gato", 2);
            Mascota perro = new Mascota("Ayudante de Santa","Perro", 5);

            Console.WriteLine(perro.Saludar());
            Mascota.Alimentar(perro);
            Console.WriteLine($"Hambre:{perro.hambre}");
            Console.WriteLine($"Hambre:{perro.raza}");

            Console.WriteLine(gato.Saludar());
            Console.WriteLine($"Hambre:{gato.hambre}");
            Mascota.Alimentar(gato);
            Console.WriteLine($"Hambre del gato despues de alimentado:{gato.hambre}");

            ////////////////////EJEMPLO CON CLASE AUTO//////////////

            Auto a1 = new Auto("AA125MK", "Ford", "Falcon");
            Auto a2 = new Auto("AA126MK", "Fiat", "Duna");

            Console.WriteLine($"La patente de a1 es: {a1.GetPatente()}");
            a1.SetPatente("AA127MI");
            Console.WriteLine($"La nueva patente de a1 es: {a1.GetPatente()}");

            Console.WriteLine($"El precio de la hora es {Auto.GetPrecioHora()}");
            a1.SetCantidadHoras(5);
            a2.SetCantidadHoras(2);

            Console.WriteLine($"El a1 estuvo {a1.GetCantidadHoras()} horas");
            Console.WriteLine($"El precio a pagar de a1: {a1.CalcularCostoEstadia()}");

            Console.WriteLine($"El a2 estuvo {a2.GetCantidadHoras()} horas");
            Console.WriteLine($"El precio a pagar de a2: {a2.CalcularCostoEstadia()}");
        }
    }
}
