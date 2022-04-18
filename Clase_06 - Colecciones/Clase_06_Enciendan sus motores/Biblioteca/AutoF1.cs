using System;
using System.Text;

namespace Biblioteca
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;
        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            :this(numero, escuderia)
        { 
            this.caballosDeFuerza = caballosDeFuerza;
        }
        public short CaballosDeFuerza
        {
            get 
            { 
                return this.caballosDeFuerza; 
            }
            set 
            { 
                this.caballosDeFuerza = value; 
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.CaballosDeFuerza}");
            return sb.ToString();
        }
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {

            return auto1.Numero == auto2.Numero && auto1.Escuderia == auto2.Escuderia && auto1.CaballosDeFuerza == auto2.CaballosDeFuerza;
        }
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
    }
}
