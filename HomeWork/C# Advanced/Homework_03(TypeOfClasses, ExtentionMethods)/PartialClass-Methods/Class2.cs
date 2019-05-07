using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Methods
{
    public partial class Coords
    {
        public void PrintCoords()
        {
            Console.WriteLine("Coords: {0},{1}", x, y);
        }

        partial void Sum()
        {
            Console.WriteLine("Sum of x + y = {0}", this.x + this.y);
        }

        public void PrintSum ()
        {
            Sum();
        }
    }
}
