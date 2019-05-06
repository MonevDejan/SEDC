using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    // To show up all the contructors (parameterless, instance, private, static, clone, copy) 
    public class Constructors : ICloneable // must have this interface to be able to clone 
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }

        public static readonly int x;
        public static readonly int y;

        // parametarless
        public Constructors()
        {

        }
        // Instance
        public Constructors( int number1, int number2)
        {
            MyProperty1 = number1;
            MyProperty2 = number2;

        }
        // static
        static Constructors()
        {
            x = 14;
            y = 28;
            
        }
        //Copy
        public Constructors(Constructors elementToCopy)
        {
            MyProperty1 = elementToCopy.MyProperty1;
            MyProperty2 = elementToCopy.MyProperty2;

        }

        public int Getx()
        {
            return x;
        }

        public int Gety()
        {
            return y;
        }

        //Clone
        public Constructors Clone() { return new Constructors(this); }
   
        object ICloneable.Clone()
        {
            return Clone();
        }


    }
    class Program
    {
        static void Main()
        {
            Constructors example1 = new Constructors();
            Constructors example2 = new Constructors(12, 15);
            Constructors example3 = new Constructors(example2);
            example3.MyProperty1 = 18;
            example3.MyProperty2 = 18;
            Constructors example4 = example3.Clone();
            example4.MyProperty1 = 77;
            example4.MyProperty2 = 45;
            Console.WriteLine("Default contructor properties {0} {1} {2} {3}", example1.MyProperty1, example1.MyProperty2, example1.Getx(), example1.Gety());
            Console.WriteLine("intance constructor properties {0} {1} {2} {3}", example2.MyProperty1, example2.MyProperty2, example2.Getx(), example2.Gety());
            Console.WriteLine("Copy constructor properties {0} {1} {2} {3}", example3.MyProperty1, example3.MyProperty2, example3.Getx(), example3.Gety());
            Console.WriteLine("Clone constructor properties {0} {1} {2} {3}", example4.MyProperty1, example4.MyProperty2, example4.Getx(), example4.Gety());

            Console.ReadLine();
        }
    }
}
