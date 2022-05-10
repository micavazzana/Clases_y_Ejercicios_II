using System;
using Entidades;

namespace Clase12_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Mica", "Vazzana", "34573250");
            Animal a = new Animal("Mich", "Siames", "Gato");

            CentroDeAtencion<Persona> centroDeAtencion = new CentroDeAtencion<Persona>();
            centroDeAtencion.AgregarALaLista(p);
            Console.WriteLine(centroDeAtencion.MostrarDatos());
            
            CentroDeAtencion<Animal> centroDeAtencionAnimal = new CentroDeAtencion<Animal>();
            centroDeAtencionAnimal.AgregarALaLista(a);
            Console.WriteLine(centroDeAtencionAnimal.MostrarDatos());
        }
    }
}
