using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;
        static FrmCartelera()
        {
            rutaConfiguracion = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\configuracion.json";
        }

        public FrmCartelera()
        {
            InitializeComponent();
        }
        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }
        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }
        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            this.pnlCartel.BackColor = ColorElegido(pnlCartel.BackColor);
        }
        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            this.lblTitulo.ForeColor = ColorElegido(this.lblTitulo.ForeColor);
        }
        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            this.lblMensaje.ForeColor = ColorElegido(this.lblMensaje.ForeColor);
        }
        private Color ColorElegido(Color colorActual)
        {
            this.colorDialog.Color = colorActual;
            this.colorDialog.ShowDialog();
            return colorDialog.Color;
        }
        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            Configurar(rutaConfiguracion);
        }
        private void Configurar(string ruta)
        {
            if (File.Exists(ruta))
            {
                try
                {
                    Cartel cartel = DeserializarJson(ruta);

                    pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                    txtTitulo.Text = cartel.Titulo.Contenido;
                    lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                    rtxtMensaje.Text = cartel.Mensaje.Contenido;
                    lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
                }
                catch (JsonException)
                {
                    MessageBox.Show("El archivo de configuracion no se encuentra en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
            Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
            Cartel cartel = new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje);
            try
            {
                SerializarJson(cartel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Json files(*.json)|*.json";
            ofd.ShowDialog();
            Configurar(ofd.FileName);
        }
        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Seguro de que desea eliminar la configuración?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(rutaConfiguracion))
                        File.Delete(rutaConfiguracion);

                    txtTitulo.Text = "Título";
                    lblTitulo.ForeColor = Control.DefaultForeColor;

                    rtxtMensaje.Text = "Mensaje";
                    lblMensaje.ForeColor = Control.DefaultForeColor;

                    pnlCartel.BackColor = Control.DefaultBackColor;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //METODOS SERIALIZAR Y DESERIALIZAR
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cartel"></param>
        /// <exception cref="Exception"></exception>
        private void SerializarJson(Cartel cartel)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaConfiguracion))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    string ser = JsonSerializer.Serialize(cartel);
                    sw.WriteLine(ser);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="Exception"></exception>
        private Cartel DeserializarJson(string ruta)
        {
            try
            {
                using(StreamReader sr = new StreamReader(ruta))
                {
                    string json = sr.ReadToEnd();
                    return JsonSerializer.Deserialize<Cartel>(json);
                }
            }
            catch(JsonException ex)
            {
                throw new JsonException(ex.Message);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }
}
