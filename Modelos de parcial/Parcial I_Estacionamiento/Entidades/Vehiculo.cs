using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;
        public Vehiculo(string patente)
        {
            this.patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                int i = 0;
                foreach (char item in value)
                {
                    ++i;
                }
                if (i == 6)
                    this.patente = value;
            }
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return String.Format("Patente {0}", this.Patente);
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(sb.ToString());
            sb.AppendLine($"Fecha ingreso: {ingreso.Date}");
            sb.AppendLine($"Hora ingreso: {ingreso.Hour}");
            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente && v1.Equals(v2);
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
