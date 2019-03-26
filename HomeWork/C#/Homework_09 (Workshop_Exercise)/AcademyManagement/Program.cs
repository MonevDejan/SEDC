using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary.Class;
using ClassLibrary.Enum;
using ClassLibrary.Database;
using ClassLibrary.Services;

namespace AcademyManagement
{
    //Task
    #region

    /*
        The app will have users that can login and perform some actions. The user can choose one of the 3 roles and login:
        Admin
        Trainer
        Student ( has a current Subject, and Grades )
        After logging in there should be different options for different roles:

        Admins can add/remove Teachers , Students and other Admins ( can't remove it self )

        Trainer can choose between seeing all students and all subjects
            When choosing Students, all student names should appear
            When chosen a name, it should print all the grades
            When choosing Show Subjects, all Subject names appear with how many students attend it next to it

        Students can choose to enrol in a subject and show grades
            Enrol will give the student subjects for the student to choose and whichever one it chooses will be it's current subject
            Show Grades will show all the grades in format: Subject Name : Grade ( Ex: Math : 5 )
        Try and handle all scenarios with exception handling. Handle expected exceptions with special messages.

     */
    #endregion

    class Program
    {
        static void Main()
        {
            PrintConsole print = new PrintConsole();
            Validate validate = new Validate();
            ListOfUsers usersList = new ListOfUsers();
            Find find = new Find();
            ListOfSubjects subjects = new ListOfSubjects();

            Console.WriteLine("Please chose user to log in:");
            print.Choices();
            string chosenUser = validate.Option1to3();

            switch (chosenUser)
            {
                case "1":
                   

                    break;

                case "2":
                    Console.WriteLine("option 2");
                    
                    break;

                case "3":
                    
                    Console.WriteLine("Please enter your Username");
                    string username = validate.UserName(usersList.AllStudents);

                    Console.WriteLine("Please enter your Password");
                    string pasword = validate.Password(usersList.AllStudents, username);

                    Student logedInStudent = find.Person(usersList.AllStudents, username, pasword);

                    print.StudentOptions();
                    string studentOption = validate.Option1or2();

                    switch (studentOption)
                    {
                        case "1":
                            Console.WriteLine("Please chose from the following subjects");
                            print.SubjectAndAttendance(subjects.AllSubjects);
                            string inputSubject = validate.Subject();

                            ClassSubject chosenSubject = (ClassSubject)Enum.Parse(typeof(ClassSubject), inputSubject);

                            


                            break;
                        case "2":
                            Console.WriteLine("option 2");

                            break;
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
