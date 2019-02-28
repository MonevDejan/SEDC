using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Console.SetCursorPosition(3, 7);

            char sign = (char)169;
            // Console.WriteLine(sign);
            Console.WriteLine(@"   
                                   {0} 
                                  {0} {0} 
                                 {0}   {0} 
                                {0} {0} {0} {0}  ", sign);
        }
    }
}
