using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class FrmCarrera : Form
    {
        private Carrera carrera;
    
        private AutoF1 v1;
        private AutoF1 v2;
        public FrmCarrera()
        {
            InitializeComponent();
            this.pcbAutoUno.Image = this.imgListAutos.Images[0];
            this.pcbAutoDos.Image = this.imgListAutos.Images[0];
        }

        private void FrmCarrera_Load(object sender, EventArgs e)
        {
            this.InitializeAutosYCarrera();
            this.carrera.InformarAvance += AvanzarAuto;
            this.carrera.InformarLlegada += ImprimirMensaje;
        }
        private void FrmCarrera_Shown(object sender, EventArgs e)
        {
            //Instancia e inicializa Hilo secundario
            Task task = Task.Run(carrera.IniciarCarrera);
        }
        private void AvanzarAuto()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(AvanzarAuto));
                //Action avance = AvanzarAuto;
                //this.Invoke(avance);
                //this.Invoke(new InformacionDeAvance(AvanzarAuto));
            }
            else
            {
                this.pcbAutoUno.Location = new Point(this.v1.UbicacionEnPista, this.pcbAutoUno.Location.Y);
                this.pcbAutoDos.Location = new Point(this.v2.UbicacionEnPista, this.pcbAutoDos.Location.Y);
            }
        }
        private void InitializeAutosYCarrera()
        {
            Random random = new Random();
            this.v1 = new AutoF1("Ferrari", random.Next(5, 20), this.pcbAutoUno.Location.X);
            Thread.Sleep(2000);//pongo un sleep para el random
            this.v2 = new AutoF1("Renault", random.Next(5, 20), this.pcbAutoDos.Location.X);
            this.carrera = new Carrera(this.Size.Width); //instancion la carrera y le envio el maximo del form

            //Agrego vehiculos a la carrera
            this.carrera += v1;
            this.carrera += v2;
        }
        private void ImprimirMensaje(string mensaje)
        {
            //Metodo que maneja el evento InformarLlegada
            //Informar la llegada con un MessageBox
            MessageBox.Show($"{mensaje}");
        }
    }
}
