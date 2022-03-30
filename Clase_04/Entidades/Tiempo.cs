using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tiempo
    {
        //SOBRECARGA DE CONSTRUCTORES

        private int hora;
        private int minutos;
        private int segundos;
        public Tiempo(int hora, int minutos, int segundos)
        {
            this.hora = hora;
            this.minutos = minutos;
            this.segundos = segundos;
        }
        public Tiempo(int hora, int minutos) : this(hora, minutos, 0)
        {

        }
        public Tiempo(int hora) : this(hora, 1)
        {

        }
        public string Mostrar()
        {
            return $"{this.hora} : {this.minutos} : {this.segundos}";
        }

        ///SOBRECARGA DE OPERADORES
        
        public static bool operator == (Tiempo t1, Tiempo t2)
        {
            return t1.hora == t2.hora && t1.minutos == t2.minutos && t1.segundos == t2.segundos;
        }
        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1==t2);
        }

        ///SOBRECARGA OPERADORES DE CONVERSION

        public static implicit operator int(Tiempo t)
        {
            return (((t.hora * 60) + t.minutos) * 60) + t.segundos;
        }

        public static explicit operator Tiempo(string t)
        {
            string[] tiempoStr = t.Split(':');
            return new Tiempo(int.Parse(tiempoStr[0]), int.Parse(tiempoStr[1]), int.Parse(tiempoStr[2]));
        }

        //public static implicit operator Tiempo(string t)
        //{
        //    string[] tiempoStr = t.Split(':');
        //    return new Tiempo(int.Parse(tiempoStr[0]), int.Parse(tiempoStr[1]), int.Parse(tiempoStr[2]));
        //}
        //public static explicit operator int(Tiempo t)
        //{
        //    return (((t.hora * 60) + t.minutos) * 60) + t.segundos;
        //}
    }
}

