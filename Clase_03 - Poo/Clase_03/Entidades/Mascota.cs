using System;

namespace Entidades
{
    public class Mascota
    {
        public string nombre;
        public string raza;
        public int edad;
        public string especie;
        public bool hambre;


        public Mascota(string nombre, string especie, int edad)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.edad = edad;
        }

        public string Saludar()
        {
            return $"Hola mi nombre es {this.nombre} soy un {this.especie} y mi edad es {this.edad}";
        }

        public static void Alimentar(Mascota mascota)
        {
            if(!mascota.hambre)
            {
                mascota.hambre = true;
            }
        }
    }
}
