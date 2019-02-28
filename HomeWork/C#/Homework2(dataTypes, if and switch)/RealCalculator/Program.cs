using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealCalculator
{
    class RealCalculator
    {
        /*  Create new console application “RealCalculator” that takes two numbers from the 
            input and asks what operation would the user want to be done ( +, - , * , / ). 
            Then it returns the result.

            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the Operation: +
 
            Expected Output:
            The result is: 25
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers");
            Console.Write("First Number = ");
            int inputNumber1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number = ");
            int inputNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the operation that you want to do ( +, - , * , / )");
            Console.Write("operation sign: ");
            char sign = char.Parse(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    Console.WriteLine(inputNumber1 + inputNumber2);
                    break;
                case '-':
                    Console.WriteLine(inputNumber1 - inputNumber2);
                    break;
                case '*':
                    Console.WriteLine(inputNumber1 * inputNumber2);
                    break;
                case '/':
                    Console.WriteLine(inputNumber1 / inputNumber2);
                    break;
                default:
                    Console.WriteLine("Please enter valid sign from  +, - , * , /  ");
                    break;
            }

            Console.ReadLine();
        }
    }
}
