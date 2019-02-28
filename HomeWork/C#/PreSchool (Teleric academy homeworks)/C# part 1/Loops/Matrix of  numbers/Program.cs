using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of__numbers
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter two numbers N=");
            int N = int.Parse(Console.ReadLine());

            if (1 <= N && N <= 20)
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= N; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Uhh Ohh");
            }
        }
    }
}
