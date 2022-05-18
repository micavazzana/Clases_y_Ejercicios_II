using System.Collections.Generic;
using System.Windows.Forms;

namespace Repaso_ExcepcionesII
{
    public partial class FrmErrores : Form
    {
        public FrmErrores()
        {
            InitializeComponent();
        }

        public FrmErrores(List<string> listadoErrores) : this()
        {
            foreach (string error in listadoErrores)
            {
                this.listErrores.Items.Add(error);
            }
        }
    }
}
