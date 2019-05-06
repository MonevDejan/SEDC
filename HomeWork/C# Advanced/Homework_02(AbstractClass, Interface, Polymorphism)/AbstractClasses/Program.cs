using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        public abstract class BaseClass
        {
            public int MyProperty { get; set; }
            public abstract int MyProperty1 { get; set; }
            public abstract string MyMethod(string Mystring);
        }

        public class DerivedClass : BaseClass
        {
            public override int MyProperty1 { get; set; }

            public DerivedClass(int myprop, int myprop1)
            {
                MyProperty = myprop;
                MyProperty1 = myprop1;

            }
            public override string MyMethod(string mystring)
            {
                return mystring + "suffix";
            }
        }

        static void Main(string[] args)
        {
            DerivedClass example = new DerivedClass(20,60);
            Console.WriteLine(example.MyProperty1);
            Console.WriteLine(example.MyProperty);
            Console.WriteLine(example.MyMethod("MainWord"));
            Console.ReadLine();

        }
    }
}
