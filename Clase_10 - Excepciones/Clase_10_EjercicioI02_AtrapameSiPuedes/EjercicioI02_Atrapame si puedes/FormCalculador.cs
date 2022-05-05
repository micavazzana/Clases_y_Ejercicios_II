using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace EjercicioI02_Atrapame_si_puedes
{
    public partial class FormCalculador : Form
    {
        public FormCalculador()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            try
            {
                this.ValidarTextBox(this.txtKm.Text, this.txtLts.Text);
                num1 = int.Parse(this.txtKm.Text);
                num2 = int.Parse(this.txtLts.Text);
                this.rtbResultado.Text = String.Format($"{num1} / {num2} = {Calculador.Calcular(num1, num2).ToString()}");
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Mal Argumentos");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese numeros");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Desbordó");
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("Algo no funcionó");
            }
        }

        /// <summary>
        /// Valida que lo que se ingrese en el textBox no este vacio
        /// </summary>
        /// <param name="txt1">textBox 1</param>
        /// <param name="txt2">textBox 2</param>
        /// <exception cref="ParametrosVaciosException">Tira una excepcion si los textBox estan vacios</exception>
        private void ValidarTextBox(string txt1, string txt2)
        {
            if (string.IsNullOrWhiteSpace(txt1) || string.IsNullOrWhiteSpace(txt2))
            {
                throw new ParametrosVaciosException("Los text box no pueden estar vacios");
            }
        }
    }
}
