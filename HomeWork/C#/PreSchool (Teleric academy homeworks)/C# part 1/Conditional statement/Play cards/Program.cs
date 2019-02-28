using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sign");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "2": Console.WriteLine("Yes {0}", sign); break;
                case "3": Console.WriteLine("Yes {0}", sign); break;
                case "4": Console.WriteLine("Yes {0}", sign); break;
                case "5": Console.WriteLine("Yes {0}", sign); break;
                case "6": Console.WriteLine("Yes {0}", sign); break;
                case "7": Console.WriteLine("Yes {0}", sign); break;
                case "8": Console.WriteLine("Yes {0}", sign); break;
                case "9": Console.WriteLine("Yes {0}", sign); break;
                case "10": Console.WriteLine("Yes {0}", sign); break;
                case "J": Console.WriteLine("Yes {0}", sign); break;
                case "Q": Console.WriteLine("Yes {0}", sign); break;
                case "K": Console.WriteLine("Yes {0}", sign); break;
                case "A": Console.WriteLine("Yes {0}", sign); break;
                default: Console.WriteLine("No {0}", sign); break;
            }


        }
    }
}
