using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia)
            : base(numero, escuderia)
        {
        }
        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.Cilindrada}");
            return sb.ToString();
        }
        public static bool operator ==(MotoCross moto1, MotoCross moto2)
        {
            return moto1.Numero == moto2.Numero && moto1.Escuderia == moto2.Escuderia && moto1.cilindrada == moto2.cilindrada;
        }
        public static bool operator !=(MotoCross moto1, MotoCross moto2)
        {
            return !(moto1 == moto2);
        }
    }
}
