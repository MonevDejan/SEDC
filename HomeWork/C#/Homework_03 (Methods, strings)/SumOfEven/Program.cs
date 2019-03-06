using System;


namespace SumOfEven
{
    /*
        Make a console application called SumOfEven. 
        Inside it create an array of 6 integers. 
        Get numbers from the input, find and print the sum of the even numbers from the array:
        Test Data:
        Enter integer no.1:
        4
        Enter integer no.1:
        3
        Enter integer no.1:
        7
        Enter integer no.1:
        3
        Enter integer no.1:
        2
        Enter integer no.1:
        8
 
        Expected Output:
        The result is: 14
     */

    class Program
    {
        // To check if the input can be converted to int
        static int StringToInt ()
        {
            int randomNumber = 0;
            bool check = int.TryParse(Console.ReadLine(), out randomNumber);

            if (!check)
            {
                Console.WriteLine("Please enter valid number");
                StringToInt();
            }
            return randomNumber;
        }

        // To read all values in the array
        static int[] ReadNumbers(int numbersToRead)
        {
            int[] numbersArray = new int[numbersToRead];
            for (int i = 0; i < numbersToRead; i++)
            {
                Console.Write($"Please enter number {i+1} = ");
                numbersArray[i] = StringToInt();
            }
            return numbersArray;
        }

        // To sum the even numbers
        static int SumOfEven(int [] randomArray)
        {
            int sum = 0;

            foreach (int element in randomArray)
            {
                if ((element & 1) == 0)
                {
                    sum += element;
                }
            }
            return sum;
        }

        static void Main()
        {
            Console.Write("Please enter how many numbers will be in the array. N = ");
            int lenghtOfArray = StringToInt();
            int[] arrayToSum = ReadNumbers(lenghtOfArray);

            Console.WriteLine($"The sum of even numbers in the array is {SumOfEven(arrayToSum)}");
            Console.WriteLine("");
            Main();
        }
    }
}
