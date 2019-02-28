using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_3_numbers
{
    class Program
    {
        static void Main()
        {
            while (true)
            {

                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());
                double number3 = double.Parse(Console.ReadLine());

                if (number1 <= number2)
                {
                    if (number1 <= number3)
                    {
                        if (number2 <= number3)
                        {
                            Console.WriteLine("{0}, {1}, {2}", number3, number2, number1);
                        }
                        else
                        {
                            Console.WriteLine("{0}, {1}, {2}", number2, number3, number1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0}, {1}, {2}", number2, number1, number3);
                    }
                }
                else
                {
                    if (number1 <= number3)
                    {
                        Console.WriteLine("{0}, {1}, {2}", number3, number1, number2);
                    }
                    else
                    {
                        if (number2 <= number3)
                        {
                            Console.WriteLine("{0}, {1}, {2}", number1, number3, number2);
                        }
                        else
                        {
                            Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);
                        }
                    }
                }
            }
        }
    }
}
