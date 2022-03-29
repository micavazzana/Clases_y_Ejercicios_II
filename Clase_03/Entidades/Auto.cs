using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string patente;
        private string marca;
        private string modelo;
        private int cantidadHoras;
        private static float precioHora;

        static Auto()
        {
            Auto.precioHora = 100;
        }

        public Auto(string patente, string marca, string modelo)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
        }

        public int GetCantidadHoras()
        {
            return this.cantidadHoras;
        }

        public void SetCantidadHoras(int value)
        {
            if (value > 1)
            {
                this.cantidadHoras = value;
            }
        }

        public string GetPatente()
        {
            return this.patente;
        }

        public void SetPatente(string value)
        {
            if(!string.IsNullOrEmpty(value))
            {
                this.patente = value;
            }
        }

        public string GetModelo()
        {
            return this.modelo;
        }

        public void SetModelo(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.modelo = value;
            }
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public void SetMarca(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.marca = value;
            }
        }

        public float CalcularCostoEstadia()
        {
            return this.cantidadHoras * Auto.precioHora;
        }

        public static float GetPrecioHora()
        {
            return Auto.precioHora;
        }

        public static void SetPrecioHora(float value)
        {
            Auto.precioHora = value;
        }
    }
}
