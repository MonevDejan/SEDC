using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculate_again
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers N=, K=");
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            BigInteger factoriel_N = 1;

            if (N>=K && 1<N && N<100 && 1 < K)
            {

                for (int i = K+1; i <=N; i++)
                {
                   factoriel_N *= i;

                }
                Console.WriteLine(factoriel_N);
            }
            else
            {
                Console.WriteLine(" enter valid number");
            }
            
            
            

        }
    }
}
