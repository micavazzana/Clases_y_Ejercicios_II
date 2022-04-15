using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        private int pesoCarga;
        private short cantidadMarchas;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, int pesoCarga, short cantidadMarchas)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.pesoCarga = pesoCarga;
            this.cantidadMarchas = cantidadMarchas;
        }
        public short CantidadMarchas
        {
            get
            {
                return this.cantidadMarchas;
            }
            set
            {
                this.cantidadMarchas = value;
            }
        }
        public int PesoCarga
        {
            get
            {
                return this.pesoCarga;
            }
            set
            {
                this.pesoCarga = value;
            }
        }
    }
}
