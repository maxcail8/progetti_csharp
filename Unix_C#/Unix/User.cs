using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Unix
{
    public class User
    {
        private string username, password, commento, homeD, shell;
        private int id;
        private static int con=1;
        //StreamWriter sw = new StreamWriter("etc/passwd");

        public User(string n, string p, string c, string h, string s)
        {
            this.username = n;
            this.password = p;
            this.commento = c;
            this.homeD = h;
            this.shell = s;
            this.id = con++;
        }

        public User(string n) : this(n, "", "", $"/home/{n}", "/bin/bash")
        {
        }

        public bool ModificaPassword(string vP, string nP)
        {
            bool cambio;
            if(vP != this.password || nP.Length < 6)
                cambio = false;
            else
            {
                cambio = true;
                this.password = nP;
            }
            return cambio;
        }

        public string Cifratura(string password)
        {
            string s="";
            char c;
            if (password != "")
                for (int i = 0; i < password.Length; i++)
                {
                    c = Convert.ToChar(password[i] + 3);
                    if (c == ':')
                        c = '?';
                    s += c;
                }
            else
                s = " ";
            return s;
        }

        public string Nome
        {
            get
            {
                return this.username;
            }
        }

        public string Commento
        {
            get
            {
                return this.commento;
            }
        }

        public string HomeDirectory
        {
            get
            {
                return this.homeD;
            }
        }

        public string Shell
        {
            get
            {
                return this.shell;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public override string ToString()
        {
            return $"{this.username}:{Cifratura(this.password)}:{this.id}:{this.commento}:{this.homeD}:{this.shell}";
        }

        public void Scrivi(StreamWriter sw)
        {
            //id group (primario)
            sw.WriteLine($"{this.username}:{Cifratura(this.password)}:{this.id}:{this.commento}:{this.homeD}:{this.shell}");
            sw.Close();
        }      
    }

    public class User1 : User
    {
        private GroupList listaGruppi = new GroupList();
        public User1(string n, string p, string c, string h, string s) : base(n, p, c, h, s)
        {
        }

        public User1(string n) : base(n)
        {
        }

        public void AggiungiGruppo(Group g)
        {
            listaGruppi.Aggiungi(g);
        }

        public int Dimensione
        {
            get
            {
                return listaGruppi.Dimensione;
            }
        }

        public string AccediToString(int indice)
        {
            return listaGruppi.AccediToString(indice);
        }
    }
}
