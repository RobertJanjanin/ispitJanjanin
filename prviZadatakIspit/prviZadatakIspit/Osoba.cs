using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prviZadatakIspit
{
    class Osoba
    {
        string Ime;
        string Prezime;
        int Oib;
        int Rodenje;

        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public int Oib1 { get => Oib; set => Oib = value; }
        public int Rodenje { get => Rodenje; set => Rodenje = value; }

        public Osoba(string ime, string prezime, int oib, DateTime Rodenje)
        {
            Ime = ime;
            Prezime = prezime;
            this.Oib = Oib;
            this.Rodenje = Rodenje;
        }
    }
}


