using System;
using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo("Los pikachu",new DirectorTecnico("Profesor","Oak"));
            Jugador j1 = new Jugador("Pika","Chu",10,true);
            Jugador j2 = new Jugador("Char", "Mander", 5,false);
            Jugador j3 = new Jugador("Squ", "Artle", 7, false);
            Jugador j4 = new Jugador("Bulba", "Saur", 9, false);

            equipo += j1;
            equipo += j2;
            equipo += j3;
            equipo += j4;
            equipo += j1;

            Console.WriteLine((string)equipo);
        }
    }
}
