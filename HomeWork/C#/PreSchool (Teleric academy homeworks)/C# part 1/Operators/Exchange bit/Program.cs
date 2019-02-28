using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                uint number;
                uint storage_number1 = 0;
                uint Storage_number2 = 0;
                string number_to_store345 =    "111000";
                string NUmber_to_store242526 = "111000000000000000000000000";
                uint position345 = Convert.ToUInt32(number_to_store345, 2);
                uint position242526 = Convert.ToUInt32(NUmber_to_store242526, 2);
                //Console.WriteLine(position345);
                //Console.WriteLine(position242526);
                Console.Write("PLease enter positive number from 0 to {0} N= ", uint.MaxValue);
                string Read_number = Console.ReadLine();

                if (uint.TryParse(Read_number, out number))
                {
                    Console.WriteLine(number);
                    Console.WriteLine(Convert.ToString(number, 2));
                    storage_number1 = number & position345;
                    Storage_number2 = number & position242526;
                    //Console.WriteLine(Convert.ToString (storage_number1, 2).PadLeft(31, '0'));
                    //Console.WriteLine(Convert.ToString(Storage_number2, 2).PadLeft(31, '0'));
                    number &= ~position345;
                    //Console.WriteLine(Convert.ToString(number, 2));
                    number &= ~position242526;
                    //Console.WriteLine(Convert.ToString(number, 2));
                    //Console.WriteLine(Convert.ToString(position345 << 21, 2));
                    number = number | (storage_number1 << 21);
                    //Console.WriteLine(Convert.ToString(number, 2));
                    number = number | (Storage_number2 >> 21);
                    Console.WriteLine(Convert.ToString(number, 2));
                    Console.WriteLine(number);
                }
                else
                {
                    Console.Write("PLease enter positive number from 0 to {0} N= ", uint.MaxValue);
                }
            }
        }
    }
}
