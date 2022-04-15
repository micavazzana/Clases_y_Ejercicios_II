using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        private int cantidadPasajeros;
        private short cantidadMarchas;
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, int cantidadPasajeros, short cantidadMarchas) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadPasajeros = cantidadPasajeros;
            this.cantidadMarchas = cantidadMarchas;
        }
        public int CantidadPasajeros 
        { 
            get
            {
                return this.cantidadPasajeros;
            }
            set
            {
                this.cantidadPasajeros = value;
            }
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
    }
}
