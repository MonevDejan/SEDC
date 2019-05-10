using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Generic<T,U> 
    {
        public T MyProperty1 { get; set; }
        public U MyProperty2 { get; set; }
        public bool MyProperty3 { get; set; }

        public Generic(T value1, U value2, bool value3)
        {
            MyProperty1 = value1;
            MyProperty2 = value2;
            MyProperty3 = value3;
        }

        public void PropInfo()
        {
            Console.WriteLine("Propr1: {0}, Type: {1}", MyProperty1, Type.GetTypeCode(MyProperty1.GetType()));
            Console.WriteLine("Propr2: {0}, Type: {1}", MyProperty2, Type.GetTypeCode(MyProperty2.GetType()));
        }

        public void WriteTypes <X,Y> (X type1, Y type2, T type3)
        {
            Console.WriteLine("Type1: {0}, Type2: {1}, Type3: {2}", 
                Type.GetTypeCode(type1.GetType()), 
                Type.GetTypeCode(type2.GetType()), 
                Type.GetTypeCode(type3.GetType()));
        }
    }
   
    class Program
    {
        // Generic Print collections method
        public static void Print<T>(IEnumerable<T> collection)
        {
            Type type = typeof(T);
            if (!(type.IsPrimitive || type.IsValueType || type == typeof(string)))
            {
                Console.WriteLine("--------------------");
                var props = typeof(T).GetProperties();
                foreach (var prop in props)
                {
                    Console.Write($"{prop.Name}\t");
                }
                Console.WriteLine();

                foreach (var item in collection)
                {
                    foreach (var prop in props)
                    {
                        Console.Write($"{prop.GetValue(item, null)}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                foreach (var item in collection)
                {
                    Console.Write($"{item}\t");
                }
                Console.Write("\n");
            }
        }
        static void Main()
        {
            Generic<string, string> message = new Generic<string, string>("Hello", "string", true);
            Generic<int, double> integer = new Generic<int, double>(16, 23.45, false);

            message.PropInfo();
            integer.PropInfo();

            message.WriteTypes("CheckType", 12.444f, "PlaceHolder");
            integer.WriteTypes(34, 23.4554M, 56 );

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Dictionary<string, int>  itmes = new Dictionary<string, int>();
            itmes.Add("apple", 1);
            itmes.Add("windows", 5);

            string[] strings = new string[2] { "Hello", "World" };

            Print(numbers);
            Print(itmes);
            Print(strings);

            Console.ReadLine();
        }
    }
}
