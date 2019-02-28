using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter Company name");
            string Cname = Console.ReadLine();
            Console.WriteLine("please enter Company Address");
            string Caddres = Console.ReadLine();
            Console.WriteLine("please enter Phone number");
            string Pnumber = Console.ReadLine();
            Console.WriteLine("please enter Fax number");
            string fax = Console.ReadLine();
            Console.WriteLine("please enter Web site");
            string Web = Console.ReadLine();
            Console.WriteLine("Manager first name");
            string Fname = Console.ReadLine();
            Console.WriteLine("Manager last name");
            string Lname = Console.ReadLine();
            Console.WriteLine("Manager age");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Manager phone");
            string Mphone = Console.ReadLine();

            Console.WriteLine(Cname);
            Console.WriteLine("Address: {0}", Caddres);
            Console.WriteLine("Tel. +{0}", Pnumber);
            Console.WriteLine(fax != "" ? fax : "No fax");
            Console.WriteLine("Web site: {0}", Web);
            Console.WriteLine("Manager: " + Fname + " " + Lname + "(age: {0}, trl. +{1})", age, Mphone);

        }
    }
}
