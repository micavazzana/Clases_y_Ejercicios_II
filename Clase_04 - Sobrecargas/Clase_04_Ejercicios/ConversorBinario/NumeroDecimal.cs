using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinario
{
    public class NumeroDecimal
    {
        private double numero;
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        public double Numero
        {
            get { return numero; }
        }
        //sobrecargas suma, resta y comparacion
        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.Numero + ((NumeroDecimal)numeroBinario).Numero;
        }
        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.Numero - ((NumeroDecimal)numeroBinario).Numero;
        }
        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero == ((NumeroDecimal)numeroBinario).Numero;
        }
        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }

        //sobrecargas conversion
        public static implicit operator NumeroDecimal(double numeroDecimal)
        {
            return new NumeroDecimal(numeroDecimal);
        }
        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)Conversor.ConvertirDecimalABinario(numeroDecimal.Numero);
        }
        public static explicit operator double(NumeroDecimal numeroBinario)
        {
            return numeroBinario.Numero;
        }
    }
}
