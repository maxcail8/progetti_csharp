using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbitazioniQuartieri
{
    class Quartiere
    {
        private List<Abitazione> quartiere;

        public Quartiere()
        {
            quartiere = new List<Abitazione>();
        }

        public int NumeroAbitazioniLusso()
        {
            int con = 0;
            foreach (Abitazione a in quartiere)
            {
                if (a is AbitazioneLusso)
                    con++;
            }
            return con;
        }

        public int NumeroAbitazioniPopolari()
        {
            int con = 0;
            foreach (Abitazione a in quartiere)
            {
                if (a is AbitazionePopolare)
                    con++;
            }
            return con;
        }

        public bool Esistenza(Abitazione a)
        {
            bool esiste = false;
            for (int i = 0; i < quartiere.Count && !esiste; i++)
                if (quartiere[i].Indirizzo == a.Indirizzo)
                    esiste = true;
            return esiste;
        }

        public bool AggiungiAbitazione(Abitazione a)
        {
            bool aggiunto = false;
            if (!Esistenza(a))
            {
                quartiere.Add(a);
                aggiunto = true;
            }
            return aggiunto;
        }

        public double ImposteTotali()
        {
            double tot = 0;
            foreach (Abitazione a in quartiere)
                tot += a.CalcolaImposta();
            return tot;
        }

        public int AbitazioniDiLusso()
        {
            return NumeroAbitazioniLusso();
        }
    }
}
