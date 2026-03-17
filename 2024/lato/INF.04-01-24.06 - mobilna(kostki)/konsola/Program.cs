using System;

namespace kosci_konsolowa
{
    internal class Program
    {
        static Random random = new Random();

        public static int pobierzLiczbeKostek()
        {
            int n;
            do
            {
                Console.Write("Podaj liczbe kostek (3-10): ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 3 || n > 10);

            return n;
        }

        public static int[] losujKostki(int liczbaKostek)
        {
            int[] wyniki = new int[liczbaKostek];

            for (int i = 0; i < liczbaKostek; i++)
            {
                wyniki[i] = random.Next(1, 7);
            }

            return wyniki;
        }

        public static int liczPunkty(int[] wyniki)
        {
            int punkty = 0;

            int[] licznik = new int[7];

            for (int i = 0; i < wyniki.Length; i++)
            {
                licznik[wyniki[i]]++;
            }

            for (int i = 1; i <= 6; i++)
            {
                if (licznik[i] >= 2)
                {
                    punkty += i * licznik[i];
                }
            }

            return punkty;
        }

        static void Main(string[] args)
        {
            int liczbaKostek = pobierzLiczbeKostek();
            char wybor;

            do
            {
                int[] wyniki = losujKostki(liczbaKostek);

                for (int i = 0; i < wyniki.Length; i++)
                {
                    Console.WriteLine($"Kostka {i + 1}: {wyniki[i]}");
                }

                int punkty = liczPunkty(wyniki);
                Console.WriteLine($"Liczba punktów: {punkty}");

                Console.Write("Czy powtórzyć grę? (t/n): ");
                wybor = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (wybor == 't');
        }
    }
}