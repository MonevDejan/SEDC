using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculate_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers N=, x=");
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            decimal sum = 1;
            decimal factoriel =1;
            decimal denominator=1;

            if (N >= 2 && N <= 10 && x > 0.5 && x < 100)
            {

                for (int i = 1; i <= N; i++)
                {
                    factoriel *= i;
                    denominator *= (decimal)x; ;
                    sum += (factoriel / denominator);
                    
                }
                Console.WriteLine("{0:F35}",denominator);
                Console.WriteLine("{0:F5}", sum);
            }
            else
            {
                Console.WriteLine("PLease insert numbers from 2 to 10 for N and 0.5 to 100 for x");
            }

        }
    }
}
