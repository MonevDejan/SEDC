using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary.Class;

namespace ClassLibrary.Services
{
    public class Validate
    {
        public string Option1or2()
        {
            string input = Console.ReadLine();

            if ((input != "1") && (input != "2"))
            {
                Console.WriteLine("Please chose options from 1 or 2");

                input = Option1or2();
            }
            return input;
        }

        public string Option1to3()
        {
            string input = Console.ReadLine();
            try
            {
                if ((input != "1") && (input != "2") && (input != "3"))
                {
                    throw new Exception("Please chose options from 1, 2 or 3");
                }
                return input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                input = Option1to3();
                return input;
            }
        }

        public string UserName<T>(List<T> users) where T : User
        {
            string input = Console.ReadLine();

            bool hasName = false;

            foreach (var user in users)
            {
                if (user.UserName == input)
                {
                    hasName = true;
                }
            }

            try
            {
                if (!hasName)
                {
                    throw new Exception("The username is not valid! Please enter valid username");
                }
                return input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                input = UserName(users);
                return input;
            }
        }

        public string Password<T>(List<T> users, string userName) where T : User
        {
            string input = Console.ReadLine();

            bool hasPassword = false;

            foreach (var user in users)
            {
                if ((user.Password == input) && (user.UserName == userName))
                {
                    hasPassword = true;
                }
            }

            try
            {
                if (!hasPassword)
                {
                    throw new Exception($"The Password is not valid! Please enter valid password for {userName}");
                }
                return input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                input = Password(users, userName);
                return input;
            }

        }

        public string Subject()
        {
            string input = Console.ReadLine();
            bool IsSubject = ((input == "Algebra") || (input == "Geometry") || (input == "Biology")
                             || (input == "Physics") || (input == "Science") || (input == "Geography")
                             || (input == "History") || (input == "Music"));

            try
            {
                if (!IsSubject)
                {
                    throw new Exception("Please chose valid subject");
                }
                return input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                input = Subject();
                return input;
            }
        }

        public string StudentFullName (List<Student> allStudents)
        {
            string input = Console.ReadLine();

            bool IsfullName = false;

            foreach (var student in allStudents)
            {
                string fullStudentName = $"{student.FirstName} {student.LastName}";

                if (fullStudentName == input)
                {
                    IsfullName = true;
                }
            }

            try
            {
                if (!IsfullName)
                {
                    throw new Exception("There is not student with that fullname. Please chose from the results above");
                }
                return input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                input = StudentFullName(allStudents);
                return input;
            }
        }
    }
}
