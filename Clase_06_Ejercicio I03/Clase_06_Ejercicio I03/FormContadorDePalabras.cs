using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_06_Ejercicio_I03
{
    public partial class FormContadorDePalabras : Form
    {
        Dictionary<string, int> diccionario;

        public FormContadorDePalabras()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ContarPalabras(this.rchTxtBox1.Text);
            MessageBox.Show(MostrarTop3());// el TOP 3 de palabras con más apariciones.
        }
        public void ContarPalabras(string txtBox)
        {
            foreach (string palabra in txtBox.Split('\n'))
            {
                if (!diccionario.ContainsKey(palabra))
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario[palabra]++;  
                }
            }             
        }
        public string MostrarTop3()
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<string, int> item in diccionario)
            {
                if(diccionario.Values.Max())//el value es el mas grande
                {
                    sb.Append($"{item.Key} Aparece {item.Value}");
                }
            }
            return sb.ToString();
        }
    }
}
