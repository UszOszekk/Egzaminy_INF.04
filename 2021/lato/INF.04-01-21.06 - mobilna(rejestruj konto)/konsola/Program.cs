namespace Inf._04_01_21._06_SG_konsola_
{

    class Table
    {
        private int[] tab = new int[10];

        public Table()
        {
            for (int i = 0; i < 10; i++)
            {
                tab[i] = 0;
            }
        }
        public void FillTab()
        {
            int i = 0;
            while (i < 10)
            {
                Console.Write($"Podaj {i + 1} liczbe: ");
                tab[i] = int.Parse(Console.ReadLine());
                i++;
            }

            sortTab();
        }

        public void showTab()
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tab[j] + ", ");
            }
        }

        public void sortTab()
        {
            int max = 0;

            for (int i = 0; i < 10; i++)
            {
                max = i;
                for (int j = i; j < 10; j++)
                {
                    if (tab[j] > tab[max])
                    {
                        max = j;
                    }
                }

                int temp;
                temp = tab[i];
                tab[i] = tab[max];
                tab[max] = temp;
            }
        }
        private int searchMaxNumber()
        {
            int max = tab[0];
            for (int i = 0; i < 10; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }

            return max;
        }

        public void showMax()
        {
            Console.WriteLine(searchMaxNumber());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();

            table.FillTab();
            table.showTab();

            Console.WriteLine();

            table.showMax();
        }
    }
}