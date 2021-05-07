using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbitazioniQuartieri
{
    class Abitazione
    {
        protected string indirizzo;
        protected double mq;
        protected int nVani;

        public Abitazione(string indirizzo, int nVani)
        {
            Indirizzo = indirizzo;
            this.nVani = nVani;
        }

        public Abitazione(string indirizzo, int nVani, double mq) : this(indirizzo, nVani)
        {
            this.mq = mq;
        }

        public double MediaMqPerVano()
        {
            return mq / nVani;
        }

        public virtual double CalcolaImposta()
        {
            return 0;
        }

        public string Indirizzo
        {
            get { return indirizzo; }
            set { indirizzo = value; }
        }

        public override string ToString()
        {
            return $"Abitazione: {Indirizzo}, {nVani}, {mq}";
        }
    }

    class AbitazioneLusso : Abitazione
    {
        public AbitazioneLusso(string indirizzo, int nVani) : base(indirizzo, nVani)
        { }

        public AbitazioneLusso(string indirizzo, int nVani, double mq) : base(indirizzo, nVani, mq)
        { }

        public override double CalcolaImposta()
        {
            return mq * 2.5;
        }

        public override string ToString()
        {
            return base.ToString() + ", di lusso";
        }
    }

    class AbitazionePopolare : Abitazione
    {
        public AbitazionePopolare(string indirizzo, int nVani) : base(indirizzo, nVani)
        { }

        public AbitazionePopolare(string indirizzo, int nVani, double mq) : base(indirizzo, nVani, mq)
        { }

        public override double CalcolaImposta()
        {
            return mq * 2;
        }

        public override string ToString()
        {
            return base.ToString() + ", popolare";
        }
    }
}
