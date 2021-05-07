using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionePersone
{
    class Studente: Persona
    {
        private string classe, scuola;

        public string Classe
        {
            get
            {
                return this.classe;
            }
        }
        public string Scuola
        {
            get
            {
                return this.scuola;
            }
        }

        public Studente(string nome, string cognome, DateTime dataNascita, string classe, string scuola) : base(nome, cognome, dataNascita)
        {
            this.classe = classe;
            this.scuola = scuola;
        }

        public override string ToString()
        {
            return base.ToString() + $", classe: {this.classe}, scuola: {this.scuola}";
        }

    }
}
