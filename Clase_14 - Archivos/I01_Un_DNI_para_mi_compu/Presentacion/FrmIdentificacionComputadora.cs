using System.Windows.Forms;
using System.IO;
using System;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text = $"Compu de {Environment.UserName}";
            ConfigurarLogoSistemaOperativo();
            this.lblSistemaOperativo.Text = $"Sistema operativo: {Environment.OSVersion}";
            this.lblNombreMaquina.Text = $"Nombre máquina: {Environment.MachineName}";
            this.lblArquitectura.Text = ConfigurarArquitectura();
            this.lblCantProcesadores.Text = $"Cant. procesadores: {Environment.ProcessorCount}";
            this.lblDirectorioActual.Text = $"Identificación ejecutada en: {Environment.NewLine}{Environment.CurrentDirectory}";
            ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if (OperatingSystem.IsWindows())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.win10;
            }
            else if (OperatingSystem.IsLinux())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
            else if (OperatingSystem.IsMacOS())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
        }

        private string ConfigurarArquitectura()
        {
            if(Environment.Is64BitOperatingSystem)
            {
                return $"Arquitectura: 64 bits";
            }
            else
            {
                return $"Arquitectura: 32 bits";
            }
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            long totalSize = 0;
            long avaibleSpace = 0;
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                totalSize += drive.TotalSize;//me lo devuelve en bytes
                avaibleSpace += drive.AvailableFreeSpace;
            }
            this.lblEspacioTotal.Text = $"Espacio total: {Math.Round(totalSize * 9.31e-10)} Gigabytes";
            this.lblEspacioDisponible.Text = $"Espacio disponible: {Math.Round(avaibleSpace * 9.31e-10)} Gigabytes";
        }
    }
}
