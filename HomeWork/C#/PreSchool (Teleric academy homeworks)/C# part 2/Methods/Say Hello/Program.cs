using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Say_Hello
{
    class Program
    {
        static void SayHello()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }
        static void Main()
        {
            int[] array = new int [3];
            for (int i = 0; i < 3; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("PLease enter your name");
            SayHello();
            Main();
        }
    }
}
