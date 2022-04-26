using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appInstaladas;
        private static SistemaOperativo sistemaOperativo;
        
        static Dispositivo()
        {
            Dispositivo.appInstaladas = new List<Aplicacion>();
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if(app.SistemaOperativo == SistemaOperativo.ANDROID && appInstaladas != app)
            {
                appInstaladas.Add(app);
                return true;
            }
            return false;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistema operativo: {Dispositivo.sistemaOperativo}");
            foreach (Aplicacion app in appInstaladas)
            {
                sb.AppendLine(app.ObtenerInformacionApp());
            }
            return sb.ToString();
        }
    }
}
