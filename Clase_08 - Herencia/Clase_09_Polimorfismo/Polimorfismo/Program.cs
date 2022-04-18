using System;
using Biblioteca;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Animal no definido",5);
            Gato g = new Gato("Don Gato",4);
            Animal b = new Gato("Benito",7);
            Perro p = new Perro("",5);
            Animal c = new Perro("",5);

            Console.WriteLine($"Soy un {a.GetType()} y hago {a.EmitirSonido()}");
            Console.WriteLine($"Soy un {g.GetType()} y hago {g.EmitirSonido()}");

            //Lo siguiente hace roar porque el tipo es el de la referencia y no el de la instancia
            Console.WriteLine($"Soy un {b.GetType()} y hago {b.EmitirSonido()}");
            Console.WriteLine($"Soy un {b.GetType()} y {((Gato)b).DominarElMundo()}");
            //Lo necesito castear porque la referencia sigue siendo de Animal. Lo resuelve cuando compila
            //El GetType si devuelve el tipo de la instancia, lo hace en tiempo de ejecucion no de compilacion

            Console.WriteLine($"Soy un {c.GetType()} y hago {c.EmitirSonido()}"); 
            //En este caso pq es herencia polimorfica no importa la referencia, sino el tipo de la instancia
            //Se resuelve en tiempo de ejecucion mientras que lo no polimorfico se resuelve en tiempo de compilacion
        }
    }
}
