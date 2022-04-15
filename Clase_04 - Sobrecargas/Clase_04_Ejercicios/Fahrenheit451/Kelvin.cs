using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit451
{
    public class Kelvin
    {
        private double gradosKelvin;

        public Kelvin(double grados)
        {
            this.gradosKelvin = grados;
        }
        public double GetGrados()
        {
            return this.gradosKelvin;
        }

        //Sobrecargas operadores explicit/implicit
        public static explicit operator Celsius(Kelvin grados)
        {
            return new Celsius((((Fahrenheit)grados).GetGrados()-32)*5/9);
        }
        public static explicit operator Fahrenheit(Kelvin grados)
        {
            return new Fahrenheit(grados.GetGrados() * 9 / 5 - 459.67);
        }
        public static implicit operator Kelvin(double grados)
        {
            return new Kelvin(grados);
        }


    }
}
