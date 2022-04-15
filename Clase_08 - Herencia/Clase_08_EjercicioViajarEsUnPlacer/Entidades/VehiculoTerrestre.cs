
using System;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        public enum Colores
        {
            Rojo,Blanco,Azul,Gris,Negro
        }
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
        public short CantidadRuedas
        {
            get 
            { 
                return this.cantidadRuedas; 
            }
            set 
            {
                this.cantidadRuedas = value; 
            }
        }
        public short CantidadPuertas
        {
            get
            {
                return this.cantidadPuertas;
            }
            set
            {
                this.cantidadPuertas = value;
            }
        }
        public Colores Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
    }
}
