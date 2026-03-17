using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Osoba
    {
        private int id;
        private string imie;

        public static int liczbaInstancji = 0;

        public Osoba()
        {
            id = 0;
            imie = string.Empty;
            liczbaInstancji++;
        }

        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            liczbaInstancji++;
        }

        public Osoba(Osoba innaOsoba)
        {
            id = innaOsoba.id;
            imie = innaOsoba.imie;

            liczbaInstancji++;
        }

        public void WypiszImie(string inneImie)
        {
            if (string.IsNullOrWhiteSpace(imie))
            {
                Console.WriteLine("Brak danych");
                return;
            }

            Console.WriteLine($"Cześć {inneImie}, mam na imię {imie}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.liczbaInstancji}");

            Osoba osoba1 = new Osoba();

            Console.Write("Podaj id osoby: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Podaj imię osoby: ");
            string imie = Console.ReadLine();

            Osoba osoba2 = new Osoba(id, imie);
            Osoba osoba3 = new Osoba(osoba2);

            osoba1.WypiszImie("Jan");
            osoba2.WypiszImie("Jan");
            osoba3.WypiszImie("Jan");

            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.liczbaInstancji}");
            Console.ReadLine();
        }
    }
}
