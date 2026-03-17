using System;

namespace ConsoleApp2
{
    internal class Program
    {
       
        static void WypelnijLosowania(int[,] tablicaLosowania, int liczbaLosowan)
        {
            Random generator = new Random();

            for (int i = 0; i < liczbaLosowan; i++)
            {
                int[] wylosowaneLiczby = new int[6];
                int indeks = 0;

                while (indeks < 6)
                {
                    int losowaLiczba = generator.Next(1, 50); 
                    bool czyIstnieje = false;

             
                    for (int j = 0; j < indeks; j++)
                    {
                        if (wylosowaneLiczby[j] == losowaLiczba)
                        {
                            czyIstnieje = true;
                            break;
                        }
                    }

           
                    if (!czyIstnieje)
                    {
                        wylosowaneLiczby[indeks] = losowaLiczba;
                        tablicaLosowania[i, indeks] = losowaLiczba;
                        indeks++;
                    }
                }
            }
        }


        static void WyswietlWyniki(int[,] tablicaLosowania, int liczbaLosowan)
        {
            Console.WriteLine("\nZestawy wylosowanych liczb:");
            for (int i = 0; i < liczbaLosowan; i++)
            {
                Console.Write($"Losowanie {i + 1}: ");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(tablicaLosowania[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ile wygenerować losowań? ");
            int liczbaLosowan = int.Parse(Console.ReadLine());

            
            int[,] tablicaLosowania = new int[liczbaLosowan, 6];

         
            WypelnijLosowania(tablicaLosowania, liczbaLosowan);

            WyswietlWyniki(tablicaLosowania, liczbaLosowan);

            int[] wystapienia = new int[49];

            for (int i = 0; i < liczbaLosowan; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int liczba = tablicaLosowania[i, j];
                    wystapienia[liczba - 1]++;
                }
            }

            Console.WriteLine("\nWystąpienia poszczególnych liczb:");
            for (int i = 0; i < wystapienia.Length; i++)
            {
                Console.WriteLine($"Liczba {i + 1}: {wystapienia[i]} razy");
            }
        }
    }
}