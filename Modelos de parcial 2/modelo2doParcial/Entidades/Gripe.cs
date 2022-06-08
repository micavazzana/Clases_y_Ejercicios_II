namespace Entidades
{
    public class Gripe : Microrganismo
    {
        public Gripe(string nombre, Etipo tipo, Econtagiosidad contagiosidad)
            : base(nombre, tipo, contagiosidad)
        {
        }

        public override long IndiceDeContagios
        {
            get
            {
                return base.contador = base.contador * 2;
            }
        }
    }
}
