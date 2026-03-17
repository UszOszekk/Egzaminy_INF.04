using System;

namespace INF._04_02_23._01_SG
{

/************************************************
 klasa: notatka
 opis: ta klasa reprezentuje notatkę która zawiera treść i tytuł oraz posiada id
 pola: liczbaNotatek - całkowita liczba która przechowuje liczbę notatek które zostały utworzone za pomocą tej klasy
 id - całkowita liczba przechowuje unikalne id dla każdej z notatek
 tytul - napis który przechowuje tytuł notatki
 tresc - napis który przechowuje treść notatki
 autor: mati67
************************************************/
    public class notatka {
        private static int liczbaNotatek = 0;
        private int id;
        protected string tytul;
        protected string tresc;

        public notatka(string tytul, string tresc)
        {
            liczbaNotatek++;
            this.id = liczbaNotatek;
            this.tytul = tytul;
            this.tresc = tresc;
        }


        public void wyswietlTekstNotatki()
        {
            Console.WriteLine("Treść notatki:");
            Console.WriteLine("Tytuł: " + tytul + " Treść: " + tresc);
        }

        public void wypiszDaneNotatki() {
            Console.WriteLine("Dane notatki:");
            Console.WriteLine("Liczba Notatek:" + liczbaNotatek + ";id:" + id + ";tytuł:" + tytul + ";treść:" + tresc);
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string tytulNotatka1 = "Ala ma Kota";
            string trescNotatka1 = "A kot ma Ale i Psa Aleksa";
            string tytulNotatka2 = "Lorem ipsum";
            string trescNotatka2 = "Lorem ipsum sir amet dolor";
            notatka notatka1 = new notatka(tytulNotatka1, trescNotatka1);
            notatka1.wyswietlTekstNotatki();
            notatka1.wypiszDaneNotatki();
            notatka notatka2 = new notatka(tytulNotatka2, trescNotatka2);
            notatka2.wyswietlTekstNotatki();
            notatka2.wypiszDaneNotatki();

            Console.ReadLine();
        }
    }
}
