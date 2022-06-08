using System.Threading;

namespace Entidades
{
    public delegate void AvanceInfectados(int dia, long infectados);
    public delegate void FinInfectation();
    public static class GrupoDePrueba<T>
        where T : Microrganismo
    {
        private static T enfermedad;
        private static long poblacion;

        public static long Poblacion
        {
            get
            {
                return GrupoDePrueba<T>.poblacion;
            }
            set
            {
                GrupoDePrueba<T>.poblacion = value;
            }
        }

        static GrupoDePrueba()
        {
            GrupoDePrueba<T>.poblacion = 10000000;
        }

        public static void InfectarPoblacion(object obj)
        {
            if (obj is T)
            {
                enfermedad = obj as T;
                int cantDias = 1;
                do
                {
                    if (InformeDeAvance is not null)
                    {
                        InformeDeAvance.Invoke(cantDias, enfermedad.IndiceDeContagios);
                        cantDias++;
                    }                        
                    Thread.Sleep(7500);
                }
                while (enfermedad.IndiceDeContagios <= poblacion);
                    if (FinalizaSimulacion is not null)
                    FinalizaSimulacion.Invoke();
                //FinalizaSimulacion?.Invoke();  CON EL SIGNO DE PREGUNTA CHEQUEA YA QUE NO SEA NULL
            }
        }
        public static event FinInfectation FinalizaSimulacion;
        public static event AvanceInfectados InformeDeAvance;
    }
}
