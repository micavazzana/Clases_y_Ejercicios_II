using System;
using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador(1);

            Console.WriteLine(s1.Sumar("Mica", "Vaz")); //cant sumas = 1
            Console.WriteLine(s2.Sumar(5, 6)); //cant sumas = 2
            Console.WriteLine((int)s1);
            Console.WriteLine((int)s2);
            Console.WriteLine(s1 + s2);
            Console.WriteLine(s1 | s2); //false
            Console.WriteLine(s1.Sumar(2,5));//cant sumas = 2
            Console.WriteLine(s1 | s2); //true
        }
    }
}
