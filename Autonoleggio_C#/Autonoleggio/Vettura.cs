using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autonoleggio
{
    class Vettura : Veicolo
    {
        int numeroPosti;

        public Vettura(string tar, string mar, string mod, int num, double cil, double cap, DateTime data, int numP) : base(tar, mar, mod, num, cil, cap, data)
        {
            numeroPosti = numP;
        }
    }
}
