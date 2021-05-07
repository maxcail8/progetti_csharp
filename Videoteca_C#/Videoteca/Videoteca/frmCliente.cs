using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteca
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        public string GetCognome
        {
            get
            {
                return txtCognome.Text.ToUpper();
            }
        }

        public string GetNome
        {
            get
            {
                return txtNome.Text.ToUpper();
            }
        }

        public DateTime GetDataNascita
        {
            get
            {
                return dtpNascita.Value;
            }
        }

        public int GetFilm
        {
            get
            {
                return (int)nudFilm.Value;
            }
        }

        private void txtCognome_TextChanged(object sender, EventArgs e)
        {
            if (txtCognome.Text.Trim() != "" && txtNome.Text != "")
                btnClient.Enabled = true;
            else
                btnClient.Enabled = false;
        }
    }
}
