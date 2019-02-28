using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculate_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            Console.WriteLine("Please enter two numbers N=, x=");
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            BigInteger product = 1;
            BigInteger denominator = 1;
            BigInteger result;

            if (N >= K && 1 < N && N < 100 && 1 < K)
            {
                for (int i = K + 1; i <= N; i++)
                {
                    product *= i;

                }
                for (int i = 1; i <= N-K; i++)
                {
                    denominator *= i;

                }

                result = product / denominator;
                Console.WriteLine("the result is {0:F6}",result);

            }
            else
            {
                Console.WriteLine(" enter valid number");
            }
            }
             
        }
    }
}
