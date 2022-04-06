using System;

namespace Clase_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayBidimensional();
        }

        static void ArrayBidimensional()
        {
            string[,] personas = new string[3, 2];

            personas[0, 0] = "Don Gato";
            personas[0, 1] = "34232111";
            personas[1, 0] = "Benito";
            personas[1, 1] = "34252686";
            personas[2, 0] = "Matute";
            personas[2, 1] = "34345456";

            for (int i = 0; i < personas.GetLength(0); i++)
            {
                Console.WriteLine($"Nombre: {personas[i, 0]} DNI: {personas[i, 1]}");
            }
        }
    }
}
