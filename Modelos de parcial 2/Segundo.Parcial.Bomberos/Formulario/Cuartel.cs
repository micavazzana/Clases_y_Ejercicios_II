using Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Cuartel2 : Form
    {
        private List<Bombero> bomberos;
        private List<PictureBox> fuegos;
        CancellationTokenSource cancelacion;
        public Cuartel2()
        {
            InitializeComponent();

            fuegos = new List<PictureBox>();
            fuegos.Add(fuego1);
            fuegos.Add(fuego2);
            fuegos.Add(fuego3);
            fuegos.Add(fuego4);
            cancelacion = new CancellationTokenSource();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            bomberos = new List<Bombero>();
            Bombero b1 = new Bombero("M. Palermo");
            b1.MarcarFin += OcultarBombero;
            bomberos.Add(b1);
            Bombero b2 = new Bombero("G. Schelotto");
            b2.MarcarFin += OcultarBombero;
            bomberos.Add(b2);
            Bombero b3 = new Bombero("C. Tevez");
            b3.MarcarFin += OcultarBombero;
            bomberos.Add(b3);
            Bombero b4 = new Bombero("F. Gago");
            b4.MarcarFin += OcultarBombero;
            bomberos.Add(b4);
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(0);
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }

        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(1);
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(2);
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(3);
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void DespacharServicio(int index)
        {
            try
            {
                VerificarSalidaBombero(index);
                fuegos[index].Visible = true;
                Bombero bombero = bomberos[index];
                Task.Run(() =>
                {
                    bombero.AtenderSalida(index);
                }, cancelacion.Token);
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }
        private void VerificarSalidaBombero(int index)
        {
            foreach (Salida s in bomberos[index].Salidas)
            {
                if (s.FechaFin == default)
                {
                    throw new BomberoOcupadoException();
                }
            }
        }

        private void OcultarBombero(int bomberoIndex)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<int>(OcultarBombero), new object[] { bomberoIndex });
            }
            else
            {
                fuegos[bomberoIndex].Visible = false;
            }
        }

        private void Cuartel2_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancelacion.Cancel();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            try
            {
                Serializadora<Bombero>.SerializarXml("reporte1.xml", bomberos[1]);
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            try
            {
                Serializadora<Bombero>.SerializarXml("reporte2.xml", bomberos[2]);
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            try
            {
                Serializadora<Bombero>.SerializarXml("reporte3.xml", bomberos[3]);
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            try
            {
                Serializadora<Bombero>.SerializarXml("reporte4.xml", bomberos[4]);
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        void MostrarMensajeError(Exception ex)
        {
            MessageBox.Show($"{ex.Message}\n{ex.InnerException}");
        }
    }
}
