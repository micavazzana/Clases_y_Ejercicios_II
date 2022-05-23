using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace listaSuper
{
    public partial class FrmListaSuper : Form
    {
        FrmAltaModificacion frm;
        List<string> listaSupermercado;
        ToolTip toolTipAdd;
        ToolTip toolTipRemove;
        ToolTip toolTipModificar;
        private static string rutaArchivo;

        static FrmListaSuper()
        {
            DirectoryInfo info = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\ArchivoEjercicioListaSuper\\");
            rutaArchivo = Path.Combine(info.FullName, "listaSupermercado.xml");
        }

        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
            toolTipAdd = new ToolTip();
            toolTipRemove = new ToolTip();
            toolTipModificar = new ToolTip();
            toolTipAdd.SetToolTip(btnAgregar, "Agregar objeto");
            toolTipRemove.SetToolTip(btnQuitar, "Eliminar objeto");
            toolTipModificar.SetToolTip(btnModificar, "Modificar objeto");
        }

        /// <summary>
        /// Agregar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frm = new FrmAltaModificacion("Agregar Objeto", "", "Agregar");
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frm.Objeto);
                SerializarStreamWriter();
                ActualizarLista();
            }
        }
        /// <summary>
        /// Quitar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (this.lstObjetos.SelectedItem is not null)
            {
                listaSupermercado.Remove($"{this.lstObjetos.SelectedItem}");
                SerializarStreamWriter();
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar algo");
            }
        }
        /// <summary>
        /// Modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstObjetos.SelectedItem is not null)
            {
                frm = new FrmAltaModificacion("Modificar Objeto", $"{this.lstObjetos.SelectedItem}", "Modificar");
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    listaSupermercado.Remove($"{this.lstObjetos.SelectedItem}");
                    listaSupermercado.Add(frm.Objeto);
                    SerializarStreamWriter();
                    ActualizarLista();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algo");
            }
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            DeserializarStreamReader();
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }



        //METODOS SERIALIZAR
        public void DeserializarStreamReader()
        {
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    try
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(List<string>));
                        listaSupermercado = xml.Deserialize(sr) as List<string>;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"ERROR: {ex.Message}\nSTACKTRACE:\n{ex.StackTrace}");
                    }
                }
            }
        }
        public void SerializarStreamWriter()
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<string>));
                    xml.Serialize(sw, listaSupermercado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}\nSTACKTRACE:\n{ex.StackTrace}");
                }
            }
        }
    }
}
