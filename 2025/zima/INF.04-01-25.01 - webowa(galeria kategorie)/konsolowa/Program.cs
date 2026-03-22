using System;

namespace ConsoleApp5
{

    class Liczby
    {
        private int[] tablica;
        private int liczbaElementow;

        public Liczby(int rozmiarTablicy)
        {
            liczbaElementow = rozmiarTablicy;
            tablica = new int[liczbaElementow];
            Random generator = new Random();

            for (int i = 0; i < liczbaElementow; i++)
            {
                int losowaLiczba = generator.Next(1, 1001);
                tablica[i] = losowaLiczba;
            }
        }

        public void WyswietlWszystkieElementy()
        {
            for (int i = 0; i < liczbaElementow; i++)
            {
                Console.WriteLine(i + ": " + tablica[i]);
            }
        }


        public int ZnajdzPierwszeWystapienie(int wartosc)
        {
            for (int i = 0; i < liczbaElementow; i++)
            {
                if (tablica[i] == wartosc)
                {
                    return i;
                }
            }

            return -1;
        }

        public int WyswietlNieparzysteIZwrocLiczbe()
        {
            int licznikNieparzystych = 0;

            for (int i = 0; i < liczbaElementow; i++)
            {
                if (tablica[i] % 2 != 0)
                {
                    Console.WriteLine(tablica[i]);
                    licznikNieparzystych++;
                }
            }

            return licznikNieparzystych;
        }

        public double ObliczSredniaArytmetyczna()
        {
            int suma = 0;

            for (int i = 0; i < liczbaElementow; i++)
            {
                suma += tablica[i];
            }

            return (double)suma / liczbaElementow;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            const int rozmiarTablicy = 69;
            Liczby liczby = new Liczby(rozmiarTablicy);

            Console.WriteLine("Wszystkie elementy tablicy:");
            liczby.WyswietlWszystkieElementy();
          
            int indeks = liczby.ZnajdzPierwszeWystapienie(556);
            if (indeks != -1)
            {
                Console.WriteLine("Wyszukana wartosc znajduje sie pod indeksem: " + indeks);
            }

            Console.WriteLine();
            Console.WriteLine("Wartosci nieparzyste z tablicy:");
            int liczbaNieparzystych = liczby.WyswietlNieparzysteIZwrocLiczbe();
            Console.WriteLine("Razem nieparzystych: " + liczbaNieparzystych);

            Console.WriteLine();
            double srednia = liczby.ObliczSredniaArytmetyczna();
            Console.WriteLine("Srednia wszystkich elementow: " + srednia.ToString("F2"));
        }
    }
}
