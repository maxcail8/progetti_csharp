using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbitazioniQuartieri
{
    public partial class FrmAbitazione : Form
    {
        public FrmAbitazione()
        {
            InitializeComponent();
        }

        private void FrmAbitazione_Load(object sender, EventArgs e)
        {
            txtIndirizzo.Text = "";
            txtMq.Text = "";
            nudVani.Value = 0;
        }

        public string Indirizzo
        {
            get { return txtIndirizzo.Text; }
        }

        public int NumeroVani
        {
            get { return Convert.ToInt32(nudVani.Value); }
        }

        public double Mq
        {
            get { return Convert.ToDouble(txtMq.Text); }
        }
    }
}
