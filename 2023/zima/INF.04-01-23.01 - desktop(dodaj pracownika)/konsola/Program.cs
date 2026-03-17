using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euklides_konsolowa
{
    internal class Program
    {

        //**********************************************
        //nazwa funkcji: obliczNWD
        //opis funkcji: funkcja pobiera dwie liczby calkowite dodatnie nastepnie oblicza za pomoca algorytmu euklidesa najwiekszy wspolny dzielnik dwoch liczb
        //parametry: a - pierwsza liczba calkowita dodatnia
        //           b - druga liczba calkowita dodatnia
        //zwracany typ i opis: typ int - funkcja zwraca najwiekszy wspolny dzielnik liczb a i b
        //autor: AUTOR
        //***********************************************
        public static int obliczNWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }

                else
                {
                    b -= a;
                }
            }

            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("Wpisz pierwsza liczbe dodatnia: ");
            int liczba1 = int.Parse(Console.ReadLine());

            Console.Write("Wpisz druga liczbe dodatnia: ");
            int liczba2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (liczba1 < 0 || liczba2 < 0)
            {
                Console.WriteLine("Niepoprawne liczby");
            }

            else
            {
                Console.WriteLine($"NWD liczb {liczba1} i {liczba2} wynosi: {obliczNWD(liczba1, liczba2)}");
            }

        }
    }
}
