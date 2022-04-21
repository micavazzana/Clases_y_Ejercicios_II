using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        static int valorHora;

        static Automovil()
        {
            Automovil.valorHora = 50;
        }
        public Automovil(string patente, ConsoleColor color) 
            : base(patente)
        {
            this.color = color;
        }
        public Automovil(string patente, ConsoleColor color, int valorHora) 
            : this(patente,color)
        {
            Automovil.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Valor hora: {Automovil.valorHora}");
            return sb.ToString();
        }
        public override string ImprimirTicket()
        {
            DateTime tiempo = DateTime.Now;
            TimeSpan intervalo = tiempo - base.ingreso;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ImprimirTicket()}");
            sb.AppendLine($"Costo estadia: {Automovil.valorHora * intervalo}");
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
    }
}
