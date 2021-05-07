using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unix
{
    public class UserList
    {
        private List<User1> lista = new List<User1>();

        public void Aggiungi(User1 u)
        {
            lista.Add(u);
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

        public void AggiungiGruppo(int indice, Group g)
        {
            lista[indice].AggiungiGruppo(g);
        }

        public User1 UserInd(int indice)
        {
            return lista[indice];
        }
    }

    public class UserList1 : UserList
    {
    }
}
