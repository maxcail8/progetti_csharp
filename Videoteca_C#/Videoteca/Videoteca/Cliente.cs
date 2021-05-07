using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteca
{
    class Cliente
    {
        //campi di classe
        private string cognome, nome, password;
        private DateTime dataNascita;
        int filmNolleggiati;
        int id;
        bool controlloPassword = false;

        static int con;

        //costruttori
        public Cliente(string cognome, string nome, DateTime dataNascita)
        {
            if (nome.Length >= 2 && cognome.Length >= 2)
            {
                id = ++con;
                this.cognome = cognome;
                this.nome = nome;
                this.dataNascita = dataNascita;
                filmNolleggiati = 0;
                password = ImpostaPassword();
            }
            else
                throw new ArgumentException("Parametri con lunghezza errata");
        }

        public Cliente(string cognome, string nome, DateTime dataNascita, int filmNolleggiati) : this(cognome, nome, dataNascita)
        {
            this.filmNolleggiati = filmNolleggiati;          
        }

        //metodo creazione password
        private string ImpostaPassword()
        {
            Random gen = new Random();
            string s = $"{id}{cognome.Substring(0, 2)}{nome.Substring(0, 2)}";
            int n = gen.Next(1, 100);
            if (n < 10)
                s += '0' + n;
            else
                s += n;
            return s;
        }

        //metodo modifica password
        public bool ModificaPassword(string passwordAttuale, string passwordNuova)
        {
            bool controllo;
            if (passwordAttuale == password && passwordNuova.Length > 6)
            {
                password = passwordNuova;
                controllo = true;
                controlloPassword = false;
            }
            else
                controllo = false;
            return controllo;
        }

        //proprietà
        public string Cognome
        {
            get
            {
                return cognome;
            }
            set
            {
                if (value.Length >= 2)
                    cognome = value;
                else
                    throw new ArgumentException("Parametri con lunghezza errata");
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Length >= 2)
                    nome = value;
                else
                    throw new ArgumentException("Parametri con lunghezza errata");
            }
        }

        public DateTime DataNascita
        {
            get
            {
                return dataNascita;
            }
            set
            {
                dataNascita = value;
            }
        }

        public int FilmNolleggiati
        {
            get
            {
                return filmNolleggiati;
            }
        }

        //osservatore per la password
        public string RestituisciPassword()
        {
            string s;
            if (!controlloPassword)
            {
                s = password;
            }
            else
                s = "Password già comunicata";
            controlloPassword = true;
            return s;
        }
        
        //ToString()
        public override string ToString()
        {
            return $"{cognome} {nome}, numero di film {filmNolleggiati}";
        }
    }
}
