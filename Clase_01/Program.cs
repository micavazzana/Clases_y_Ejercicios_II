using System;

namespace Clase_01
{
    //Ingresar 5 números por consola, guardándolos en una variable escalar.
    //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string strNum;
            int max = int.MaxValue;
            int min = int.MinValue;
            int acum = 0;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un num: ");
                strNum = Console.ReadLine();
                if (int.TryParse(strNum, out num))
                {
                    if (num > max || i == 0)
                    {
                        max = num;
                    }
                    if (num < min || i == 0)
                    {
                        min = num;
                    }
                    acum = acum + num;
                }
                else
                {
                    Console.WriteLine("No ingresaste un numero");
                    i--;
                }
            }
            promedio = (float)acum / 5;
            Console.WriteLine($"El numero maximo: {max}, el numero minimo: {min}, el promedio: {promedio}");
            Console.ReadKey();
        } 
    }
}
