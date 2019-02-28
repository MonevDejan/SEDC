using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_date_and_time
{
    class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("date and time is");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
           
        }
    }
}
