using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class AverageNumber
    {
        /*
            Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the third number: 20
            Enter the fourth number: 30
 
            Expected Output:
            The average of 10, 15, 20 and 30 is: 18

 *         */
        static void Main(string[] args)
        {
            Console.Write("Enter for how many numbers do you want to find average N=");
            int numberOfelements = int.Parse(Console.ReadLine());
            double sum = 0;

            if ((numberOfelements >= 1))
            {
                Console.WriteLine("Please enter the numbers");
                for (int i = 1; i <= numberOfelements; i++)
                {
                    Console.Write($"Nuber{i}= ");
                    double read = double.Parse(Console.ReadLine());
                    sum += read;
                }

                Console.WriteLine(sum/ numberOfelements);
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }
            Console.ReadLine();
        }
    }
}
