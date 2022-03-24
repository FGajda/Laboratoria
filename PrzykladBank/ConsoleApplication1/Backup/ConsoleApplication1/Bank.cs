using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Bank
    {
        KontoBankowe kontoBankowe;
        public void StartMenu()
        {
            kontoBankowe = new KontoBankowe();
            PobierzDaneKonta();
            WyswietlDaneWlasciciela();
            Console.WriteLine();
            Console.WriteLine("Naciśnij ENTER aby przejść do Menu głównego");
            Console.ReadLine();

            char opcja;
            do
            {
                Console.Clear();
                Console.WriteLine("Wybierz akcję;");
                Console.WriteLine(" 1. Wpłać");
                Console.WriteLine(" 2. Wypłać");
                Console.WriteLine(" 3. Wyświetl Saldo");
                Console.WriteLine(" 4. Zmień PIN");
                Console.WriteLine(" 5. Wyświetl dane właściciela");
                Console.WriteLine(" 6. Dodaj kartę");
                Console.WriteLine(" 7. Usuń kartę");
                Console.WriteLine(" 8. Wyświetl karty");
                Console.WriteLine(" 0. Zakoncz");
                opcja=Console.ReadKey(true).KeyChar;
                Console.Clear();
                switch(opcja)
                {
                    case'0':
                        Console.WriteLine("Do zobaczenia!");
                        break;
                    case'1':
                        Wplac();
                        break;
                    case'2':
                        Wyplac();
                        break;
                    case'3':
                        WyswietlSaldo();
                        break;
                    case'4':
                        ZmienPin();
                        break;
                    case'5':
                        WyswietlDaneWlasciciela();
                        break;
                    case'6':
                        DodajKarte();
                        break;
                    case'7':
                        UsunKarte();
                        break;
                    case'8':
                        WyswietlKarty();
                        break;
                    default:
                        Console.WriteLine("Nie wybrano żadnej akcji!");
                        break;
                }
                Console.WriteLine();
                if (opcja =='0')
                {
                    Console.WriteLine("Naciśnij ENTER aby zakończyć");
                }
                else
                {
                    Console.WriteLine("Naciśnij ENTER aby kontyuować");
                }
                Console.ReadLine();
            }while(opcja!='0');
        }
        private void WyswietlSaldo()
        {
            Console.WriteLine("Saldo: {0}", kontoBankowe.Saldo);
        }
        private void WyswietlKarty()
        {
            var karty = kontoBankowe.Karty;
            if (karty.Count == 0)
            {
                Console.WriteLine("Brak kart");
            }
            else
            {
                for (int i = 0; i < karty.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, karty[i].Numer);
                }
            }
        }
        private void UsunKarte()
        {
            Console.WriteLine("Usuwanie karty.");
            Console.WriteLine("Podaj numer karty:");

            int numer;
            if (int.TryParse(Console.ReadLine(), out numer) && numer > 0)
            {
                KartaKlienta kartaDoUsuniecia = kontoBankowe.Karty.FirstOrDefault(karta => karta.Numer == numer);
                if (kartaDoUsuniecia == null)
                {
                    Console.WriteLine("Karta o podanym numuerze nie istnieje.");
                }
                else
                {
                    kontoBankowe.Karty.Remove(kartaDoUsuniecia);
                }
            }
            else
            {
                Console.WriteLine("Numer niepoprawny.");
            }
        }
        private void DodajKarte()
        {
            Console.WriteLine("Dodawanie karty.");
            Console.WriteLine("Podaj numer karty:");

            int numer;
            if (int.TryParse(Console.ReadLine(), out numer) && numer > 0)
            {
                if (kontoBankowe.Karty.Any(karta=>karta.Numer==numer))
                {
                    Console.WriteLine("Karta o podanym numuerze już istnieje.");
                }
                else
                {
                    kontoBankowe.Karty.Add(new KartaKlienta() { Numer = numer });
                }
            }
            else
            {
                Console.WriteLine("Numer niepoprawny.");
            }
        }
        private void WyswietlDaneWlasciciela()
        {
            Console.WriteLine("Dane właściciela");
            Console.WriteLine("Imię: {0}", kontoBankowe.Imie);
            Console.WriteLine("Nazwisko: {0}", kontoBankowe.Nazwisko);
            Console.WriteLine("PIN: {0}", new string(Enumerable.Repeat('*', kontoBankowe.PIN.ToString().Length).ToArray()));
        }
        private void ZmienPin()
        {
            Console.WriteLine("Podaj obecny PIN:");
            int pin;
            if (int.TryParse(Console.ReadLine(), out pin) && kontoBankowe.PIN == pin)
            {
                Console.WriteLine("Podaj nowy PIN");
                if (int.TryParse(Console.ReadLine(), out pin) && pin > 0)
                {
                    kontoBankowe.PIN = pin;
                }
                else
                {
                    Console.WriteLine("PIN niepoprawny");
                }
            }
            else
            {
                Console.WriteLine("PIN niepoprawny");
            }
        }
        private void Wplac()
        {
            decimal wplata = 0;
            Console.WriteLine("Podaj kwotę wpłaty");
            if (decimal.TryParse(Console.ReadLine(), out wplata))
            {
                kontoBankowe.Wplac(wplata);
            }
            else
            {
                Console.WriteLine("Podano niepopawną kwotę.");
            }
        }
        private void Wyplac()
        {
            decimal wyplata = 0;
            Console.WriteLine("Podaj kwotę wypłaty");
            if (decimal.TryParse(Console.ReadLine(), out wyplata))
            {
                if (kontoBankowe.Saldo < wyplata)
                {
                    Console.WriteLine("Masz za mało śrkó na koncie!");
                }
                else
                {
                    kontoBankowe.Wplac(wyplata);
                }
            }
            else
            {
                Console.WriteLine("Podano niepopawną kwotę.");
            }
        }
        private void PobierzDaneKonta()
        {
            string imie, nazwisko;
            Console.WriteLine("Podaj imię");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            nazwisko = Console.ReadLine();

            int pin = -1;
            while (true)
            {
                Console.WriteLine("Podaj PIN");
                if (int.TryParse(Console.ReadLine(), out pin) && pin > 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Pin niepoprawny. ");
                }
                kontoBankowe.UstawDaneWlasciciela(imie, nazwisko, pin);
            }
        }
    }
}
