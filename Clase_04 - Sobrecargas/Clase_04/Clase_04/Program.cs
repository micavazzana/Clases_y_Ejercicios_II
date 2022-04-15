using System;
using Entidades;

namespace Clase_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SOBRECARGA DE CONSTRUCTORES
            Tiempo t1 = new Tiempo(21, 35, 40);
            Tiempo t2 = new Tiempo(20, 30);
            Tiempo t3 = new Tiempo(30);
            Tiempo t4 = new Tiempo(21, 35, 40);

            Console.WriteLine($"El tiempo 1 es: {t1.Mostrar()}");
            Console.WriteLine($"El tiempo 2 es: {t2.Mostrar()}");
            Console.WriteLine($"El tiempo 3 es: {t3.Mostrar()}");
            Console.WriteLine($"El tiempo 4 es: {t4.Mostrar()}");

            //SOBRECARGA DE OPERADORES
            Console.WriteLine($"El tiempo 1 y el tiempo 4 es igual: {t1 == t4}"); // true
            Console.WriteLine($"El tiempo 1 y el tiempo 2 es igual: {t1 == t2}"); //false
            Console.WriteLine($"El tiempo 1 y el tiempo 4 son distintos: {t1 != t4}"); //false

            //SOBRECARGA DE OPERADOR DE CONVERSION
            int segundo = t1;
            Console.WriteLine($"El tiempo 1 expresado en segundos: {segundo}");
            // int num;
            // float numF;
            // numF = num; IMPLICITO

            Tiempo tConvExplicita = (Tiempo)"21:50:11";
            Console.WriteLine(tConvExplicita.Mostrar());
            //num = (int)numF; EXPLICITO
        }
    }
}
