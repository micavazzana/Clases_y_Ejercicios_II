using System.Text;

namespace Entidades
{
    public class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;

        public Jugador(string nombre, string apellido, int numero, bool esCapitan)
            : base(nombre, apellido)
        {
            this.esCapitan = esCapitan;
            this.numero = numero;
        }
        public Jugador(string nombre, string apellido)
            : this(nombre, apellido, 0, false)
        {
        }
        public bool EsCapitan
        {
            get
            {
                return this.esCapitan;
            }
            set
            {
                this.esCapitan = value;
            }
        }
        public int Numero
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

        protected override string FichaTecnica()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.NombreCompleto());
            if (this.EsCapitan)
                sb.Append(", Capitan del equipo");
            sb.Append($", Camiseta numero: {this.Numero}");
            return sb.ToString();
        }
        //Dos Jugadores serán iguales si comparten nombre, apellido y camiseta.
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido && j1.Numero == j2.Numero;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        //Conversión explicita de Jugador a entero, retornando el número de camiseta.
        public static explicit operator int(Jugador jugador)
        {
            return jugador.Numero;
        }
        //Sobrecarga Equals y Tostring
        public override bool Equals(object obj)
        {
            Jugador j = obj as Jugador;
            return j is not null && this == j;
        }
        public override string ToString()
        {
            return this.FichaTecnica();
        }
    }
}
