using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace szyfr_konsola
{
    public class Program
    {
        public static string szyfrujTekst(string tekst, int klucz)
        {
            string zaszyfrowanyTekst = "";

            foreach (char znak in tekst)
            {

                if (znak >= 'a' && znak <= 'z')
                {
                    char zaszyfrowany = (char)('a' + (znak - 'a' + klucz + 26) % 26);
                    zaszyfrowanyTekst += zaszyfrowany;
                }

                else
                {
                    zaszyfrowanyTekst += znak;
                }
            }

            return zaszyfrowanyTekst;
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj tekst: ");
            string tekst = Console.ReadLine();

            Console.Write("Podaj klucz: ");
            int klucz = int.Parse(Console.ReadLine());

            string zaszyfrowany = szyfrujTekst(tekst, klucz);
            Console.WriteLine("Tekst zaszyfrowany: " + zaszyfrowany);
        }
    }
}
