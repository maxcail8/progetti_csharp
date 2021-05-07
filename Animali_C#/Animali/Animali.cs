/*
 * 2° esempio: classi astratte
 * 
 * Una classe astratta (o generica) non rappresenta nessun oggetto concreto ma fornisce un insieme di caratteristiche (attributi e metodi) comuni a tutte le classi figlie ereditate da essa.
 * 
 * N.B.: una classe astratta per come è definita, non può essere istanziata. 
 * Nell'esempio seguente, Animale è una classe astratta che verrà poi specializzata nelle classi (concrete) Mucca, Cavallo, Pecora, Gallo, ... 
 * La classe Animale contiene le caratteristiche comuni a tutti gli animali, come il colore e la possibilità di emettere un verso: questo consentirà di dichiarare oggetti generici di classe Animale e decidere poi a tempo di esecuzione se saranno mucche, cavalli, ecc...
 * Una classe astratta può contenere tutto quanto si può mettere in una classe concreta quindi anche costruttori (sebbene questi saranno utilizzati solo dalle classi derivate).
 * Il metodo Verso è un metodo astratto cioè non è implementato (e non deve esserlo) nella classe Animale ma sarà definito nelle classi derivate.
 * 
 * N.B.: se una classe contiene un metodo astratto, deve essere dichiarata come astratta. Le classi derivate da una classe astratta devono implementare tutti i metodi astratti delle classe padre.
 */

using System;
using System.Media;

namespace Animali
{
    abstract class Animale: Object
    {
        private static SoundPlayer player = new SoundPlayer();

        protected void Play(string fileAudio)
        {
            player.SoundLocation = fileAudio;
            player.PlaySync();
        }

        private string colore;
       
        public abstract string Verso();
        
        public string Colore
        {
            get { return colore; }
            set { colore = value; }
        }
    }
		
    class Asino : Animale
    {
        public override string Verso()
        {
            Play("asino.wav");
            return "hi! ho!";
        }
    }
		
    class Cavallo : Animale
    {
        public override string Verso()
        {
            Play("cavallo.wav");
            return "hii! hii!";
        }
    }
		
    class Gallo : Animale
    {
        public override string Verso()
        {
            Play("gallo.wav");
            return "chichirichii!";
        }
    }
    
    class Gatto : Animale
    {
        public override string Verso()
        {
            Play("gatto.wav");
            return "miao!";
        }
    }

    class Maiale : Animale
    {
        public override string Verso()
        {
            Play("maiale.wav");
            return "miao!";
        }
    }

    class Mucca : Animale
    {
        public override string Verso()
        {
            Play("mucca.wav");
            return "muuu! muuu!";
        }
    }

    class Papera : Animale
    {
        public override string Verso()
        {
            Play("papera.wav");
            return "qua! qua!";
        }
    }
}