using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unix
{
    public class GroupList
    {
        List<Group> lista = new List<Group>();

        public void Aggiungi(Group g)
        {
            lista.Add(g);
        }

        public string AccediToString(int indice)
        {
            return lista[indice].ToString();
        }

        public int Dimensione
        {
            get
            {
                return lista.Count;
            }
        }

        public string Nome(int indice)
        {
            return lista[indice].Nome;
        }

        public string Password(int indice)
        {
            return lista[indice].Password;
        }

        public Group GruppoInd(int indice)
        {
            return lista[indice];
        }
    }
}
