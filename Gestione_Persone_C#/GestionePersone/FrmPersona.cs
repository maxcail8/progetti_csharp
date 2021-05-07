using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionePersone
{
    public partial class FrmPersona : Form
    {
        private FrmPersona() //rendo privato il costruttore in modo da poter creare solamente 1 istanza della classe, infatti non si può richiamare new nella Form1
        {
            InitializeComponent();
        }

        static FrmPersona finestra = new FrmPersona();

        private void FrmPersona_Load(object sender, EventArgs e)
        {
           Azzera();
        }

        public void Azzera()
        {
            txtCognome.Text = "";
            txtNome.Text = "";
        }

        public static Persona CreaPersona()
        {
            Persona p = null;
            if(finestra.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    p = new Persona(finestra.txtNome.Text.Trim(), finestra.txtCognome.Text.Trim(), finestra.dtpData.Value );
                }
                catch
                {
                    MessageBox.Show("Impossibile creare la persona", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return p;
        }
    }
}
