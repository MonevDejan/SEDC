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
                long number;
                byte storep;
                byte storeq;
                byte numberOfBits;        
                long Bit1;
                long bit2;

                Console.Write("PLease enter positive number from 0 to {0} N= ", long.MaxValue);
                string Read_numbern = Console.ReadLine();
                Console.Write("PLease enter positive number from 0 to 32 p= ");
                string Read_numberp = Console.ReadLine();
                Console.Write("PLease enter positive number from 0 to 32 q= ");
                string Read_numberq = Console.ReadLine();
                Console.Write("PLease enter positive number from 0 to 32 k= ");
                string Read_numberk = Console.ReadLine();

                if (long.TryParse(Read_numbern, out number) && 
                    (byte.TryParse(Read_numberp, out storep)) &&
                    (byte.TryParse(Read_numberq, out storeq)) &&
                    (byte.TryParse(Read_numberk, out numberOfBits)))
                {
                    if ( (storep <=32) && (storeq <=32) && 
                        ((storep + numberOfBits-1) < 32) &&
                        ((storeq + numberOfBits - 1) < 32) &&
                        (numberOfBits <= (Math.Abs(storep-storeq))))
                    {
                        Console.WriteLine(number);
                        Console.WriteLine(Convert.ToString(number, 2));

                        for (int i = 0; i < numberOfBits; i++, storep++, storeq++)
                        {                           
                            Bit1 = number & (1<<storep);
                            Bit1 >>= storep; 
                            bit2 = number & (1<<storeq);
                            bit2 >>= storeq;
                            number &= ~(1 << storep);
                            number &= ~(1 << storeq);
                            number = number | (Bit1 << storeq);
                            number = number | (bit2 << storep);                            
                        }
                        Console.WriteLine(Convert.ToString(number, 2));
                        Console.WriteLine(number);
                    }
                }
                else  
                {
                    Console.Write("PLease enter positive valid number");
                }
            }
        }
    }
}
