using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_number_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter <= 100)
            {
                if ((counter & 1) == 0)
                {
                    Console.WriteLine(counter);
                    counter++;
                }
                else
                {
                    Console.WriteLine(counter * (-1));
                    counter++;
                }
            }
        }
    }

}
