using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 500; i++)
            {
                char a = (char)i;
                Console.Write("{0}, ",a);
            }
        }
    }
}
