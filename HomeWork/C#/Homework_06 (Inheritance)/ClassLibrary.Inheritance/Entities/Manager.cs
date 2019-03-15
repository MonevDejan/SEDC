using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Inheritance.Enteties
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }


        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {
            Role = Roles.Manager;

            FirstName = firstName;
            LastName = lastName;
        }

        public Manager() : base()
        {

        }

        public void AddBonus (double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
        
    }
}
