using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormsApp
{
    public partial class FrmSimulador : Form
    {
        Task hilo;
        Microrganismo m;

        public FrmSimulador()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            m = new Covid19("covid");//cmbMicrorganismo
            Evaluar<Microrganismo>(m);

        }
        private void Evaluar<T>(T enfermedad)
            where T : class
        {
            hilo = new Task(() =>
            { GrupoDePrueba<Microrganismo>.InfectarPoblacion(enfermedad); });
            hilo.Start();
           
        }
        private void Final()
        {
            if (this.InvokeRequired)
            {
                Action delegado = Final;
                this.Invoke(delegado);
            }
            else
            {
                this.rtbEvolucion.Text = $"Toda la poblacion fue infectada";
            }
        }
        private void Informe(int dia, long infectados)
        {
            if (this.InvokeRequired)
            {
                Action<int, long> delegado = Informe;
                this.Invoke(delegado, new object[] { dia, infectados});
                //this.BeginInvoke(new AvanceInfectados,new object[] {dia, infectados});
            }
            else
            {
                this.rtbEvolucion.Text = $"{dia}{infectados}" ;
            }
        }

        private void FrmSimulador_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmSimulador_Load(object sender, EventArgs e)
        {
            GrupoDePrueba<Microrganismo>.InformeDeAvance += Informe;
            //GrupoDePrueba<Microrganismo>.FinInfectation += Final;
        }
    }
}
