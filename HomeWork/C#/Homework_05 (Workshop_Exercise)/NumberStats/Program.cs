using System;

namespace NumberStats
{
        /*
           Create a method called NumberStats that accepts a number. This method should:
           Find out if the number is negative or positive
           Find out if the number is odd or even
           Find out if the number is decimal or integer
           After finding all the stats it should print them like this: 
           Stats for number: 
           25 
           Positive
           Integer 
           Odd

           The number should be entered in the console by the user. 
           Bonus: Validate if the user is entering a number 
           Bonus: Ask the user to press Y to try again or X to exit
        */
    class Program
    {
        public static double StringToDouble()
        {
            double randomNumber;
            bool check = double.TryParse(Console.ReadLine(), out randomNumber);

            if (!check)
            {
                Console.WriteLine("Please enter valid number");
                randomNumber = StringToDouble();
            }
            return randomNumber;
        }

        public static void CheckSign(double number)
        {
            if (number >= 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
        }


        public static void CheckType(string number)
        {

            int randomNumber;
            bool check = int.TryParse(number, out randomNumber);

            if (check)
            {
                Console.WriteLine("Number is Integer");
                EvenOdd(randomNumber);
            }
            else
            {
                Console.WriteLine("Number is double");
            }
        }

        public static void EvenOdd(int number)
        {
            if ((number & 1) == 1)
            {
                Console.WriteLine("Number is odd");
            }
            else
            {
                Console.WriteLine("Number is even");
            }
        }

        public static bool RunAgain()
        {
            bool check;

            string input = Console.ReadLine();

            if (input == "Y" || input == "y")
            {
                check = true;
            }
            else if (input == "N" || input == "n")
            {
                check = false;
            }
            else
            {
                Console.WriteLine("Please enter Y or N");
                check = RunAgain();
            }
            return check;
        }

        static void Main(string[] args)
        {
            bool RunProgram = true;
            do
            {
                Console.Write("Please enter random number N= ");
                double inputNumber = StringToDouble();
                Console.WriteLine(inputNumber);
                CheckSign(inputNumber);
                CheckType(Convert.ToString(inputNumber));
                Console.WriteLine("________________________________________");
                Console.WriteLine("Do you want to chek another number Y/N ");
                RunProgram = RunAgain();

            } while (RunProgram);

        }
    }
}
