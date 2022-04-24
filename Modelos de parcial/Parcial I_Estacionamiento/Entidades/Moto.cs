using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private int ruedas;
        static int valorHora;
        static Moto()
        {
            Moto.valorHora = 30;
        }
        public Moto(string patente, int cilindrada, short ruedas, int valorHora)
            : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
            Moto.valorHora = valorHora;
        }
        public Moto(string patente, int cilindrada, short ruedas)
            : this(patente, cilindrada,ruedas,Moto.valorHora)
        {
        }
        public Moto(string patente, int cilindrada) 
            : this(patente,cilindrada,2)
        {          
        }    

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            sb.AppendLine($"Ruedas: {this.ruedas}");
            sb.AppendLine($"Valor hora: {Moto.valorHora}");
            return sb.ToString();
        }
        
        public override string ImprimirTicket()
        {
            TimeSpan intervalo = DateTime.Now - base.ingreso;
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ImprimirTicket()}");
            sb.AppendLine($"Costo estadia: ${Moto.valorHora * intervalo.Hours}");
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
    }
}
