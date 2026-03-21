using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urzadzenia_konsolowa
{
    class Urzadzenie
    {
        public void wyswietlKomunikat(string komunikat)
        {
            Console.WriteLine(komunikat);
        }
    }

    class Pralka : Urzadzenie
    {
        private int nrProgramu = 0;
        public int ustawProgram(int program)
        {
            if (program > 12 || program < 1)
            {
                Console.WriteLine("Podano niepoprawny numer programu");
                nrProgramu = 0;
            }

            else
            {
                Console.WriteLine("Program zostal ustawiony");
                nrProgramu = program;
            }

            return nrProgramu;
        }
    }

    class Odkurzacz : Urzadzenie
    {
        private bool stanOdkurzacza = false;
        public void on()
        {
            if (!stanOdkurzacza)
            {
                stanOdkurzacza = true;
                wyswietlKomunikat("Odkurzacz wlaczono");
            }
        }
        public void off()
        {
            if (stanOdkurzacza)
            {
                stanOdkurzacza = false;
                wyswietlKomunikat("Odkurzacz wylaczono");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pralka pralka = new Pralka();
            Odkurzacz odkurzacz = new Odkurzacz();

            Console.WriteLine("Podaj numer prania 1..12");

            int nrProgramu = int.Parse(Console.ReadLine());

            pralka.ustawProgram(nrProgramu);

            odkurzacz.on();
            odkurzacz.on();
            odkurzacz.on();

            odkurzacz.wyswietlKomunikat("Odkurzacz wyladowal sie");

            odkurzacz.off();
        }
    }
}
