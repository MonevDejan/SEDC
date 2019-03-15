using System;
using ClassLibrary.Inheritance.Enteties;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Tasks
    #region
    /*
        Task 1
        Create a class library project and in it create all classes
        Create a class called Employee with the following properties:
        FirstName
        LastName
        Role - Enum ( Sales, Manager, Other )
        Salary - protected, double
        Create two methods:
        PrintInfo - Prints FirstName, LastName and Salary
        GetSalary - returns the salary

        Task 2
        Create a SalesPerson class that inherits from Employee and has the following properties:
        SuccessSaleRevenue double, private
        The salary is by default 500 and role is default Sales
        Create constructor that sets all the properties
        Create a method called AddSuccessRevenue that will get a number and set the SuccessSaleRevenue to that value
        Override the GetSalary method to return the value of the salary plus bonus that is calculated by the SuccessSaleRevenue. 
        If less or equal to 2000 then add 500 bonus
        If larger than 2000 but less or equal than 5000 then add 1000 bonus
        If larger than 5000 add 1500 bonus

        Task3
        Add class Manager that inherits from Employee and has a new property called Bonus - double, private
        Create a constructor that sets all properties except Bonus
        Create a method called AddBonus that adds bonus to the Bonus property
        Override the method GetSalary to return the Salary + Bonus

        Task 4
 
        Extend the exercise for Employees with two more Employees. Add a class called Contractor that inherits from Employee. 
        The employee should have properties: WorkHours ( double ), PayPerHour ( int ) and Responsible (Manager ( object )).
        The GetSalary method should be overridden to return WorkHours * PayPerHour and also change the Salary property to that amount 
        A new method called CurrentPosition should return the department of the manager that is responsible for this Contractor.

        Task 5

        Make an array called Company with 2 contractors, 2 managers and 1 salesPerson
        Make a new class CEO that inherits from Employee that will have a property Employees ( an array of Employees), Shares property ( int ), SharesPrice ( double )
        The shares price should not be accessed from outside of the class
        There should be a method called AddSharesPrice() that will accept a double number and it will change the SharesPrice. This is the only way to change SharesPrice
        The CEO should have a method called PrintEmployees() that will print all employees that work for his company. 
        The CEO should override the GetSalary method to return Salary + Shares * SharesPrice

        Create a new instance of CEO and call: ceoName.PrintInfo(), ceoName.PrintEmployees() and ceoName.GetSalary() to check if everything is working. 

        Expected output: 
        CEO:
        First Name: Ron, Last Name: Ronsky, Salary: 1500
        Salary of CEO is: 2900
        Employees:
        Bob Bobert
        Rick Rickert
        Mona Monalisa
        Igor Igorsky
        Lea Leova

     */
    #endregion
    class Program
    {
        static void Main()
        {

            Employee dejan = new Employee("Dejan", "Monev");
            dejan.SetSalary(11000);
            dejan.PrintInfo();

            Console.ReadLine();
            Console.Clear();
           

            SalesPerson dime = new SalesPerson("Dime", "Taksi");
            dime.AddSuccessRevenue(2364);
            dime.PrintInfo();
            Console.WriteLine("Salary + success revenue is: {0}", dime.GetSalary());

            Console.ReadLine();
            Console.Clear();


            Manager strasho = new Manager("Strasho", "Pindjur");
            strasho.AddBonus(324.06);
            strasho.PrintInfo();
            Console.WriteLine("Salary + bonus is: {0}", strasho.GetSalary());

            Console.ReadLine();
            Console.Clear();

            Manager zoki = new Manager("Zoki", "Poki");
            zoki.AddBonus(122.06);

            Contractor nikola = new Contractor("Nikola", "Kojo", 6, 23);
            nikola.Responsible = strasho;

            Contractor kiril = new Contractor("Kiril", "Stipsata", 12, 16);
            kiril.Responsible = zoki;


            SalesPerson[] sales = new SalesPerson[] { dime };
            Manager[] managers = new Manager[] { strasho, zoki };
            Contractor[] contructors = new Contractor[] { nikola, kiril };

            Employee [][] companyEmployees = new Employee [][] { sales, managers, contructors };

            CEO pero = new CEO("Pero", "Rakunot", 3, companyEmployees);
            pero.PrintInfo();
            pero.PrintEmployees();
            pero.AddSharesPrice(57);
            Console.WriteLine("Salary + (Shares * SharesPrice) is: {0}", pero.GetSalary()); 
           

           
            Console.ReadLine();
        }
    } 
}
