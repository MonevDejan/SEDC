using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary.Enum;
using ClassLibrary.Database;

namespace ClassLibrary.Class

{
    public class Admin : User
    {

        public Admin() : base()
        {
            Role = Role.Admin;
        }

        public Admin(string firstName, string lastName, string userName, string password) : base(firstName, lastName,userName,password)
        {

            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;

            Role = Role.Admin;
        }

        public void AddNewUser(ListOfUsers users, Role role)
        {
            if (role == Role.Student)
            {
                users.AllStudents.Add(new Student());
                Console.WriteLine("New student has been add");
            }
            else if (role == Role.Trainer)
            {
                users.AllTrainers.Add(new Trainer());
                Console.WriteLine("New Trainer has been add");
            }
            else
            {
                users.AllAdmins.Add(new Admin());
                Console.WriteLine("New Admin has been add");
            }
        }


        public void RemoveUser(ListOfUsers users, Role role, string fullName)
        {
            bool IsRemoved = false;

            if (role == Role.Student)
            {
                for (int i = 0; i < users.AllStudents.Count; i++)
                {
                    string fullStudentName = $"{ users.AllStudents[i].FirstName} { users.AllStudents[i].LastName}";

                    if (fullStudentName == fullName)
                    {
                        Console.WriteLine($"Student {fullStudentName} has been removed from list");
                        users.AllStudents.RemoveAt(i);
                        IsRemoved = true;
                    }

                }
            }
            else if (role == Role.Trainer)
            {

                for (int i = 0; i < users.AllTrainers.Count; i++)
                {
                    string fullTrainerName = $"{ users.AllTrainers[i].FirstName} { users.AllTrainers[i].LastName}";

                    if (fullTrainerName == fullName)
                    {
                        Console.WriteLine($"Student {fullTrainerName } has been removed from list");
                        users.AllTrainers.RemoveAt(i);
                        IsRemoved = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < users.AllAdmins.Count; i++)
                {
                    string fullAdmintName = $"{users.AllAdmins[i].FirstName} { users.AllAdmins[i].LastName}";
                    string logedInAdminFullName = $"{this.FirstName} { this.LastName}";

                    if (fullAdmintName != logedInAdminFullName)
                    {
                        if (fullAdmintName == fullName)
                        {
                            Console.WriteLine($"Student {fullAdmintName} has been removed from list");
                            users.AllAdmins.RemoveAt(i);
                            IsRemoved = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You cant remove yourself");
                        IsRemoved = true;
                    }
                }

            }
            if (!IsRemoved)
            {
                Console.WriteLine($"There is not such user with fullname \"{fullName}\"");
            }
        }

    }
}
