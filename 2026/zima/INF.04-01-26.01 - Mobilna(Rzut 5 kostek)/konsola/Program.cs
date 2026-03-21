using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace kosci_konsola
{
    public class Kosc
    {
        public static int ileKosci;
        public string[] kosciObrazy = {"kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };
        public int liczbaOczek;
        public int idObrazu;
        public bool czyDostepna = false;


        public Kosc()
        {
            Random random = new Random();
            int liczba = 0;
            liczba = random.Next(1, 7);

            liczbaOczek = liczba;
            idObrazu = liczba;
            czyDostepna = true;
            ileKosci++;

        }
        public Kosc(int wartosc)
        {
            if(wartosc > 6 || wartosc < 1)
            {
                wartosc = 0;
            }

            liczbaOczek = wartosc;
            idObrazu = wartosc;
            czyDostepna = true;
            ileKosci++;
        }

        public void rzucKoscia()
        {
            if (czyDostepna)
            {
                Random random = new Random();
                int wartosc = random.Next(1, 7);

                liczbaOczek = wartosc;
                idObrazu = wartosc;
            }
        }

        public void blokujKosc()
        {
            czyDostepna = false;
        }

        public string wyswietlWartosc()
        {
            string wartosc;
            switch(liczbaOczek)
            {
                case 1:
                    wartosc = "jeden";
                    return wartosc;

                case 2:
                    wartosc = "dwa";
                    return wartosc;

                case 3:
                    wartosc = "trzy";
                    return wartosc;

                case 4:
                    wartosc = "cztery";
                    return wartosc;

                case 5:
                    wartosc = "piec";
                    return wartosc;

                case 6:
                    wartosc = "szesc";
                    return wartosc;

                default:
                    return "zero";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Utworzono kosc1 z konstruktorem bezparametrowym");
            Kosc kosc1 = new Kosc();

            Console.WriteLine("Wpisz argument kosci (1-6):");
            int wartosc = int.Parse(Console.ReadLine());
            Kosc kosc2 = new Kosc(wartosc);
            Console.WriteLine("Utworzono kosc2 z konstruktorem z parametrem\n");

            Console.WriteLine($"KOSC 1:\nLiczba instancji klasy: {Kosc.ileKosci}; Ile oczek: {kosc1.liczbaOczek} - {kosc1.wyswietlWartosc()}; Nazwa pliku: {kosc1.kosciObrazy[kosc1.idObrazu]}");
            Console.WriteLine($"KOSC 2:\nLiczba instancji klasy: {Kosc.ileKosci}; Ile oczek: {kosc2.liczbaOczek} - {kosc2.wyswietlWartosc()}; Nazwa pliku: {kosc2.kosciObrazy[kosc2.idObrazu]}");

        }
    }
}
