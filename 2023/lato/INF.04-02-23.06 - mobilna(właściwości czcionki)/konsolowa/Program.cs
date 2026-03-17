using System;

namespace INF._04_02_23._06_SG_kjonsola_
{
    internal class Program
    {

        public static void sortuj(int[] tablica)
        {
            for(int i = 0; i < tablica.Length; i++)
            {
                for(int j = i; j < tablica.Length; j++)
                {
                    if (tablica[i] > tablica[j])
                    {
                        int temp = tablica[i];
                        tablica[i] = tablica[j];
                        tablica[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Random losowanie = new Random();

            

            int[] tablicaLiczb = new int[100];

            for(int i = 0; i < tablicaLiczb.Length; i++)
            {
                int losowaLiczba = losowanie.Next(0, 1000);
                tablicaLiczb[i] = losowaLiczba;
            }
            Console.WriteLine("Tablica przed posortowaniem:");
            for (int i = 0; i < tablicaLiczb.Length; i++)
            {
                Console.Write(tablicaLiczb[i] + ", ");
            }
            sortuj(tablicaLiczb);
            Console.WriteLine("\nTablica PO posortowaniem:");
            for (int i = 0; i < tablicaLiczb.Length; i++)
            {
                Console.Write(tablicaLiczb[i] + ", ");
            }






            Console.ReadLine();
        }
    }
}
