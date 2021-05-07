using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autonoleggio
{
    class Furgone : Veicolo
    {
        double capacitaCarico;

        public Furgone(string tar, string mar, string mod, int num, double cil, double cap, DateTime data, int capC) : base(tar, mar, mod, num, cil, cap, data)
        {
            capacitaCarico = capC;
        }
    }
}
