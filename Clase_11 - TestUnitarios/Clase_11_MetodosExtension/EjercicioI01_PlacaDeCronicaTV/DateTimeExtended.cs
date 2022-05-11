using System;

namespace EjercicioI01_PlacaDeCronicaTV
{
    public enum Estaciones
    {
        Verano, Primavera, Invierno, Otonio
    }
    public static class DateTimeExtended 
    {
        public static string ObtenerPlacaCronicaTV(this Estaciones estacion)
        {
            DateTime fechaActual = DateTime.Now;
            
            DateTime inicioOtonio = new DateTime(2022, 03, 21);
            DateTime inicioInvierno = new DateTime(2022, 06, 21);
            DateTime inicioPrimavera = new DateTime(2022, 09, 21);
            DateTime inicioVerano = new DateTime(2022, 12, 21);

            switch (estacion)
            {
                case Estaciones.Otonio:
                    return $"Faltan {(fechaActual.DayOfYear - inicioOtonio.DayOfYear).ToString()} dias para el Otoño";
                case Estaciones.Invierno:
                    return $"Faltan {(fechaActual.DayOfYear - inicioInvierno.DayOfYear).ToString()} dias para el Invierno";
                case Estaciones.Primavera:
                    return $"Faltan {(fechaActual.DayOfYear - inicioPrimavera.DayOfYear).ToString()} dias para la Primavera";
                case Estaciones.Verano:
                    return $"Faltan {(fechaActual.DayOfYear - inicioVerano.DayOfYear).ToString()} dias para el Verano";
                default:
                    return "";
            }            
        }
    }
}
