using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyKeyWord
{
    public class Example
    {
        public int x { get; set; }
        public readonly int y = 25;
        public readonly int z;

        public Example()
        {
            // Initialize a readonly instance field
            z = 24;
        }

        public Example(int p1, int p2, int p3)
        {
            x = p1;
            y = p2;
            z = p3;
        }
    }


    class Program
    {
        static void Main()
        {
            Example p1 = new Example(11, 21, 32);   // OK
            Console.WriteLine($"p1: x={p1.x}, y={p1.y}, z={p1.z}");
            Example p2 = new Example();
            p2.x = 55;   // OK
            Console.WriteLine($"p2: x={p2.x}, y={p2.y}, z={p2.z}");
            // p2.y = 66; Compile error
            Console.ReadLine();
        }
    }
}
