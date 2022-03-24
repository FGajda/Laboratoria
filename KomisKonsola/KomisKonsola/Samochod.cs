using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KomisKonsola
{
    class Samochod
    {
        public string Marka { get; set; }
        public double Cena { get; set; }
        public int Liczba_drzwi { get; set; }
        public int Spalanie { get; set; }

        public Samochod(string marka, double cena, int liczba_drzwi, int spalanie) { Marka = marka; Cena = cena; Liczba_drzwi = liczba_drzwi; Spalanie = spalanie; }

    }
}
