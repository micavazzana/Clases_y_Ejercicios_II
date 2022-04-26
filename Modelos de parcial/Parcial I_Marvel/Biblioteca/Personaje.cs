using System;
using System.Text;
using System.Collections.Generic;
namespace Biblioteca
{
    public enum EHabilidades
    {
        Volar, SuperFuerza, Resistencia, Rayos, Energia, InteligenciaSuperior, Sigilo, Astucia
    }
    public enum EEquipamiento
    {
        Armadura, Escudo, Martillo, Arco, Transformacion, ArtesMarciales 
    }
    public abstract class Personaje
    {
        private List<EHabilidades> listaHabilidades;
        protected string nombre;

        private Personaje()
        {
            this.listaHabilidades = new List<EHabilidades>();
        }
        public Personaje(string nombre, List<EHabilidades> habilidades) : this()
        {
            this.nombre = nombre;
            this.listaHabilidades = habilidades;
        }

        private string ListaHabilidades
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach(EHabilidades habilidad in this.listaHabilidades)
                {
                    sb.AppendLine($"{habilidad}");
                }                   
                return sb.ToString();
            }
        }

        protected virtual string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public static bool operator ==(List<Personaje> listaPersonajes, Personaje personaje)
        {
            foreach (Personaje p in listaPersonajes)
            {
                if(p.Nombre == personaje.Nombre && p.GetType() == personaje.GetType())
                    return true;
            }
            return false;
        }
        public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
        {
            return !(listaPersonajes == personaje);
        }
        public static List<Personaje> operator +(List<Personaje> listaPersonajes, Personaje personaje)
        {
            if(listaPersonajes != personaje)
            {
                listaPersonajes.Add(personaje);
            }
            return listaPersonajes;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine("Habilidades:");
            sb.AppendLine(this.ListaHabilidades);
            return sb.ToString();
        }
    }
}
