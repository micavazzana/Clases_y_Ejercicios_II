using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        static int valorHora;

        static PickUp()
        {
            PickUp.valorHora = 70;
        }
        public PickUp(string patente, string modelo) 
            : base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente, string modelo, int valorHora) 
            : this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
           // sb.AppendLine(base.Patente);
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Valor hora: {PickUp.valorHora}");
            return sb.ToString();
        }
        public override string ImprimirTicket()
        {
            DateTime tiempo = DateTime.Now;
            TimeSpan intervalo = tiempo - base.ingreso;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ImprimirTicket()}");
            sb.AppendLine($"Costo estadia: {PickUp.valorHora * intervalo}");
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
    }
}
