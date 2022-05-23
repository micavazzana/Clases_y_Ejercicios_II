using Entidades;
using System;
using System.Windows.Forms;

namespace EjercicioI03_SiempreQuiseUnNotepad
{
    public partial class Notepad : Form
    {
        GestorDeArchivos gestor;
        OpenFileDialog ofd;
        SaveFileDialog save;

        public Notepad()
        {
            InitializeComponent();
            gestor = new GestorDeArchivos();
            ofd = new OpenFileDialog();
            save = new SaveFileDialog();
            save.Filter = "Archivo de texto|.txt";
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            this.rtbTexto_TextChanged(sender, e);
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.rtbTexto.Text))
            {
                this.ssLblTexto.Text = $"{this.rtbTexto.Text.Length} caracteres";
            }
            else
            {
                this.ssLblTexto.Text = $"0 caracteres";
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    this.rtbTexto.Text = this.gestor.Leer(ofd.FileName);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(ofd.FileName))
                    this.gestor.Escribir(ofd.FileName, this.rtbTexto.Text, true);
                else
                    guardarComoToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    this.gestor.Escribir(save.FileName, this.rtbTexto.Text, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }
    }
}
