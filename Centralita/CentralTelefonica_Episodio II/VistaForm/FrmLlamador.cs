﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _Centralita;

namespace VistaForm
{
    public partial class FrmLlamador : Form
    {
        private Centralita central;
        public FrmLlamador()
        {
            InitializeComponent();
        }

        public FrmLlamador(Centralita c) : this()
        {
            this.central = c;
        }

        public Centralita Central
        {
            get { return this.central; }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "#";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random duracion = new Random();
            Random costoRandom = new Random();
            float costo = costoRandom.Next(5, 56) / 10;
            Provincial llamadaProv;
            Local llamadaLocal;
            if(!String.IsNullOrEmpty(txtNroDestino.Text) && !String.IsNullOrEmpty(txtNroOrigen.Text))
            {
                if(txtNroDestino.Text[0] == '#')
                {
                    llamadaProv = new Provincial(this.txtNroOrigen.Text,(Provincial.Franja)cmbFranja.SelectedItem, duracion.Next(1,50), this.txtNroDestino.Text);
                    central += llamadaProv;
                }
                else
                {
                    llamadaLocal = new Local(this.txtNroOrigen.Text, duracion.Next(1, 50), this.txtNroDestino.Text, costo);
                    central += llamadaLocal;
                }
            }
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNroDestino.Text.StartsWith("#"))
            {
                cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
            }
            else
            {
                this.cmbFranja.Enabled = false;
            }
            if(this.txtNroDestino.Text.Length == 11)
            {
                this.gBoxPanel.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = String.Empty;
            this.txtNroOrigen.Text = String.Empty;
            this.cmbFranja.Text = String.Empty;
            this.cmbFranja.Enabled = true;
            this.gBoxPanel.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
