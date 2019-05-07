using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Methods
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Coords myCoords = new Coords(10, 15);
            myCoords.PrintCoords();
            myCoords.PrintSum();

            Console.ReadLine();

        }
    }
}
