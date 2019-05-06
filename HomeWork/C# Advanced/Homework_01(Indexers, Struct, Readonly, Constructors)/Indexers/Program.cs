using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    //Note: There is no point building indexesrs for iterable elements
    // Creating indexer for strings 
    public class StringArray
    {
        private string[] _myStrings = new string[100];

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _myStrings.Length)
                    return _myStrings[index];

                return "Error";
            }
            set
            {
                if (index >= 0 && index < _myStrings.Length)
                    _myStrings[index] = value;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            StringArray layout = new StringArray();
            layout[1] = "Frank Gehry";
            layout[3] = "I. M. Pei";
            layout[10] = "Frank Lloyd Wright";
            layout[11] = "Apollodorus";
            layout[-1] = "Armagedon";
            layout[1000] = "Martian";

            string value1 = layout[1];
            string value2 = layout[3];
            string value3 = layout[10];
            string value4 = layout[11];
            string value5 = layout[50]; // there is no assign value to this index and it returns null
            string value6 = layout[-1]; // should give error


            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5); 
            Console.WriteLine(value6);

          
            Console.ReadLine();

        }
    }
}
