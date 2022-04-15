using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        private float CalcularPromedio()
        {
            return (float)(this.notaPrimerParcial + this.notaSegundoParcial)/2;
        }
        public double CalcularNotaFinal()
        {
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >=4)
            {
                return random.Next(6, 10);
            }
            return -1;            
        }
        public static string Mostrar(Estudiante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {e.nombre} Apellido: {e.apellido} Legajo: {e.legajo}");
            sb.AppendLine($"Nota primer parcial : {e.notaPrimerParcial} \n Nota Segundo Parcial: {e.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {e.CalcularPromedio()}");
            if (e.CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota final: {e.CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb.ToString();
        }


    }
}
