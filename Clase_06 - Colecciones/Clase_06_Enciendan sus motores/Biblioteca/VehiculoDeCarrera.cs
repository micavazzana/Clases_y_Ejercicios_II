using System.Text;

namespace Biblioteca
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool esCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.cantidadCombustible = 0;
            this.esCompetencia = false;
            this.vueltasRestantes = 0;
        }
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EsCompetencia
        {
            get
            {
                return this.esCompetencia;
            }
            set
            {
                this.esCompetencia = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public string Escuderia
        {
            get 
            { 
                return this.escuderia; 
            }
            set 
            { 
                this.escuderia = value; 
            }
        }
        public short Numero
        {
            get 
            { 
                return this.numero; 
            }
            set 
            { 
                this.numero = value; 
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuderia: {this.Escuderia}");
            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Es competencia: {this.EsCompetencia}");
            sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");
            return sb.ToString();
        }
        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia;
        }
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
