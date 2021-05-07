using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Unix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        User1 user = null;
        UserList arrayList = new UserList();
        Group group = null;
        GroupList groupList = new GroupList();

        private void Azzera()
        {
            txtCommento.Text = "";
            txtHomeD.Text = "";
            txtNome.Text = "";
            txtPassword.Text = "";
            txtShell.Text = "";
            txtPasswordP.Text = "";
        }

        public void AzzeraG()
        {
            txtNomeG.Text = "";
            txtPasswordG.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Azzera();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtPassword.Text != "" && txtCommento.Text != "" && txtHomeD.Text != "" && txtShell.Text != "")
            {
                user = new User1(txtNome.Text, txtPassword.Text, txtCommento.Text, txtHomeD.Text, txtShell.Text);
                arrayList.Aggiungi(user);
                if(txtPasswordP.Text != "")
                    group = new Group(txtNome.Text, txtPasswordP.Text);
                else
                    group = new Group(txtNome.Text);
                groupList.Aggiungi(group);
                user.AggiungiGruppo(group);
                lbxUser.Items.Add($"{user.Nome}:{user.Commento}:{user.HomeDirectory}:{user.Shell}:{user.Id}");
                Azzera();
            }
            else
            if (txtNome.Text != "" && txtPassword.Text == "" && txtCommento.Text == "" && txtHomeD.Text == "" && txtShell.Text == "")
            {
                user = new User1(txtNome.Text);
                arrayList.Aggiungi(user);
                if (txtPasswordP.Text != "")
                    group = new Group(txtNome.Text, txtPasswordP.Text);
                else
                    group = new Group(txtNome.Text);
                groupList.Aggiungi(group);
                user.AggiungiGruppo(group);
                lbxUser.Items.Add($"{user.Nome}:{user.Commento}:{user.HomeDirectory}:{user.Shell}:{user.Id}");
                Azzera();
            }
            else
                MessageBox.Show("Parametri non validi", "Parametri errrati");
        }
        
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (lbxUser.SelectedIndex >= 0)
                MessageBox.Show(arrayList.AccediToString(lbxUser.SelectedIndex), "Informazioni user");
            else
                MessageBox.Show("Nessun username selezionato", "Selezione errata");
        }

        private void btnCreaG_Click(object sender, EventArgs e)
        {
            if (txtNomeG.Text != "" && txtPasswordG.Text != "")
            {
                group = new Group(txtNomeG.Text, txtPasswordG.Text);
                groupList.Aggiungi(group);
            }
            else
            if(txtNomeG.Text != "" && txtPasswordG.Text == "")
            {
                group = new Group(txtNomeG.Text);
                groupList.Aggiungi(group);
            }
            else
                MessageBox.Show("Parametri non validi", "Parametri errati");
            AzzeraG();
        }

        private void btnInfoG_Click(object sender, EventArgs e)
        {
            if (lbxGroup.SelectedIndex >= 0)
                MessageBox.Show(groupList.AccediToString(Convert.ToInt32(lbxGroup.SelectedIndex.ToString().Substring(lbxGroup.SelectedIndex.ToString().LastIndexOf(":")+1))), "Informazioni group");
            else
                MessageBox.Show("Nessun gruppo selezionato", "Selelzione errata");
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if(lbxUser.SelectedIndex >= 0)
            {
                bool c;
                FrmGroup f = new FrmGroup(groupList);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    c = f.Risultato();
                    if (c)
                    {
                        arrayList.AggiungiGruppo(lbxUser.SelectedIndex, groupList.GruppoInd(f.lbxGruppi.SelectedIndex));
                        MessageBox.Show("Operazione eseguita");
                        AggiornaListaGruppiUtente();
                    }
                    else
                        MessageBox.Show("Password errata");
                }
            }
            else
                MessageBox.Show("Nessun utente selezionato", "Selelzione errata");
        }

        private void lbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaListaGruppiUtente();
            txtUser.Text = arrayList.UserInd(lbxUser.SelectedIndex).Nome;
        }

        public void AggiornaListaGruppiUtente()
        {
            lbxGroup.Items.Clear();
            for (int i = 0; i < arrayList.UserInd(lbxUser.SelectedIndex).Dimensione; i++)
                lbxGroup.Items.Add(arrayList.UserInd(lbxUser.SelectedIndex).AccediToString(i));
        }

        public void AggiornaListaUtenti()
        {
            lbxUser.Items.Clear();
            for (int i = 0; i < arrayList.Dimensione; i++)
                lbxUser.Items.Add(arrayList.AccediToString(i));
        }

        private void btnCambia_Click(object sender, EventArgs e)
        {
            if (lbxUser.SelectedIndex >= 0)
            {
                FrmPassword fp = new FrmPassword();
                if (fp.ShowDialog() == DialogResult.OK)
                {
                    if(arrayList.UserInd(lbxUser.SelectedIndex).ModificaPassword(fp.txtVp.Text, fp.txtNp.Text))
                        MessageBox.Show("Operazione eseguita");
                    else
                        MessageBox.Show("Password inserite non correttamente");
                    AggiornaListaUtenti();
                }
            }
            else
                MessageBox.Show("Nessun utente selezionato", "Selelzione errata");
        }

        private void lbxUser_Click(object sender, EventArgs e)
        {
            if(lbxUser.Items.Count != 0)
                lbxUser.SelectedIndex = 0;
        }
    }
}
/*
Rappresenta usando un diagramma UML la precedente situazione introducendo le classi User, Group,
UserList, GroupList.
Cifratura password migliore!!!
*/