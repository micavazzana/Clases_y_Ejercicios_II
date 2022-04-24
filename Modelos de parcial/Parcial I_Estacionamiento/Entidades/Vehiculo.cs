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
            this.Patente = patente;
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
                if(value.Length == 6)             
                    this.patente = value;
            }
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            string retorno = "Patente invalida";
            if(this.Patente is not null)
                retorno = String.Format("Patente {0}", this.Patente);
            return retorno;
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(sb.ToString());
            sb.AppendLine($"Fecha ingreso: {ingreso.ToShortDateString()}");
            sb.AppendLine($"Hora ingreso: {ingreso.ToShortTimeString()}");
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
