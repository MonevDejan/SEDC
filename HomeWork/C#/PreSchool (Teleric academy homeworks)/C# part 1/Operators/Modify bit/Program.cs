using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modify_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            uint number;
            byte position;
            byte bit;

            while (true)
            {
                Console.WriteLine("Enter three numbers (N-number, P-position for bit, v-bit value)");
                Console.Write("N=");
                string Number_Read = Console.ReadLine();
                Console.Write("P=");
                string POsition_read = Console.ReadLine();
                Console.Write("v=");
                string bit_Read = Console.ReadLine();

                if ((uint.TryParse(Number_Read, out number)) && (byte.TryParse(POsition_read, out position)) && (byte.TryParse(bit_Read, out bit)))
                {
                    if (((position >= 0) && (position < 64)) && ((bit == 0) || (bit == 1)))
                    {
                        Console.WriteLine(Convert.ToString(number, 2));
                        Console.WriteLine(bit == 1 ? Convert.ToString((number | ((long)1 << position)), 2) : Convert.ToString((number ^ (1 << position)), 2));
                    }
                    else
                    {
                        Console.WriteLine("PLease enter number for N form range 0 to {0}, for P from range 0 to 64 and for v 0 or 1", uint.MaxValue);
                        
                    }
                }
                else
                {
                    Console.WriteLine("PLease enter number for N form range 0 to {0}, for P from range 0 to 64 and for v 0 or 1", uint.MaxValue);
                }
            }
        }
    }
}
