using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EquipoBasket : Equipo
    {
        public enum Eliga
        {
            NBA, EuroLeague, ACB
        }
        private Eliga liga;

        public EquipoBasket(string nombre)
            : this(nombre,Eliga.NBA)
        {
        }
        public EquipoBasket(string nombre, Eliga liga) 
            : base(nombre)
        {
            this.liga = liga;
        }

        public override int GetDificultad()
        {
            Random rnd = new Random();
            if (this.liga == Eliga.NBA)
            {
                return rnd.Next(8, 10);
            }
            else if (this.liga == Eliga.EuroLeague)
            {
                return rnd.Next(5, 10);
            }
            else 
            {
                return rnd.Next(1, 7);
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Basket - ");
            sb.Append(base.MostrarDatos());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
