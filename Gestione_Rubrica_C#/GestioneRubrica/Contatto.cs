using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica
{
    public class Contatto
    {
        private string cognome, nome, telCell, telLav, telCasa, email;
        private int id;

        private static int con=0;
        private string PREFISSO = "+39";

        public Contatto(string c, string n, string tCe, string tLa, string tCa, string e)
        {
            this.cognome = c;
            this.nome = n;
            this.telCell = Controllo(tCe);
            this.telLav = Controllo(tLa);
            this.telCasa = Controllo(tCa);
            this.email = e;
            this.id = con++;
        }

        public Contatto(string c, string n, string tCe) : this(c, n, tCe, " ", " ", " ")
        {
        }

        public Contatto(string s)
        {
            this.cognome = Estrai(s);
            s = Rimuovi(s);
            this.nome = Estrai(s);
            s = Rimuovi(s);
            this.telCell = Controllo(Estrai(s));
            s = Rimuovi(s);
            this.telLav = Controllo(Estrai(s));
            s = Rimuovi(s);
            this.telCasa = Controllo(Estrai(s));
            s = Rimuovi(s);
            this.email = s;
            this.id = con++;
        }

        private string Estrai(string s)
        {
            return s.Substring(0, s.IndexOf(";"));
        }
        private string Rimuovi(string s)
        {
            return s.Remove(0, s.IndexOf(";") + 1);
        }

        public string Controllo(string s)
        {
            if (s[0] != '+' && s[0] != ' ')
            {
                return PREFISSO + s;
            }
            else
                return s;
        }

        public override string ToString()
        {
            return $"{this.cognome};{this.nome};{this.telCell};{this.telLav};{this.telCasa};{this.email}";
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public string Cognome
        {
            get
            {
                return this.cognome;
            }
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
        }

        public string this[string s]
        {
            get
            {
                if (s == "cellulare")
                    if (this.telCell != " ")
                        return this.telCell;
                    else
                        return "";
                else
                if (s == "lavoro")
                    if (this.telLav != " ")
                        return this.telLav;
                    else
                        return "";
                else
                if (s == "casa")
                    if (this.telCasa != " ")
                        return this.telCasa;
                    else
                        return "";
                else
                    throw new ArgumentException("Parametro non valido");
            }
        }
    }
}