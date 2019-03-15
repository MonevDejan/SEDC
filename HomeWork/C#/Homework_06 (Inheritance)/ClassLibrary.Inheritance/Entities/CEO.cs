using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Inheritance.Enteties
{
    public class CEO : Employee
    {
        public int Shares { get; set; }
        private double SharesPrice { get; set; }
        public Employee [][] Employees { get; set; }


        public CEO(string firstName, string lastName, int shares, Employee[][] employees) : base(firstName, lastName)
        {
            SharesPrice = 0;
            Role = Roles.CEO;

            FirstName = firstName;
            LastName = lastName;
            Shares = shares;
            Employees = employees;

        }

        public void AddSharesPrice(double number)
        {
            SharesPrice = number;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("The emplyees are:");
            for (int i = 0; i < Employees.Length  /* this is the first layer in array with positions (Manager, sales...)*/ ; i++)
            {
                for (int j = 0; j < Employees[i].Length /* this is the second layer in array with emplouees from exat position*/; j++)
                {
                    Console.WriteLine($"{Employees[i][j].FirstName} {Employees[i][j].LastName}");
                }
            }
        }

        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice) ;
        }

      
    }
}
