using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        private Estacionamiento(string nombre, int capacidadEstacionamiento)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidadEstacionamiento;
        }
        public List<Vehiculo> ListadoVehiculos
        {
            get
            {
                return this.listadoVehiculos;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
                return Estacionamiento.estacionamiento;
            }
            else
            {
                estacionamiento.capacidadEstacionamiento = capacidad;
                return Estacionamiento.estacionamiento;
            }
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre estacionamiento {this.Nombre}");
            sb.AppendLine(vehiculo.ToString());
            sb.AppendLine($"Hora de egreso: {vehiculo.HoraEgreso}");
            sb.AppendLine($"Cargo estacionamiento: {vehiculo.CostoEstadia}");
            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            foreach (Vehiculo vehiculo in e.ListadoVehiculos)
            {
                if (vehiculo == v)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }
        public static bool operator +(Estacionamiento e, Vehiculo v)
        {
            if(e != v && e.ListadoVehiculos.Count < e.capacidadEstacionamiento)
            {
                e.listadoVehiculos.Add(v);
                return true;
            }
            return false;
        }
        public static bool operator -(Estacionamiento e, Vehiculo v)
        {
            DateTime d = DateTime.Now;
            if(e == v)
            {
                v.HoraEgreso = d;
                e.listadoVehiculos.Remove(v);
                return true;
            }
            return false;
        }
    }
}
