using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF._04_02_24._01_SG
{

    public class metodyNapisowe
    {


        public static int liczSamogloski(string tekst)
        {
            int licznik = 0;
            string[] samogloski = { "a", "ą", "e", "ę", "i", "o", "u", "ó", "y", "A", "Ą", "E", "Ę", "I", "O", "U", "Ó", "Y" };
           
            if(tekst == null || tekst == "")
            {
                return 0;
            }
            else
            {
                for(int i = 0; i < tekst.Length; i++)
                {
                    bool samogloska = false;
                    for(int j = 0; j < samogloski.Length; j++)
                    {
                        if (tekst[i].ToString() == samogloski[j])
                        {
                            samogloska = true;
                            break;
                        }
                    }
                    if(samogloska == true)
                    {
                        licznik++;
                    }

                }
            }
            return licznik;
        }
        public static string usunPowtorzenia(string tekst)
        {
            string tekstUsunietePowtorzenia = "";
            for(int i = 0; i < tekst.Length; i++)
            {
                for(int j = i+1; j < tekst.Length ; j++)
                {
                    if (tekst[i] == tekst[j])
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                tekstUsunietePowtorzenia += tekst[i];
            }

            return tekstUsunietePowtorzenia;

            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj łańcuch znaków");
            string tekstOdUsera = Console.ReadLine();
            Console.WriteLine("\n Samogłoski w łańcuchu znaków");
            Console.WriteLine(metodyNapisowe.liczSamogloski(tekstOdUsera));
            Console.WriteLine("\n Łańcuch znaków po usunięciu powtózeń");
            Console.WriteLine(metodyNapisowe.usunPowtorzenia(tekstOdUsera));
            Console.ReadLine();
        }
    }
}
