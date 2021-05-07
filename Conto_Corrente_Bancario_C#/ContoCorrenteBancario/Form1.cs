using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContoCorrenteBancario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ContoCorrente conto;

        private void btnCrea_Click(object sender, EventArgs e)
        {
            if(txtSaldo.Text != "")
            {
                try
                {
                    conto = new ContoCorrente(Convert.ToInt32(txtNumC.Text), Convert.ToInt32(txtSaldo.Text));
                    pnlM.Visible = true;
                }
                catch
                {
                    throw new ArgumentException("Parametri non corretti");
                }
            }
            else
            {
                try
                {
                    conto = new ContoCorrente(Convert.ToInt32(txtNumC.Text));
                    pnlM.Visible = true;
                }
                catch
                {
                    throw new ArgumentException("Parametri non corretti");
                }
            }
            txtSaldoA.Text = Convert.ToString(conto.Saldo);
        }

        private void btnPrelievo_Click(object sender, EventArgs e)
        {
            try
            {
                conto.Prelievo(Convert.ToInt32(txtPrelievo.Text));
                txtSaldoA.Text = Convert.ToString(conto.Saldo);
            }
            catch
            {
                throw new ArgumentException("Parametri non corretti");
            }
            txtPrelievo.Text = "";
        }

        private void btnVersamento_Click(object sender, EventArgs e)
        {
            try
            {
                conto.Versamento(Convert.ToInt32(txtVersamento.Text));
                txtSaldoA.Text = Convert.ToString(conto.Saldo);
            }
            catch
            {
                throw new ArgumentException("Parametri non corretti");
            }
            txtVersamento.Text = "";
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conto.GetListaMovimenti(), "Lista movimenti");
        }

        private void btnMovR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conto.GetDataRecente(), "Movimento piu' recente");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumC.TextAlign = HorizontalAlignment.Center;
            txtSaldo.TextAlign = HorizontalAlignment.Center;
            txtPrelievo.TextAlign = HorizontalAlignment.Center;
            txtVersamento.TextAlign = HorizontalAlignment.Center;
            txtSaldoA.TextAlign = HorizontalAlignment.Center;
        }
    }
}
