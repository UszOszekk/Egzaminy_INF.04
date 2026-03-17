namespace INF._04_01_24._01_SG
{
    internal class Program
    {

        static string sprawdzPlec(string pesel)
        {
            if (int.Parse(pesel[9].ToString()) % 2 == 0)
            {
                return "K";
            }
            else
            {
                return "M";
            }
        }


        static bool sumaKontrolna(string pesel)
        {
            int S = 0;
            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            for(int i = 0; i < wagi.Length; i++)
            {
                S += int.Parse(pesel[i].ToString()) * wagi[i];
                
            }
            int M = S % 10;
         
            int R;
            if (M == 0)
                R = 0;
            else
                R = 10 - M;
         

            if (int.Parse(pesel[10].ToString()) == R)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            string pesel = "55030101193";

            Console.WriteLine("Podaj PESEL do sprawdzenia:");
            string peselPodany = Console.ReadLine();

            Console.WriteLine("Płeć: " + sprawdzPlec(peselPodany));
            Console.WriteLine("Czy suma kontrolna się zgadza? " + (sumaKontrolna(peselPodany) ? "Prawda" : "Fałsz"));

           

        }
    }
}
