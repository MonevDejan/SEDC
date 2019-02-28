using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    class Program
    {
        //Write a program that finds all prime numbers in the range [1 ... N]. 
        //Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.

        static void Main()
        {
            Console.WriteLine("Please enter number N= ");
            int N = int.Parse(Console.ReadLine());
            int max = 2;
            List<int> list = new List<int> { 2 };
            

            if ((N>= 2) && (N<= 10000000))
            {
                for (int i = 2; i <= N; i++)
                {
                    bool check = true;
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (i % list[j] == 0)
                        {
                            check = false;
                            break;
                        }
                    }

                    if (check)
                    {
                        max = i;
                        list.Add(i);
                    }
                }
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine("Uh ohh");
            }
            Main();
        }
    }
}
