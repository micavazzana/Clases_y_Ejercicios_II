using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        private int cantidadCompetidores;
        private List<Equipo> equipos;
        private string nombre;

        private Competencia(string nombre)
            : this(nombre, 5)
        {
        }
        public Competencia(string nombre, int cantidadCompetidores)
        {
            this.nombre = nombre;
            this.cantidadCompetidores = cantidadCompetidores;
            this.equipos = new List<Equipo>();
        }
        public int CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }
        public List<Equipo> Equipos
        {
            get
            {
                return this.equipos;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        //sobrecargas
        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
        }
        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            foreach (Equipo e in torneo.Equipos)
            {
                if (e == equipo)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }
        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {
            if (torneo != equipo && torneo.CantidadCompetidores > torneo.Equipos.Count)
            {
                torneo.Equipos.Add(equipo);
            }
            return torneo;
        }
        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre de competencia: {torneo.Nombre}");
            sb.AppendLine($"Cantidad de competidores: {torneo.CantidadCompetidores}");
            sb.AppendLine($"Equipos: ");
            foreach (Equipo e in torneo.Equipos)
            {
                if (e is EquipoBasket)
                    sb.AppendLine(e.ToString());
                else
                    sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}
