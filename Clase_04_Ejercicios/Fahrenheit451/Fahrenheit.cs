using System;

namespace Fahrenheit451
{
    public class Fahrenheit
    {
        private double gradosFahrenheit;

        public Fahrenheit(double grados)
        {
            this.gradosFahrenheit = grados;
        }
        public double GetGrados()
        {
            return this.gradosFahrenheit;
        }

        //Sobrecargas operadores explicit/implicit
        public static explicit operator Kelvin(Fahrenheit grados)
        {
            return new Kelvin((grados.GetGrados() + 459.67) * 5 / 9);
        }
        public static explicit operator Celsius(Fahrenheit grados)
        {
            return new Celsius((grados.GetGrados() - 32) * 5 / 9);
        }
        public static implicit operator Fahrenheit(double grados)
        {
            return new Fahrenheit(grados);
        }
    }
}
