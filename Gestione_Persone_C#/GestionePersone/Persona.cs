using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionePersone
{
    public class Persona : Object //è come non scriverlo poichè tutte le classi sono derivate dalla classe Object che contiene solo dei metodi generici condivisi da tutte le altre classi(ToString())
    {
        protected string cognome, nome;
        protected DateTime dataNascita;
        protected Persona coniuge;

        static private int numPersone = 0; //numero persone create

        public string Cognome
        {
            get
            {
                return this.cognome;
            }
            set
            {
                this.cognome = value.ToUpper().Trim();
            }
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value.ToUpper().Trim();
            }
        }

        public DateTime DataDiNascita
        {
            get
            {
                return this.dataNascita;
            }
            set
            {
                if (DateTime.Compare(value, DateTime.Now) <= 0)
                    this.dataNascita = value;
                else
                    throw new FormatException("Data di nascita sucessiva alla data odierna"); //(derivata dalla classe Exeption) che definisce il fatto che il formato è errato
            }
        }

        public Persona Coniuge
        {
            get
            {
                return this.coniuge;
            }
            set
            {
                if (value != null && value != this && !(value.Cognome == this.cognome && value.Nome == this.nome && DateTime.Compare(value.DataDiNascita, this.dataNascita) == 0))
                {
                    if(this.coniuge != null)
                        this.coniuge.coniuge = null; //divorzio
                    this.coniuge = value; //mi sposo value
                    value.coniuge = this; //sposo value con me
                }
            }
        }

        public static int NumeroPersone
        {
            get
            {
                return numPersone;
            }
        }

        public Persona(string nome, string cognome, DateTime dataNascita)
        {
            numPersone++;
            this.Nome = nome;
            this.Cognome = cognome;
            this.DataDiNascita = dataNascita;
        }

        ~Persona()
        {
            if (this.coniuge != null)
                this.coniuge.coniuge = null;
            numPersone--;
        }

        public bool CompieAnni(DateTime d)
        {
            //ritorna true se this compie gli anni nella data
            return (dataNascita.Day == d.Day && dataNascita.Month == d.Month);
        }

        public override string ToString()
        {
            return $"{this.nome} {this.cognome}, nato il: {this.dataNascita}";
        }
    }
}
