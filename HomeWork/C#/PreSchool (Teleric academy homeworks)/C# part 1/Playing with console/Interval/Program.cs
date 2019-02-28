using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please insert number N and M. N should be smaller than M");
                int N = int.Parse(Console.ReadLine());
                int M = int.Parse(Console.ReadLine());
                int counter = 0;

                if ((N>=0) && (N<=M) && (M >= 0) && (M <= 2000))
                {
                    for (int i = N+1; i < M; i++)
                    {
                        if (i%5 == 0)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }

        }
    }
}
