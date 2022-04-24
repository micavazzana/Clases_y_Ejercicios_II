﻿using System;
using _Centralita;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            _Centralita.Centralita c = new _Centralita.Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            c += l1;
            c += l2;
            c += l3;
            c += l4;
            c += l3;
            
            Console.WriteLine("Lista ordenada");
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
