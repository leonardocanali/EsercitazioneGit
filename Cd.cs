using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioneGit
{
    class Cd
    {
        //List<Brano> _brani;
        //public Cd(titolo,autore,List<Brano> brani)
        //ToString()---- tutti i titoli
        //public int Durata()

        private string _titoloCd;
        private string _autore;
        private List<Brano> _brani;


        public Cd(string titoloCd, string autore, List<Brano> brani)
        {
            Titolo = titoloCd;
            Autore = autore;
            _brani = brani;
        }

        public string Titolo
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Inserire un titolo valido");
                }

                _titoloCd = value;
            }

            get
            {
                return _titoloCd;
            }
        }

        public string Autore
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Inserire un autore valido");
                }

                _autore = value;
            }

            get
            {
                return _autore;
            }
        }

        public int DurataTotale(List<Brano> brani) //fa la somma di tutte le durate (in secondi) dei brani prendendo una lista di brani
        {
            int durataTotale = 0;
            foreach(Brano b in brani)
            {
                durataTotale =+ b.Durata;
            }

            return durataTotale;
        }
        
        public string CdToString(List<Brano> brani) //prende la lista titoli e fa il tostring di ogni titolo e lo aggiunge alla stringa stringTitoli
        {
            string stringTitoli = "";

            foreach(Brano b in brani)
            {
                stringTitoli += b.Titolo + "\n";
            }

            return stringTitoli;
        }
    }
}
