using System.Collections.Generic;

namespace Entidades
{
    public class CartucheraMultiuso
    {
        private List<IAcciones> lista;

        public CartucheraMultiuso()
        {
            this.lista = new List<IAcciones>();
        }
        
        public void Aniadir(IAcciones a)
        {
            this.lista.Add(a);
        }

        public bool RecorrerElementos()
        {
            bool retorno = false;

            foreach (IAcciones item in lista)
            {
                if (((IAcciones)item).UnidadesDeEscritura > 1)
                {
                    item.Escribir("*");
                    retorno = true;
                }
                else
                {
                    item.Recargar(20);
                    retorno = false;
                }
            }
            return retorno;
        }
    }
}
