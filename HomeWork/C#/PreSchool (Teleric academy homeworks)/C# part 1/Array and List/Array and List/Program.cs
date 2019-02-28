using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allocate_array
{
    class Program
    {
        static void Main()
        {

            /* Write a program that allocates array of N integers, 
               initializes each element by its index multiplied by 5 and the prints the obtained array on the console. 
             
               1 <= N <= 20
               N will always be a valid integer number        
             */

            Console.WriteLine("Enter the size of the array, N= ");
            int N = int.Parse(Console.ReadLine());
            int[] Array = new int[N];


            if (1 <= N && N <= 20)
            {

                    for (int i = 0; i < N; i++)
                {
                    Array[i] = i;
                    Console.WriteLine(Array[i]*5);
                }

            }
            else
            {
                Console.WriteLine("Uhh Ohh");
            }
        }
    }
}
