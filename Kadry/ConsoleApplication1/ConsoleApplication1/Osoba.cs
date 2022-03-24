using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NumerEwidencyjny { get; }
        public Adres Adres = new Adres { };
        public string DataUrodzenia { get; set; }
        public Umowa Umowa = new Umowa { };

        public Osoba(string Imie, string Nazwisko, string NumerEwidencyjny, Adres Adres, string DataUrodzenia, Umowa Umowa)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.NumerEwidencyjny = NumerEwidencyjny;
            this.Adres = Adres;
            this.DataUrodzenia = DataUrodzenia;
            this.Umowa = Umowa;
        }

        public override string ToString()
        {
            return "Dane Osobowe: " + Imie + " " + Nazwisko + " " + NumerEwidencyjny + " " + Adres + " " + DataUrodzenia + " " + Umowa;
        }
    }
}
