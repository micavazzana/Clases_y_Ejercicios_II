using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Vehiculo
    {
        public enum EVehiculos
        {
            Automovil, Moto
        }
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }

        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;
            }
            set
            {
                if (value > this.horaIngreso)//revisar
                    this.horaEgreso = value;
            }
        }
        public DateTime HoraIngreso
        {
            get
            {
                return this.horaIngreso;
            }
        }
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                string valorAux = value;
                if (ValidarPatente(valorAux))
                    this.patente = valorAux;
            }
        }

        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; }

        private bool ValidarPatente(string patente)
        {
            if (patente.Length >= 6 && patente.Length <= 7)
            {
                return true;
            }
            return false;
        }
        protected virtual double CargoDeEstacionamiento()
        {
            TimeSpan intervalo = this.HoraEgreso - this.HoraIngreso;
            return intervalo.Hours;
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Hora de ingreso: {this.HoraIngreso}");
            return sb.ToString();
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
