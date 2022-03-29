using System;
using Entidades;

namespace Ejercicio_I01
{
    //Consigna#
    //Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.
    //Deberá tener los atributos:
    //titular que contendrá la razón social del titular de la cuenta.
    //cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
    //Construir los siguientes métodos para la clase:
    //Un constructor que permita inicializar todos los atributos.
    //Un método getter para cada atributo.
    //mostrar retornará una cadena de texto con todos los datos de la cuenta.
    //ingresar recibirá un monto para acreditar a la cuenta.Si el monto ingresado es negativo, no se hará nada.
    //retirar recibirá un monto para debitar de la cuenta.La cuenta puede quedar en negativo.
    //En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I01 - Creo que necesito un préstamo";

            Cuenta c1 = new Cuenta("Mica", 500);
            Console.WriteLine($"Cuenta 1: \n{c1.Mostrar()}");
            c1.Ingresar(110);
            Console.WriteLine($"Luego de hacer ingreso:\n{c1.Mostrar()}");
            c1.Retirar(650);
            Console.WriteLine($"Luego de hacer retiro:  \n{c1.Mostrar()}");

            Console.ReadKey();
        }
    }
}
