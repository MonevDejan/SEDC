using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSA_of_N_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleae enter how many numbers you will need to enter from the console");
            int n = int.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;
            double average;
            double sum = 0;
            if (n>=1)
            {
                for (int i = 0; i < n; i++)
                {
                    double k = double.Parse(Console.ReadLine());
                    sum += k;
                    if (k <= min)
                    {
                        min = k;
                    }
                    if (k>= max)
                    {
                        max = k;
                    }

                }
                average = sum / n;
                Console.WriteLine("{0:F2}, {1:F2}, {2:F2}, {3:F2}",min,max,sum, average);
            }
            else
            {
                Console.WriteLine("Please enter positive number");
            }
        }
    }
}
