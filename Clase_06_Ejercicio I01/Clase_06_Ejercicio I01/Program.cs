using System;
using System.Collections.Generic;

namespace Clase_06_Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random numeroRandom = new Random();

            for (int i = 0; i < 20; i++)
            {
                numeros.Add(numeroRandom.Next(-25, 25));//le doy un rango falopa
            }
            Console.WriteLine("Lista de numeros:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("---------ORDENO POSITIVOS DE MANERA DECRECIENTE--------");
            numeros.Sort(CompararDescendente);
            foreach (int numero in numeros)
            {
                if(numero > 0)
                    Console.WriteLine(numero);
            }
            Console.WriteLine("---------ORDENO NEGATIVOS DE MANERA CRECIENTE--------");
            numeros.Sort(CompararAscendente);
            foreach (int numero in numeros)
            {
                if (numero < 0)
                    Console.WriteLine(numero);
            }
        }
        //Orden Descendente
        //Si A menor a B devuelve un negativo
        //Si A mayor a B devuelve un positivo
        //Si son iguales 0
        public static int CompararDescendente(int a, int b)
        {
            return b - a;
        }
        //Orden Ascendente
        //Si A mayor a B devuelve un negativo
        //Si A menor a B devuelve un positivo
        //Si son iguales 0
        public static int CompararAscendente(int a, int b)
        {
            return a - b;
        }
    }
}