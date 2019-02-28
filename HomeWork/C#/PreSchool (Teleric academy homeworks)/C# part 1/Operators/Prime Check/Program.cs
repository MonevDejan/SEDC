using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("PLease enter a valid number that is less or equal to 100");
                string NUmber = Console.ReadLine();
                int Prime;
                int counter1 = 0;

                if (int.TryParse(NUmber, out Prime) && (Prime < 100))
                {
                    for (int i = 2; i < Math.Abs(Prime); i++)
                    {
                        if (Prime % i == 0)
                        {
                            counter1++;
                            break;
                        }
                    }

                    Console.WriteLine(counter1 != 0 ? "false" : "True");
                }
                else
                {
                    Console.WriteLine("Please enter valid number smaler than 100!");
                }
            }
        }
    }
}
