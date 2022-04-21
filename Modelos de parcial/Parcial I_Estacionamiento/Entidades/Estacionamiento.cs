using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisponible)
            :this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator String(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {e.nombre}");
            sb.AppendLine($"Espacio disponible: {e.espacioDisponible}");
            foreach (Vehiculo v in e.vehiculos)
            {
                sb.AppendLine($"{v}");
            }
            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            foreach(Vehiculo item in e.vehiculos)
            {
                if(item == v)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }
        public static Estacionamiento operator + (Estacionamiento e, Vehiculo v)
        {
            if(e!=v && e.espacioDisponible > e.vehiculos.Count)//validar lo de la patente
            {
                e.vehiculos.Add(v);
            }
            return e;
        }
        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            if (e == v)
            {
                e.vehiculos.Remove(v);
                return v.ImprimirTicket();
            }
            else
                return "El vehículo no es parte del estacionamiento";
        }
    }
}
