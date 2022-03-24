using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KomisKonsola
{
    class Komis
    {
        List<Samochod> Samochody;

        public void Dodaj_do_komisu()
        {
            String Marka;
            double Cena;
            int Drzwi, Spalanie;
            Console.WriteLine("Podaj marke");
            Marka = Console.ReadLine();
            Console.WriteLine("Podaj cene");
            Cena = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilość drzwi");
            Drzwi = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ile spala");
            Spalanie = int.Parse(Console.ReadLine());
            Samochody.Add(new Samochod(Marka, Cena, Drzwi, Spalanie));
        }
        public void Usun_z_komisu()
        {
            String marka;
            Console.WriteLine("Podaj marke");
            marka = Console.ReadLine();
            Samochod Usunieca = Samochody.FirstOrDefault(Samochod => Samochod.Marka == marka);
            Samochody.Remove(Usunieca);
        }
        public void Znajdz_w_komisie()
        {
            Console.WriteLine("Podaj czego szukasz");
            Console
        }
    }
}
