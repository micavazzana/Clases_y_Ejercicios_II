using System;

namespace BiblioClases
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            return false;
            //return valor > min && valor < max;
        }

        public static bool ValidarRespuesta(string respuesta)
        {
            if(respuesta == "S")
            {
                return true;
            }
            return false;
            //return respuesta == "s" || respuesta == "S";
        }
    }
}
