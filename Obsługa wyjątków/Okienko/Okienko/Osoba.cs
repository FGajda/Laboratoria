using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Okienko
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Osoba(string A, string B) { Imie = A; Nazwisko = B; }
        public Osoba() { }
    }
}