using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioneGit
{
    class Brano
    {
        private string _titolo;
        private string _autore;
        private int _durata;
        public string Titolo
        {
            get { return _titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("errore nell'inserimento del titolo");
                }
                _titolo = value;
            }
        }
        public string Autore
        {
            get { return _autore; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("errore nell'inserimento dell'autore");
                }
                _autore = value;
            }
        }
        public int Durata
        {
            get { return _durata; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("errore nell'inserimento della durata");
                }
                _durata = value;
            }
        }
        public Brano(string titolo,string autore,int durata)
        {
            Titolo = titolo;
            Autore = autore;
            Durata = durata;
        }
        public override string ToString()
        {
            return "Titolo: "+Titolo+"\rAutore: "+Autore+"\rDurata(in secondi): "+Durata;
        }
        public bool ShortSong(int durata, Brano b)
        {
            bool soluzione=false;
            if (b.Durata<durata)
            {
                soluzione = true;
            }
            return soluzione;
        }

    }
}
