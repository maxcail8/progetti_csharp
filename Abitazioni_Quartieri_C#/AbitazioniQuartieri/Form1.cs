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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Quartiere q1, q2;
        Abitazione a;
        FrmAbitazione formA = new FrmAbitazione();

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlQuartieri.Visible = false;
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            q1 = new Quartiere();
            q2 = new Quartiere();
            MessageBox.Show("Quartieri creati correttamente");
            pnlQuartieri.Visible = true;
        }

        private void btnAggiungi1_Click(object sender, EventArgs e)
        {
            if(formA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (rdbLusso.Checked)
                        a = new AbitazioneLusso(formA.Indirizzo, formA.NumeroVani, formA.Mq);
                    else if(rdbPopolare.Checked)
                        a = new AbitazionePopolare(formA.Indirizzo, formA.NumeroVani, formA.Mq);
                    if (q1.AggiungiAbitazione(a))
                        lbxQuartiere1.Items.Add(a);
                    else
                        MessageBox.Show("Abitazione gia presente nel quartiere", "Esistenza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Parametri errati", "Eccezzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAggiungi2_Click(object sender, EventArgs e)
        {
            if (formA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (rdbLusso.Checked)
                        a = new AbitazioneLusso(formA.Indirizzo, formA.NumeroVani, formA.Mq);
                    else if (rdbPopolare.Checked)
                        a = new AbitazionePopolare(formA.Indirizzo, formA.NumeroVani, formA.Mq);
                    if(q2.AggiungiAbitazione(a))
                        lbxQuartiere2.Items.Add(a);
                    else
                        MessageBox.Show("Abitazione gia presente nel quartiere", "Esistenza");
                }
                catch
                {
                    MessageBox.Show("Parametri errati", "Eccezzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rdbLusso_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLusso.Checked)
                rdbPopolare.Checked = false;
            if (rdbPopolare.Checked)
                rdbLusso.Checked = false;
        }

        private void btnCalcolaAbitazioniDiLusso_Click(object sender, EventArgs e)
        {
            int lusso1, lusso2;
            lusso1 = q1.AbitazioniDiLusso();
            lusso2 = q2.AbitazioniDiLusso();
            if (lusso1 > lusso2)
                txtAbitazioniDiLusso.Text = $"Quartiere1: {lusso1}";
            else if(lusso2 > lusso1)
                txtAbitazioniDiLusso.Text = $"Quartiere2: {lusso2}";
            else
                txtAbitazioniDiLusso.Text = $"Ugali: {lusso1}";
        }

        private void btnCalcolaImposte_Click(object sender, EventArgs e)
        {
            double imposte1 , imposte2;
            imposte1 = q1.ImposteTotali();
            imposte2 = q2.ImposteTotali();
            txtImposte1.Text = imposte1.ToString();
            txtImposte2.Text = imposte2.ToString();
        }
    }
}
