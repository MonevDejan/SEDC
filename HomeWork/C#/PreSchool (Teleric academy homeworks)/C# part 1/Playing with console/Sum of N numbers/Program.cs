using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_N_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter valid integer number N=");
            int number = int.Parse(Console.ReadLine());
            double sum = 0;

            if ((number >= 1) && (number <= 200))
            {
                for (int i = 1; i <= number; i++)
                {
                    double read = double.Parse(Console.ReadLine());
                    sum += read;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }

        }
    }
}
