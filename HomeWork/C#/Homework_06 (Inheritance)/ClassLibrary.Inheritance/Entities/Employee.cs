using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Inheritance.Enteties
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roles Role { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName)
        {
            Salary = 500;

            FirstName = firstName;
            LastName = lastName;
        }

        public void PrintInfo ()
        {
            Console.WriteLine($"Name: {FirstName}, Last name: {LastName}, Salary: {Salary}");
        }
        
        public void SetSalary (double number)
        {
            Salary = number;
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

       

    }
}
