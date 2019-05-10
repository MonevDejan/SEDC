using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public void ConStrings (string x, string y, string z)
        {
            Console.WriteLine(x + y + z);
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student { FullName = "Marko", Age = 19 };

            //Action referencing method 
            Action<string, string, string> concatinateString = student.ConStrings;
            concatinateString("String1 ", "Strign2 ", "String3 ");

            //Action using Anonymous method
            Action<string> showMessage = delegate (string msg) { Console.WriteLine(msg); };
            showMessage("Action delegate");

            //Actions with lambda expression
            Action<string> showAnonymousMsg = (msg) => { Console.WriteLine(msg); };
            showAnonymousMsg("Hello from Action anonymous");

            Action line = () => Console.WriteLine();
            line();
            line();
            Console.WriteLine("-----two empty lines before-----");

            Action<string> greet = name => {
                string greeting = $"Hello {name}";
                Console.Write(greeting);
                Console.Write('\n');
            };
            greet("World");
            
            Action<Student> PrintStudentDetail = s => Console.WriteLine("Name: {0}, Age: {1}",
                s.FullName, s.Age);
            PrintStudentDetail(student);
            

            Console.ReadLine();
        }
    }
}
