using System;

namespace Biblioteca
{
    public class Animal
    {
        string nombre;
        int edad;
        public int id;

        public Animal(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public virtual string EmitirSonido() 
            //el virtual lo agrego para decirle que quiero reimplementarlo o redefinirlo en las clases que lo heredan
        {
            return "Roar";
        }

        public static bool operator ==(Animal a1, Animal a2)
        {
            return a1 is not null 
                && a2 is not null 
                && a1.nombre == a2.nombre 
                && a1.edad == a2.edad;
        }
        public static bool operator !=(Animal a1, Animal a2)
        {
            return !(a1 == a2);
        }
        public override bool Equals(object obj)
        {
            return this == (Animal)obj;
        }
        public override int GetHashCode()
        {
           return (int)this.nombre.GetHashCode();
        }
    }
}
