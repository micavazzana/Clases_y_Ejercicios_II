using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadoresEstrellas;
        public EquipoFutbol(string nombre) 
            : this(nombre, false)
        {
        }
        public EquipoFutbol(string nombre, bool jugadoresEstrella) 
            : base(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrella;
        }

        public override int GetDificultad()
        {
            Random rnd = new Random();
            if (this.jugadoresEstrellas)
            {
                return (rnd.Next(7, 10))*2;
            }
            else
            {
                return rnd.Next(7, 10);
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Futbol - ");
            sb.Append(base.MostrarDatos());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
