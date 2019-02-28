using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class SwapNumbers
    {
        /*
            Create new console application “SwapNumbers”.
            Input 2 numbers from the console and then swap the values of the 
            variables so that the first variable has the 
            second value and the second variable the first value.
            Please find example below:

            Test Data:
            Input the First Number: 5
            Input the Second Number: 8
 
            Expected Output:
            After Swapping:
            First Number: 8
            Second Number: 5
        */
      
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers");
            Console.Write("First Number = ");
            int inputNumber1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number = ");
            int inputNumber2 = int.Parse(Console.ReadLine());

            if (inputNumber1 == inputNumber2)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                // this works only for whole numbers
                inputNumber1 ^= inputNumber2;
                inputNumber2 ^= inputNumber1;
                inputNumber1 ^= inputNumber2;

                Console.WriteLine($"After swaping First Number = {inputNumber1}, and Second Number {inputNumber2}");
            }
            
            Console.ReadLine();

        }
    }
}
