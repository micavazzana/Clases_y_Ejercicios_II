using System;
using Entidades;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recibo r1 = new Recibo();
            Recibo r2 = new Recibo(111);
            Factura f1 = new Factura(222);
            Factura f2 = new Factura(333);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += r1;
            contabilidad += r2;
            contabilidad += f1;
            contabilidad += f2;

            foreach (Factura factura in contabilidad.egresos)
            {
                Console.WriteLine(factura.Numero);
            }
            foreach (Recibo recibo in contabilidad.ingresos)
            {
                Console.WriteLine(recibo.Numero);
            }
        }
    }
}
