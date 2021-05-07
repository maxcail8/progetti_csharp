// 1° esempio: static e dynamic binding (polimorfismo)
using System;
using System.Media;

namespace Cani
{
    class Cane : Object
    {
        private static SoundPlayer player = new SoundPlayer();

        protected void Play(string fileAudio)
        {
            player.SoundLocation = fileAudio;
            player.PlaySync();
        }

        public string GetRazza()
        {
            return "Razza generica";
        }

        public virtual string Verso()
        {
            Play("cane.wav");
            return "bau! bau!";
        }

        /*
         * questo metodo esiste nella classe base Object (restituisce il nome della classe) e viene qui ridefinito
         */
        public override string ToString()
        {
            return "Sono un cane";
        }
    }

    class CanePastore : Cane
    {
        public new string GetRazza()  // nasconde quello di Cane 
        {
            return "Razza San Bernardo";
        }

        public override string Verso()  // ridefinisce quello di Cane
        {
            Play("cane_pastore.wav");
            return "BAU! BAU! BAU!";
        }

        public bool ControllaPecore()
        {
            bool ok = true;
            // qualche codice per verificare che le pecore ci siano tutte
            return ok;
        }

        public override string ToString()  // ridefinisce quello di Cane
        {
            return base.ToString() + ", anzi un cane pastore!";
        }
    }

    class CaneDaGuardia : Cane
    {
        public new string GetRazza()  // nasconde quello di Cane 
        {
            return "Razza Rottweiler";
        }

        public override string Verso()  // ridefinisce quello di Cane
        {
            Play("cane_guardia.wav");
            return "GRR! GRR!";
        }

        public bool PerlustraTerritorio()
        {
            bool ok = true;
            // qualche codice per controllare il territorio
            return ok;
        }

        public override string ToString()  // ridefinisce quello di Cane
        {
            return base.ToString() + ", anzi un cane da guardia!";
        }
    }

    class CaneDaGuardiaPiccolo : CaneDaGuardia
    {
        // ridefinisce quello di CaneDaGuardia
        public override string Verso() 
        {
            Play("cane_piccolo.wav");
            return "gr... gr...";
        }
    }
		
	/*
     * STATIC BINDING (collegamento statico o anticipato)
     * 
     * Il tipo di un oggetto referenziato da una variabile è determinato durante l'esecuzione del programma (tipo dinamico), mentre la decisione di quale metodo debba essere invocato è prodotta durante la compilazione e dipende unicamente dal tipo della variabile (tipo statico).
     * Nell'esempio precedente, il metodo getRazza() nelle classi CanePastore e CaneGuardia nasconde il metodo getRazza() della classe Cane. Se si utilizza una variabile di classe Cane e a questa assegnamo un oggetto di classe CanePastore o CaneGuardia, comunque verrà richiamato il metodo della classe Cane.
     * 
     * DYNAMIC BINDING (collegamento dinamico o ritardato)
     * 
     * Con il collegamento ritardato la decisione di quale metodo invocare dipende dal tipo effettivamente assunto dall'oggetto durante l'esecuzione del programma (tipo dinamico). 
     * Il metodo della classe base deve essere dichiarato con la parola chiave virtual; nelle classi derivate il metodo deve essere ridefinito con la parola chiave override.
     * 
     * N.B.: Un metodo viene cioè dichiarato virtual perchè possa essere ridefinito nelle classi derivate; è importante quindi che sia pubblico (altrimenti si ha un errore di compilazione).
	*/
}