using System;

namespace Entidades
{
    public class Sumador
    {
        //SOBRECARGAS - Metodos que pueden llamarse igual. La condicion es tener distintos parametros
        public static int Sumar(int operando1, int operando2)
        {
            return operando1 + operando2;
        }
        public static int Sumar(int operando1, int operando2, int operando3)
        {
            int resultado = Sumar(operando1, operando2);
            return resultado + operando3;
        }
        public static int Sumar(float operando1, float operando2)
        {
            return (int)(operando1 + operando2);
        }
        public static string Sumar(string operando1, string operando2)
        {
            return operando1 + operando2;
        }
    }

    public static class Validadora
    {
        public static bool ValidarRango(int valor, int max)
        {
            return valor <= max;
        }
        public static bool ValidarRango(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
        public static bool ValidarRango(string valor, int min, int max)
        {
            return valor.Length >= min && valor.Length <= max;
        }
    }
}
