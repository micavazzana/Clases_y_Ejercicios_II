using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Moto : Vehiculo
    {
        public enum ETipo
        {
            Ciclomotor, Scooter, Sport
        }

        private ETipo tipo;
        private static double valorHora;

        static Moto()
        {
            Moto.valorHora = 100;
        }
        public Moto(string patente, DateTime horaIngreso, ETipo tipo) 
            : base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }

        public static double ValorHora
        {
            set
            {
                double valorAux = value;
                if (valorAux > 0)
                    Moto.valorHora = valorAux;
            }
        }
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        public override string Descripcion
        {
            get
            {
                if(ETipo.Ciclomotor == this.tipo)
                    return "Ciclomotor";
                else if (ETipo.Scooter == this.tipo)
                    return "Scooter";
                else
                    return "Sport";
            }
        }
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Moto.valorHora;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"******MOTO******");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Tipo: {this.Descripcion}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
