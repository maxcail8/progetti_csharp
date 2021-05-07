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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNumeroPersone.Text = $"Numero persone: {lbxPersone.Items.Count}";
        }

        private void btnCreaPersona_Click(object sender, EventArgs e)
        {
            Persona nuovaPersona = FrmPersona.CreaPersona();
            if(nuovaPersona != null)
                lbxPersone.Items.Add(nuovaPersona.ToString());
        }
    }
}
