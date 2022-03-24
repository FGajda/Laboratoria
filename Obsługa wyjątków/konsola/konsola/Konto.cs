using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace konsola
{
    class Konto
    {
        public Osoba Wlasciciel = new Osoba();
        public decimal Saldo { get; set; }
        public int PIN { get; set; }
        public Konto(string A, string B, decimal C, int D) { Wlasciciel.Imie = A; Wlasciciel.Nazwisko = B; Saldo = C; PIN = D; }
        public Konto() { }
        int PINP(int PIN2)
        {
            if (PIN == PIN2)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }
        public decimal wplata(int wplata) 
        {
            Saldo = Saldo + wplata;
            return Saldo + wplata;
        }
        public decimal wyplata(int wyplata, int PIN2) 
        {
            if (PINP(PIN2)==1)
            {
                Console.WriteLine("Operacja wykonana poprawnie");
                Saldo = Saldo - wyplata;
                return Saldo - wyplata;
            }
            else
            {
                Console.WriteLine("Operacja anulowana");
                return Saldo;
            }

        }
        public int zmianaPIN(int PIN2,int PIN3)
        {
            if (PINP(PIN2) == 1)
            {
                return PIN = PIN3;
            }
            else
            {
                Console.WriteLine("Operacja anulowana");
                return PIN;
            }
        }
        public string info(int PIN2) 
        {
            if (PINP(PIN2) == 1)
            {
                Console.WriteLine("stan konta to {0}", Saldo);
                return string.Format("stan konta to {0}",Saldo);
            }
            else
            {
                return string.Format("Odmowa");
            }
        }
    }
    class blad : ApplicationException
    {
        public blad(string text)
            : base(text)
        { 
        }
    }
}
