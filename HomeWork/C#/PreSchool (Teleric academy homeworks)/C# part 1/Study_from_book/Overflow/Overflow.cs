using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Overflow
    {
        static void Main(string[] args)
        {
            int test_number = int.MaxValue;
            Console.WriteLine(checked(test_number + ( test_number)));
        }
    }
}
