using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autonoleggio
{
    class Veicolo
    {
        string targa, marca, modello;
        int numeroMatricola;
        double cilindrata, capacitaLitri;
        DateTime dataAcquisto;

        public Veicolo(string tar, string mar, string mod, int num, double cil, double cap, DateTime data)
        {
            targa = tar;
            marca = mar;
            modello = mod;
            numeroMatricola = num;
            cilindrata = cil;
            capacitaLitri = cap;
            dataAcquisto = data;
        }
    }
}
