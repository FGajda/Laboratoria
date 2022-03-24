using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class KontoBankowe
    {
        List<KartaKlienta> karty;

        public decimal Saldo { get; private set; }
        public int PIN { get; set; }
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }

        public List<KartaKlienta> Karty
        {
            get 
            {
                if (karty == null)
                {
                    karty = new List<KartaKlienta>();
                }
                return karty;
            }
        }
        public void UstawDaneWlasciciela(string imie, string nazwisko, int pin)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            PIN = pin;
        }
        public void Wplac(decimal kwota)
        {
            Saldo += kwota;
        }
        public void Wyplac(decimal kwota)
        {
            Saldo -= kwota;
        }

    }
}
