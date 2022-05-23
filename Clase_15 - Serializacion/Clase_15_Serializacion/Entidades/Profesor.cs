namespace Entidades
{
    public class Profesor : Persona
    {
        private string legajo;
        public Profesor() : base()
        {

        }
        public Profesor(string nombre, int edad, string legajo) : base(nombre, edad)
        {
            this.legajo = legajo;
        }

        public string Legajo { get => this.legajo; set => this.legajo = value; }
    }
}
