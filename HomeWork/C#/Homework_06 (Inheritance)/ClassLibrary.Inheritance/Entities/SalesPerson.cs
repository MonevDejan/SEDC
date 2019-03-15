using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Inheritance.Enteties
{
    
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
            Role = Roles.Sales;
            SuccessSaleRevenue = 0;

            FirstName = firstName;
            LastName = lastName;

        }

        public void AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue = number;
        }

        public override double GetSalary()
        {
            double number = SuccessSaleRevenue;
            if (number <= 2000)
            {
                return Salary + 500;
            }
            else if (number <= 5000)
            {
                return Salary + 1000;
            }
            else
            {
                return Salary + 1500;
            }

        }

      
    }
}
