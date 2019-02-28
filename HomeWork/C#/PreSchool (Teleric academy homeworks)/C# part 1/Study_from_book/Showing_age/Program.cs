using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showing_age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter you birthday in folowing format MM/YY/DD");

            System.DateTime birthTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(birthTime);
            System.DateTime now = System.DateTime.Now;
            System.TimeSpan age = now - birthTime;
            Console.WriteLine(age);
            Console.WriteLine(now);
            double ageInYears = age.TotalDays;
            Console.WriteLine(ageInYears / 365);
        }
    }
}
