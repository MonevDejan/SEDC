using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine("PLease enter positie number smaler than {0} n=", uint.MaxValue);
            string Read_number = Console.ReadLine();
            uint number;
            if (uint.TryParse(Read_number, out number))
            {
                Console.WriteLine(Convert.ToString(number, 2));
                Console.WriteLine(Convert.ToString(1<<3, 2));
                Console.WriteLine(Convert.ToString(((number & (1 << 3))>>3), 2));
 
            }
            else
            {
                Console.WriteLine("please enter valid positive whole number");
            }
            
        }
    }
}
