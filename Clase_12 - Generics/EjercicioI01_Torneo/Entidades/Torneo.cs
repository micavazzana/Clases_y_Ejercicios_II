using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T e)
        {
            foreach (T elemento in torneo.equipos)
            {
                if(elemento == e)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T e)
        {
            return !(torneo == e);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T e)
        {
            if(torneo != e)
            {
                torneo.equipos.Add(e);
            }
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            foreach (T equipo in this.equipos)
            {
                sb.AppendLine($"{equipo.Ficha()}");
            }
            return sb.ToString();     
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random resultadoPartido = new Random();
            return $"{equipo1.Nombre} - {resultadoPartido.Next(0,10)} | {equipo2.Nombre} - {resultadoPartido.Next(0, 10)}";
        }

        public string JugarPartido
        {
            get
            {
                Random indiceRandom = new Random();
                T equipo1;
                T equipo2;
                do
                {
                    equipo1 = this.equipos[indiceRandom.Next(0, equipos.Count)];
                    equipo2 = this.equipos[indiceRandom.Next(0, equipos.Count)];
                } while (equipo1 == equipo2);
                return CalcularPartido(equipo1,equipo2);
            }
        }
    }
}
