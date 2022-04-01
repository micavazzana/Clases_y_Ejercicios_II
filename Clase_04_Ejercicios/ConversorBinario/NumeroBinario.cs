using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinario
{
    public class NumeroBinario
    {
        private string numero;
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        public string Numero
        {
            get { return this.numero; }
        }
        //sobrecargas suma, resta y comparacion
        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double suma = ((NumeroDecimal)numeroBinario).Numero + numeroDecimal.Numero;
            return Conversor.ConvertirDecimalABinario(suma);
        }
        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double suma = ((NumeroDecimal)numeroBinario).Numero - numeroDecimal.Numero;
            return Conversor.ConvertirDecimalABinario(suma);
        }
        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.numero == ((NumeroBinario)numeroDecimal).Numero;
        }
        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }
        //sobrecargas conversion
        public static implicit operator NumeroBinario(string numeroBinario)
        {
            return new NumeroBinario(numeroBinario);
        }
        public static explicit operator NumeroDecimal(NumeroBinario numeroDecimal)
        {
            return (NumeroDecimal)Conversor.ConvertirBinarioADecimal(numeroDecimal.Numero);
        }
        public static explicit operator string(NumeroBinario numeroBinario)
        {
            return numeroBinario.Numero;
        }
    }
}
