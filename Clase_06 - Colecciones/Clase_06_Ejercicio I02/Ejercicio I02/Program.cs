using System;
using System.Collections.Generic;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Queue<int> cola = new Queue<int>();
            Stack<int> pila = new Stack<int>();
            Random r = new Random();

            for (int i = 0; i < 20; i++) //añado numeros a lista
            {
                lista.Add(r.Next(-25, 25));
            }

            Console.WriteLine("---------------------------\nLISTA");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------\nLISTA ORDENADA");
            lista.Sort(OrdenDescendente);
            foreach (int i in lista) //muestro
            {
                Console.WriteLine(i);
            }

            //-----------------------------------
            foreach (int i in lista)//añado positivos
            {
                if (i > 0)
                    cola.Enqueue(i);
                else if (i != 0)
                    pila.Push(i);
            }
            foreach (int i in lista)//añado negativos 
            {
                if (i < 0)
                    cola.Enqueue(i);
                else if (i != 0)
                    pila.Push(i);
            }

            //---------------------------------------------

            Console.WriteLine("\n---------------------------\nCOLA POSITIVOS");
            foreach (int i in cola)
            {
                if (i > 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("\n---------------------------\nPILA POSITIVOS");
            foreach (int i in pila)
            {
                if (i > 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("\n---------------------------\nCOLA NEGATIVOS");
            foreach (int i in cola)
            {
                if (i < 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("\n---------------------------\nPILA NEGATIVOS");
            foreach (int i in pila)
            {
                if (i < 0)
                    Console.WriteLine(i);
            }
        }
        public static int OrdenDescendente(int a, int b)
        {
            return b - a;
        }
    }
}
