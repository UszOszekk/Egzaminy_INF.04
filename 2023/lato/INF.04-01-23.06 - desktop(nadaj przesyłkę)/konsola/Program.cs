using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF._04_01_23._06_SG_Konsola_
{
    internal class Program
    {
        const int N = 100;
        static void sito(bool[] A) {
            for(int i = 2; i < Math.Sqrt(N); i++)
            {
                if (A[i] == true)
                {
                    for (int j = 2 * i; j < N; j += i)
                    {
                        A[j] = false;
                    }
                }
            }
        
        
        
        }

        static void Main(string[] args)
        {
            
            bool[] A = new bool[N];
            for(int i = 0; i < N; i++)
            {
                A[i] = true;
            }
            sito(A);

            for(int i = 2; i < N; i++)
            {
                if (A[i] == true)
                {
                    Console.Write(i +", ");
                }
            }
            Console.ReadLine();




        }
    }
}
