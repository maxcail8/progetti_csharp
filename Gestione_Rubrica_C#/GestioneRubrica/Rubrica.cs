using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestioneRubrica
{
    public class Rubrica
    {
        private string cognomeP, nomeP;
        private List<Contatto> lista = new List<Contatto>();
        
        public Rubrica(string c, string n)
        {
            this.cognomeP = c;
            this.nomeP = n;
        }

        public void Aggiungi(Contatto c)
        {
            lista.Add(c);
        }

        public void Aggiungi(string cognome, string nome, string tCellulare, string tLavoro, string tCasa, string email)
        {
            Contatto c = new Contatto(cognome, nome, tCellulare, tLavoro, tCasa, email);
            lista.Add(c);
        }

        public void SalvaFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < lista.Count; i++)
                sw.WriteLine(lista[i].ToString());
            sw.Close();
        }

        public void CaricaFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            Contatto c = null;
            while (!sr.EndOfStream)
            {
                c = new Contatto(sr.ReadLine());
                lista.Add(c);
            }
            sr.Close();
        }

        public override string ToString()
        {
            string s = $"PROPRIETARIO\n{cognomeP} {nomeP}\nCONTATTI\n";
            for (int i = 0; i < lista.Count; i++)
                s += lista[i].ToString() + "\n";
            return s;
        }

        public string Cognome
        {
            get
            {
                return this.cognomeP;
            }
        }

        public string Nome
        {
            get
            {
                return this.nomeP;
            }
        }
    }
}
