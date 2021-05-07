using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unix
{
    public partial class FrmGroup : Form
    {
        public FrmGroup()
        {
            InitializeComponent();
        }

        private GroupList lista = new GroupList();
        private bool controlloP;

        public FrmGroup(GroupList gruppi)
        {
            InitializeComponent();
            this.lista = gruppi;
            lbxGruppi.Items.Clear();
            for (int i = 0; i < lista.Dimensione; i++)
                lbxGruppi.Items.Add(lista.Nome(i));
        }

        public bool Risultato()
        {
            if (txtPasswordGruppo.Text == lista.Password(lbxGruppi.SelectedIndex))
                controlloP = true;
            else
                controlloP = false;
            return controlloP;
        }

    }
}
