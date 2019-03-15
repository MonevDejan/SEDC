using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Inheritance.Enteties
{
    public class Contractor : Employee
    {

        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }


        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public Manager CurrentPosition()
        {
            return Responsible;
        }

        public Contractor(string firstName, string lastName, double workingHours, int payPerHour) : base(firstName, lastName)
        {
            Salary = 500;
            Role = Roles.Contractor;
            Responsible = new Manager();
            
            WorkHours = workingHours;
            PayPerHour = payPerHour;

        }
    }
}
