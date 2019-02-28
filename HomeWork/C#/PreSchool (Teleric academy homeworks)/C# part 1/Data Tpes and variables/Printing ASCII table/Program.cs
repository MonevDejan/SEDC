using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_ASCII_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter<=126)
            {
                Console.Write("{0} ",(char)counter);
                counter++;
            }
            Console.Write("\n");
        }
    }
}
