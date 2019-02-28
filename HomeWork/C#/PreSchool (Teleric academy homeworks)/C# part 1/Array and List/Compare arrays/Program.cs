using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_arrays
{
    class Program
    {
        static void Main()
        {

            /* Write a program that reads two integer arrays of size N from the console and compares them element by element.
             * 
             * 1 <= N <= 20    N will always be a valid integer number */

            Console.WriteLine("Enter the size of the two array, N= ");
            int N = int.Parse(Console.ReadLine());
            
            int[] Array1 = new int[N];
            int[] Array2 = new int[N];
            bool counter = true;

            if (1 <= N && N <= 20)
            {
                Console.WriteLine("Enter the value of the elemnts in the first array");
                for (int i = 0; i < N; i++)
                {
                    Array1[i] =int.Parse( Console.ReadLine());
                }

                Console.WriteLine("Enter the value of the elemnts in the second array");
                for (int i = 0; i < N; i++)
                {
                    Array2[i] = int.Parse(Console.ReadLine());
                }


                for (int i = 0; i < N; i++)
                {
                    if (Array1[i] != Array2[i] )
                    {
                        counter = false;
                        break;
                    }
                    
                }
                Console.WriteLine( counter == true ? "Equal" : "Not equal");

            }
            else
            {
                Console.WriteLine("Uhh Ohh");
            }

        }
    }
}
