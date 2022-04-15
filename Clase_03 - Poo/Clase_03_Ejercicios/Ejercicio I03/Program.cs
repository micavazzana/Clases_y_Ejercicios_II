using System;
using Entidades;
namespace Ejercicio_I03
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Green","121212","Dallas");
            Estudiante e2 = new Estudiante("Pettit", "568923","George");   
            Estudiante e3 = new Estudiante("MacNeil","524521","Wade");

            e1.SetNotaPrimerParcial(5);
            e1.SetNotaSegundoParcial(8);
            e2.SetNotaPrimerParcial(9);
            e2.SetNotaSegundoParcial(4);
            e3.SetNotaPrimerParcial(2);
            e3.SetNotaSegundoParcial(1);

            Console.WriteLine(Estudiante.Mostrar(e1));
            Console.WriteLine(Estudiante.Mostrar(e2));
            Console.WriteLine(Estudiante.Mostrar(e3));
        }
    }
}
