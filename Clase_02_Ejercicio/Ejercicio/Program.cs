using System;
using BiblioClases;

namespace EjercicioI01
{
    //Ejercicio I01 - Validador de rangos
    //Realizar una clase llamada Validador que posea un método estático
    //llamado Validar con la siguiente firma: bool Validar(int valor, int min, int max)
    //Pedir al usuario que ingrese 10 números enteros.
    //Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
    //Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = int.MinValue;
            int maximo = int.MaxValue;
            int acumulador = 0;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero entre -100 y 100: ");
                if(int.TryParse(Console.ReadLine(), out numero))
                {
                    if (Validador.Validar(numero, -100, 100))
                    {
                        Console.WriteLine("Es valido");
                        if(numero < minimo || i == 0)
                        {
                            minimo = numero;
                        }
                        if(numero > maximo || i == 0)
                        {
                            maximo = numero;
                        }
                        acumulador = acumulador + numero;
                    }
                    else
                    {
                        Console.WriteLine("Esta fuera del rango requerido");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("No has ingresado un numero");
                    i--;
                }
            }
            promedio = (float)acumulador / 10;
            Console.WriteLine($"El promedio es: {promedio}, el minimo es: {minimo}, el maximo es: {maximo}");
        }
    }
}
