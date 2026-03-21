using System;

namespace ConsoleApp4
{    public abstract class Pytanie
    {
        protected string trescPytania;
        protected string nazwaPlikuZdjecia;
        protected bool czyOdpowiedzPoprawna;

        protected Pytanie(string trescPytania, string nazwaPlikuZdjecia)
        {
            this.trescPytania = trescPytania;
            this.nazwaPlikuZdjecia = nazwaPlikuZdjecia;
            this.czyOdpowiedzPoprawna = false;
        }

        public abstract bool SprawdzOdpowiedz(char odpowiedz);
    }

    public class PytanieZamkniete : Pytanie
    {
        private string odpowiedzA;
        private string odpowiedzB;
        private string odpowiedzC;
        private char poprawnaOdpowiedz;

        public PytanieZamkniete(
            string trescPytania,
            string nazwaPlikuZdjecia,
            string odpowiedzA,
            string odpowiedzB,
            string odpowiedzC,
            char poprawnaOdpowiedz)
            : base(trescPytania, nazwaPlikuZdjecia)
        {
            this.odpowiedzA = odpowiedzA;
            this.odpowiedzB = odpowiedzB;
            this.odpowiedzC = odpowiedzC;
            this.poprawnaOdpowiedz = char.ToUpper(poprawnaOdpowiedz);
        }

        public override bool SprawdzOdpowiedz(char odpowiedz)
        {
            char odpowiedzUzytkownika = char.ToUpper(odpowiedz);
            czyOdpowiedzPoprawna = odpowiedzUzytkownika == poprawnaOdpowiedz;
            return czyOdpowiedzPoprawna;
        }

    }

    public class Program
    {
        public static void Main()
        {
            Console.Write("Podaj treść pytania: ");
            string trescPytania = Console.ReadLine();

            Console.Write("Podaj nazwę pliku ze zdjęciem: ");
            string nazwaPlikuZdjecia = Console.ReadLine();

            Console.Write("Podaj treść odpowiedzi A: ");
            string odpowiedzA = Console.ReadLine();

            Console.Write("Podaj treść odpowiedzi B: ");
            string odpowiedzB = Console.ReadLine();

            Console.Write("Podaj treść odpowiedzi C: ");
            string odpowiedzC = Console.ReadLine();

            Console.Write("Podaj poprawną odpowiedź (A/B/C): ");
            string poprawna = Console.ReadLine();
            char poprawnaOdpowiedz = char.ToUpper(poprawna[0]);

            PytanieZamkniete pytanie = new PytanieZamkniete(
                trescPytania,
                nazwaPlikuZdjecia,
                odpowiedzA,
                odpowiedzB,
                odpowiedzC,
                poprawnaOdpowiedz);

            Console.Write("Wpisz odpowiedź na pytanie (A/B/C): ");
            string odpowiedzUzytkownikaTekst = Console.ReadLine();
            char odpowiedzUzytkownika = char.ToUpper(odpowiedzUzytkownikaTekst[0]);

            bool czyPoprawna = pytanie.SprawdzOdpowiedz(odpowiedzUzytkownika);
            Console.WriteLine(czyPoprawna ? "Odpowiedź prawidłowa" : "Odpowiedź nieprawidłowa");
        }
    }
}
