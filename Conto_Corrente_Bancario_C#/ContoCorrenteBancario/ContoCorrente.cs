using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoCorrenteBancario
{
    public class ContoCorrente
    {
        private int numC, saldoA;
        private static int numM;
        List<string> listaM = new List<string>();

        public ContoCorrente(int num, int saldo)
        {
            numC = num;
            saldoA = saldo;
        }

        public ContoCorrente(int num) : this(num, 0)
        {
        }

        public void Prelievo(int importo)
        {
            DateTime data = DateTime.Today;
            if(importo >= 0)
            {
                saldoA -= importo;
                listaM.Add(importo + ";" + data.ToString("d"));
            }
        }

        public void Versamento(int importo)
        {
            DateTime data = DateTime.Today;
            if (importo >= 0)
            {
                saldoA += importo;
                listaM.Add(importo + ";" + data.ToString("d"));
            }
        }

        public string GetListaMovimenti()
        {
            string s="";
            foreach (string i in listaM)
                s = s + i + "\n";
            return s;
        }

        public string GetDataRecente()
        {
            if (listaM.Count >= 1)
            {
                int pos = listaM[listaM.Count - 1].IndexOf(";");
                return listaM[listaM.Count - 1].Substring(pos + 1);
            }
            else
                return "Non ci sono ancora movimenti";
        }

        public int Saldo
        {
            get
            {
                return saldoA;
            }

            set
            {
                saldoA = value;
            }
        }
    }   
}
