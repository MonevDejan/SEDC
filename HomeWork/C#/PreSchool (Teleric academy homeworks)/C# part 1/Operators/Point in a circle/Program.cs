using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please enter coordinates X and Y from interavl of -1000 to 1000");
                string Xcoordinate = Console.ReadLine();
                string Ycoordinate = Console.ReadLine();
                double x;
                double y;

                if ((double.TryParse(Xcoordinate, out x)) && double.TryParse(Ycoordinate, out y))
                {
                    if (((x < 1000) && (y < 1000)) && ((x > -1000) && (y > -1000)))
                    {
                        Console.WriteLine((x * x) + (y * y) <= 2 ? "Yes {0 : 0.00} " : "No {0 : 0.00}", (x * x) + (y * y));
                    }
                    else
                    {
                        Console.WriteLine("PLease enter numbers in range of -1000 to 1000");
                    }

                }
                else
                {
                    Console.WriteLine("Pleae enter a valid number");
                }
            }
        }
    }
}
