using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace N_th_bit
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine(sbyte.MaxValue);
            while (true)
            {
                Console.WriteLine("Please enter positive two numbers P= ; N= ;");
                string Read_number1 = Console.ReadLine();
                string Read_number2 = Console.ReadLine();
                BigInteger constrain = 1;
               // Console.WriteLine(constrain);
                BigInteger numberP;
                byte numberN;
                for (int i = 1; i < 56; i++)
                {
                    constrain *= 2;
                }

                if ((BigInteger.TryParse(Read_number1, out numberP)) && (byte.TryParse(Read_number2, out numberN)))
                {
                    if ((0 <= numberP) && (numberP <= constrain) && (0 <= numberN) && (numberN < 55))
                    {
                        Console.WriteLine((numberP & (1 << numberN)) >> numberN);
                    }
                    else
                    {
                        Console.WriteLine("PLease enter number for P from range 0 to {0}, and for N from range 0 to 55", constrain);
                    }

                }
                else
                {
                    Console.WriteLine("PLease enter a valid positive number");
                }
            }
        }
    }
}
