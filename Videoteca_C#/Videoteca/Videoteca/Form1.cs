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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Videoteca vid = null;
        Cliente c = null;
        int num;

        private void btnNuovaVideoteca_Click(object sender, EventArgs e)
        {
            vid = new Videoteca();
            MessageBox.Show("Nuova videoteca creata correttamente");
            //pulisco la listbox
            lbxVideoteca.Items.Clear();
            pnlVideoteca.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Azzera();
                frmCliente finestra = new frmCliente();
                if (finestra.ShowDialog() == DialogResult.OK)
                {
                    if (finestra.GetFilm == 0)
                        c = new Cliente(finestra.GetCognome, finestra.GetNome, finestra.GetDataNascita);
                    else
                        c = new Cliente(finestra.GetCognome, finestra.GetNome, finestra.GetDataNascita, finestra.GetFilm);
                    if (vid.AggiungiCliente(c))
                    {
                        lbxVideoteca.Items.Add(c);
                        num++;
                    }
                    else
                        MessageBox.Show("Cliente già presente nella videoteca");
                }
                tslNumeroClienti.Text = "Numero clienti: " + num;
            }
            catch(Exception err)
            {
                MessageBox.Show("Eccezzione: " + err.Message);
            }
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vid.OrdinaPerNumeroFilm(), "La lista ordinata");
        }

        private void btnNumeroFilm_Click(object sender, EventArgs e)
        {
            pnlRicerca.Visible = true;
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vid[(int)nudNumeroFilm.Value], "Ricerca per numero film\n");
            Azzera();
        }

        private void lbxVideoteca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxVideoteca.SelectedIndex > -1)
                pnlCliente.Visible = true;
            else
                pnlCliente.Visible = false;
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            Azzera();
            Cliente temp = (Cliente)lbxVideoteca.Items[lbxVideoteca.SelectedIndex];
            if (vid.RimuoviCliente(temp))
            {
                lbxVideoteca.Items.RemoveAt(lbxVideoteca.SelectedIndex);
                MessageBox.Show("Cliente rimosso dalla videoteca");
                num--;
                tslNumeroClienti.Text = "Numero clienti: " + num;
            }
        }

        private void btnVisualizzaPass_Click(object sender, EventArgs e)
        {
            Cliente temp = (Cliente)lbxVideoteca.Items[lbxVideoteca.SelectedIndex];
            MessageBox.Show(temp.RestituisciPassword());
        }

        private void btnModificaPass_Click(object sender, EventArgs e)
        {
            pnlPassword.Visible = true;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Cliente temp = (Cliente)lbxVideoteca.Items[lbxVideoteca.SelectedIndex];
            if (txtNuova.Text != txtConferma.Text)
            {
                MessageBox.Show("Le nuove password non corrispondono");
                txtNuova.Text = "";
                txtConferma.Text = "";
            }
            else
            {
                if (!temp.ModificaPassword(txtVecchia.Text.ToUpper().Trim(), txtNuova.Text.ToUpper().Trim()))
                    MessageBox.Show("Password passate come parametri errate");
                else
                    MessageBox.Show("Password modificata correttamente");
                Azzera();
            }
        }

        public void Azzera()
        {
            if(pnlRicerca.Visible)
                pnlRicerca.Visible = false;
            nudNumeroFilm.Value = 0;
            if(pnlPassword.Visible)
                pnlPassword.Visible = false;
            txtNuova.Text = "";
            txtConferma.Text = "";
            txtVecchia.Text = "";
        }
    }
}
