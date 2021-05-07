using System;
using System.Windows.Forms;
using Cani;
using Animali;

namespace OOP
{
    public partial class MainForm : Form
    {
        Cane c = null;
 
        public MainForm()
        {
            InitializeComponent();
        }

        private bool OggettoEsistente(Object obj)
        {
            if (obj == null)
            {
                MessageBox.Show("Devi creare un'istanza prima!", 
                    "Oggetto inesistente", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                return false;
            }
            else
                return true;
        }

        private void btnCreaCane_Click(object sender, EventArgs e)
        {
            if (rbCane.Checked) 
                c = new Cane();
            if (rbCanePastore.Checked) 
                c = new CanePastore();
            if (rbCaneDaGuardia.Checked) 
                c = new CaneDaGuardia();
            if (rbCaneDaGuardiaPiccolo.Checked) 
                c = new CaneDaGuardiaPiccolo();
            btnCreaCane.Enabled = false;
        }

        private void btnVerso_Click(object sender, EventArgs e)
        {
            if (OggettoEsistente(c))
            {
                MessageBox.Show(c.Verso());
                c = null;
                btnCreaCane.Enabled = true;
            }
        }

        private void btnGetRazza_Click(object sender, EventArgs e)
        {
            if (OggettoEsistente(c))
            {
                MessageBox.Show(c.GetRazza());
                c = null;
                btnCreaCane.Enabled = true;
            }
        }

        private void btnToString_Click(object sender, EventArgs e)
        {
            if (OggettoEsistente(c))
            {
                MessageBox.Show(c.ToString());
                c = null;
                btnCreaCane.Enabled = true;
            }
        }

        private void btnControlloTipo_Click(object sender, EventArgs e)
        {
            if (!OggettoEsistente(c))
                return;
            
            CanePastore cs;
            cs = new CanePastore();


           /* 
			* cs = c   è errata! perchè la classe Cane non deriva dalla 
            *          classe CanePastore.
			*          E' necessario rendere esplicito che c referenzia 
            *          effettivamente un oggetto di tipo CanePastore e che 
            *          dunque l'assegnazione è valida.
			*
			* L'operatore "is" permette di conoscere il tipo effettivo di 
            * un oggetto: restituisce true se il tipo run-time dell'oggetto 
            * a cui è applicato è uguale o derivato da quello specificato, 
            * false altrimenti.
			* Possiamo usarlo prima di convertire esplicitamente c in un 
            * oggetto di classe CanePastore
			*/

            if (c is CanePastore) {
                cs = (CanePastore) c;
                MessageBox.Show(cs.GetRazza());
            }

            /* 
             * Un altro modo è quello di usare l'operatore "as": esso 
             * converte il tipo dell'oggetto a cui è applicato nel tipo 
             * specificato, ma diversamente dall'operatore di cast, non 
             * solleva un eccezione nel caso in cui la conversione non 
             * possa essere eseguita ma restituisce un valore null
			*/
            CaneDaGuardia cg;

            cg = c as CaneDaGuardia;
            if (cg != null)
                MessageBox.Show(cg.GetRazza());


            /*
             * N.B.: la condizione seguente sarà sempre verificata.
             * Se ad esempio c diventa un cane pastore sarà a maggior ragione anche un cane
             */
            if (c is Cane)
                MessageBox.Show(c.GetRazza());
 
            c = null;
            btnCreaCane.Enabled = true;
        }

				
        // ------------------------------------- classi astratte
      
        private void MainForm_Load(object sender, EventArgs e)
        {             
        }

        private void btnCreaAnimale_Click(object sender, EventArgs e)
        {                      
            Animale a = null;
            switch (cbxTipoAnimale.Text) 
            {               
                case "Asino": 
                    a = new Asino(); break;
                case "Cavallo":
                    a = new Cavallo(); break;
                case "Gallo":
                    a = new Gallo(); break;
                case "Gatto":
                    a = new Gatto(); break;
                case "Maiale":
                    a = new Maiale(); break;
                case "Mucca":
                    a = new Mucca(); break;
                case "Papera":
                    a = new Papera(); break;
            }
            if (a != null)
                lbxAnimali.Items.Add(a);

            

        }

        private void btnVersoAnimali_Click(object sender, EventArgs e)
        {
            Animale a;
            for (int i = 0; i < lbxAnimali.Items.Count; i++)
            {
                a = (Animale)lbxAnimali.Items[i];
                a.Verso();
            }
        }
    }
}