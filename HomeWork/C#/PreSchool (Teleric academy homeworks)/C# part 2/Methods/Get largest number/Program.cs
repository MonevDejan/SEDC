using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_largest_number
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            int max = a;
            if (b>=a)
            {
                max = b;
            }
            return max;
        }
        static void Main()
        {
            Console.WriteLine("PLease insert 3 integer numbers");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The max numver is {0}", GetMax((GetMax(number1, number2)), number3));
            Main();
        }
    }
}
