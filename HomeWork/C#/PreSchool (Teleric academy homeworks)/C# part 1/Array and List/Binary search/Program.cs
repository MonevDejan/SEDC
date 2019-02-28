using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class Program
    {
        static void Main()
        {
            /*Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm
             1 <= N <= 1024
             */

            Console.WriteLine("Enter the size of the array, N= ");
            int N = int.Parse(Console.ReadLine());            
            bool check = false;
            int index = N-1;

            if (1 <= N && N <= 1024)
            {
                int[] sequence = new int[N];
                Console.WriteLine("Enter the values in the array");
                for (int i = 0; i < N; i++)
                {
                    sequence[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the value that you want to know the index");
                int value = int.Parse(Console.ReadLine());

                // Check if the value exist in the array
                for (int i = 0; i < N; i++)
                {
                    if (sequence[i] == value)
                    {
                        check = true;
                        break;
                    }
                }
                //We use algoritham binary search
                if (check == true)
                {
                    for (int i = 0; i < N; i++)
                    {
                        if (sequence[index] > value)
                        {
                            index /= 2;
                        }
                        else if (sequence[index] < value)
                        {
                            index = (index + (N -1))/ 2;
                        }
                        else
                        {
                            Console.WriteLine(index);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
            else
            {
                Console.WriteLine("YOU ARE DOOMED!!!");
            }

        }
    }
}
