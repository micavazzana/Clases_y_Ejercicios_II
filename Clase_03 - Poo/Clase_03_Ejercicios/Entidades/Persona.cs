using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, string fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }
        public void SetFechaDeNacimiento(string fecha)
        {
            this.fechaDeNacimiento = fecha;
        }
        public int GetDni()
        {
            return this.dni;
        }
        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        private static int CalcularEdad(Persona p)
        {
            DateTime añoEnCurso = DateTime.Now;
            DateTime fechaNacimiento = DateTime.Parse(p.GetFechaDeNacimiento());
            return añoEnCurso.Year - fechaNacimiento.Year;
        }
        public static string Mostrar(Persona p)
        {
            return $"Nombre: {p.GetNombre()} Fecha de Nacimiento: {p.GetFechaDeNacimiento()} Dni: {p.dni} Edad: {CalcularEdad(p)}";
        }
        public static string EsMayorDeEdad(Persona p)
        {
            if(CalcularEdad(p) >= 18)
            {
                return "Es mayor de edad";
            }
            return "Es menor de edad";
        }
    }
}
