using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Kadry
    {
        List<Osoba> ListaPracownikow = new List<Osoba>();

        public void StartMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. Zatrudnij Pracownika");
                Console.WriteLine("2. Wyszukaj Pracownika");
                Console.WriteLine("3. Wyszukaj Pracowników");
                Console.WriteLine("4. Zmień Ardes");
                Console.WriteLine("5. Zmień Dane Osobowe");
                Console.WriteLine("6. Zmień Umowe");
                Console.WriteLine("7. Usuń Pracownika");

                opcja = Console.ReadKey(true).KeyChar;
                Console.Clear();
                switch (opcja)
                {
                    case '0':
                        Console.WriteLine("Do zobaczenia!");
                        break;
                    case '1':
                        ZatrudnijPracownika();
                        break;
                    case '2':
                        WyszukajPracownika();
                        break;
                    case '3':
                        WyszukajPracownikow();
                        break;
                    case '4':
                        ZmienAdres();
                        break;
                    case '5':
                        ZmienDaneOsobowe();
                        break;
                    case '6':
                        ZmienUmowe();
                        break;
                    case '7':
                        UsunPracownika();
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
        void ZatrudnijPracownika() 
        {
            Console.WriteLine("Podaj Imie");
            string Imie = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko");
            string Nazwisko = Console.ReadLine();
            Console.WriteLine("Numer Ewidencyjny");
            string NumerEwidencyjny = Console.ReadLine();
            Console.WriteLine("Adres: ");

            string Imie = Console.ReadLine();
            while (true)
            {
                DateTime TodayN = DateTime.Today; //aktualna data
                int day = int.Parse(TodayN.Day.ToString());
                int month = int.Parse(TodayN.Month.ToString());
                int year = int.Parse(TodayN.Year.ToString());
                Console.WriteLine("Podaj Dzień");
                int Dzien = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj Miesiąc");
                int Miesioc = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj Rok");
                int Rok = int.Parse(Console.ReadLine());
                if (Rok > year)
                {
                    Console.WriteLine("Podałeś zły rok/Przyszłość");
                    continue;
                }
                if (Rok == year && Miesioc > month)
                {
                    Console.WriteLine("Podałeś zły rok/Przyszłość");
                    continue;
                }
                if (Rok == year && Miesoc == month && Dzien > day)
                {
                    Console.WriteLine("Podałeś zły rok/Przyszłość");
                    continue;
                }
                else 
                {

                }

            }
        }
    }
}
