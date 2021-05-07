using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Unix
{
    public class Group
    {
        private string nome, password;
        private int id;
        private static int con=1;

        private List<User1> lista = new List<User1>();

        public Group(string n, string p)
        {
            this.nome = n;
            this.password = p;
            this.id = con++;
        }

        public Group(string n) : this(n, "")
        {
        }

        public string Cifratura(string password)
        {
            string s = "";
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

        public void AggiungiUser(User1 u)
        {
            lista.Add(u);
        }

        public override string ToString()
        {
            return $"{this.nome}:{Cifratura(this.password)}:{this.id}";
        }

        public void Scrivi(StreamWriter sw)
        {
            sw.Write($"{this.nome}:{Cifratura(this.password)}:{this.id}");
            for (int i = 0; i < lista.Count; i++)
                sw.Write(lista[i].Nome + ",");
            sw.WriteLine();
            sw.Close();
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }
    }
}
