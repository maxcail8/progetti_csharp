using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneRubrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Contatto con = null;
        Rubrica rub = null;
        List<Contatto> lista = new List<Contatto>();
        List<Rubrica> listaR = new List<Rubrica>();

        private void Azzera()
        {
            txtCasa.Text = "";
            txtCellulare.Text = "";
            txtCognome.Text = "";
            txtEmail.Text = "";
            txtLavoro.Text = "";
            txtNome.Text = "";
            txtInd.Text = "";
            txtCognomeP.Text = "";
            txtNomeP.Text = "";
            pnlContatto.Enabled = true;
            pnlContattiCreati.Enabled = false;
            btnAggiungiE.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Azzera();
            pnlRubrica.Enabled = false;
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            if(txtCognome.Text != "" && txtNome.Text != "" && txtCellulare.Text != "" && txtLavoro.Text != "" && txtCasa.Text != "" && txtEmail.Text != "")
            {
                con = new Contatto(txtCognome.Text, txtNome.Text, txtCellulare.Text, txtLavoro.Text, txtCasa.Text, txtEmail.Text);
                lista.Add(con);
                lbxContatti.Items.Add($"{con.Cognome};{con.Nome};{con.Email};{con.Id}");
            }
            else
            if(txtCognome.Text != "" && txtNome.Text != "" && txtCellulare.Text != "" && txtLavoro.Text == "" && txtCasa.Text == "" && txtEmail.Text == "")
            {
                con = new Contatto(txtCognome.Text, txtNome.Text, txtCellulare.Text);
                lista.Add(con);
                lbxContatti.Items.Add($"{con.Cognome};{con.Nome};{con.Email};{con.Id}");
            }
            else
                MessageBox.Show("Parametri non corretti");
            Azzera();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(con != null)
                MessageBox.Show(con.ToString(), "Informazioni sul contatto");
        }

        private void btnCreaR_Click(object sender, EventArgs e)
        {
            rub = new Rubrica(txtCognomeP.Text, txtNomeP.Text);
            listaR.Add(rub);
            lbxRubrica.Items.Add($"{rub.Cognome};{rub.Nome}");
            pnlRubrica.Enabled = true;
            btnSalva.Enabled = true;
            btnCarica.Enabled = true;
            Azzera();
        }

        private void btnAddE_Click(object sender, EventArgs e)
        {
            pnlContattiCreati.Enabled = true;
            pnlContatto.Enabled = false;
        }

        private void btnAddD_Click(object sender, EventArgs e)
        {
            btnAggiungiE.Enabled = true;
            pnlContattiCreati.Enabled = false;
            pnlContatto.Enabled = true;
        }

        private void btnAggiungiE_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" && txtNome.Text != "" && txtCellulare.Text != "" && txtLavoro.Text != "" && txtCasa.Text != "" && txtEmail.Text != "")
            {
                rub.Aggiungi(txtCognome.Text, txtNome.Text, txtCellulare.Text, txtLavoro.Text, txtCasa.Text, txtEmail.Text);
                con = new Contatto(txtCognome.Text, txtNome.Text, txtCellulare.Text, txtLavoro.Text, txtCasa.Text, txtEmail.Text);
            }
            else
                throw new ArgumentException("Parametri non validi");
            lista.Add(con);
            Azzera();
        }

        private void btnAggiungiD_Click(object sender, EventArgs e)
        {
            if (lbxContatti.SelectedIndex >= 0)
                rub.Aggiungi(lista[lbxContatti.SelectedIndex]);
            else
                MessageBox.Show("Nessun contatto  selezionato");
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                rub.SalvaFile(ofd.FileName);
                btnSalva.Enabled = false;
            }
            MessageBox.Show("Operazione eseguita", "Salva file");
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                rub.CaricaFile(ofd.FileName);
                btnCarica.Enabled = false;
            }
            MessageBox.Show("Operazione eseguita", "Carica file");
        }

        private void btnInfoR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rub.ToString(), "Informazioni sulla rubrica");
        }

        private void btnDatiR_Click(object sender, EventArgs e)
        {
            if (lbxRubrica.SelectedIndex >= 0)
            {
                MessageBox.Show(listaR[lbxRubrica.SelectedIndex].ToString(), "Dati della rubrica");
            }
            else
                MessageBox.Show("Nessun proprietario selezionato");
        }

        private void btnInd_Click(object sender, EventArgs e)
        {
            if (txtInd.Text != "" && con != null)
                MessageBox.Show($"Il numero vale: \n{con[txtInd.Text]}", "Numero");
        }
    }
}
