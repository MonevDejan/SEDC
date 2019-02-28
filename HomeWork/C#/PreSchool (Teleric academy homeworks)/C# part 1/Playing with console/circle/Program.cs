using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert radius r=");

            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(radius >=0 ?  "Perimetar L={0: 0.00} A={1: 0.00}" : "please enter valid number",2 * radius * Math.PI, radius * radius * Math.PI);
        }
    }
}
