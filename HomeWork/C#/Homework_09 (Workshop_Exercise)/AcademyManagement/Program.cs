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

    #region Task 

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
            EditDatabase edit = new EditDatabase();
            ListOfSubjects subjects = new ListOfSubjects();
            StartAgain start = new StartAgain();

            bool RunProgram = true;

            do
            {
                Console.WriteLine("Please chose user to log in:");
                print.Choices();
                string chosenUser = validate.Option1to3();

                switch (chosenUser)
                {
                    #region Admin
                    case "1": // Admin

                        Console.WriteLine("Please enter your Username");
                        string usernameAdmin = validate.UserName(usersList.AllAdmins);

                        Console.WriteLine("Please enter your Password");
                        string paswordAdmin = validate.Password(usersList.AllAdmins, usernameAdmin);

                        Admin logedInAdmin = null;
                        foreach (Admin admin in usersList.AllAdmins)
                        {
                            if ((admin.UserName == usernameAdmin) && (admin.Password == paswordAdmin))
                            {
                                logedInAdmin = admin;
                            }
                        }

                        print.AdminOptions();
                        string adminOption = validate.Option1to3();

                        switch (adminOption)
                        {
                            case "1": // Add User

                                Console.WriteLine("Please select wich type of user you want to add");
                                print.AddRemoveUser();

                                string adminAddOptions = validate.Option1to3();

                                switch (adminAddOptions)
                                {
                                    case "1": // Student

                                        logedInAdmin.AddNewUser(usersList, Role.Student);

                                        break;
                                    case "2":  // Trainer

                                        logedInAdmin.AddNewUser(usersList, Role.Trainer);
                                        break;

                                    case "3":  // Admin

                                        logedInAdmin.AddNewUser(usersList, Role.Admin);
                                        break;
                                }

                                break;

                            case "2": // Remove User


                                Console.WriteLine("Please select wich type of user you want to Remove");
                                print.AddRemoveUser();

                                string adminRemoveOptions = validate.Option1to3();

                                switch (adminRemoveOptions)
                                {
                                    case "1": // Student
                                        Console.WriteLine("Please insert full name of the student");
                                        string studentFullname = Console.ReadLine();

                                        logedInAdmin.RemoveUser(usersList, Role.Student, studentFullname);

                                        break;
                                    case "2":  // Trainer
                                        Console.WriteLine("Please insert full name of the trainer");
                                        string trainerFullname = Console.ReadLine();

                                        logedInAdmin.RemoveUser(usersList, Role.Student, trainerFullname);

                                        break;

                                    case "3":  // Admin
                                        Console.WriteLine("Please insert full name of the admin");
                                        string adminFullname = Console.ReadLine();

                                        logedInAdmin.RemoveUser(usersList, Role.Student, adminFullname);

                                        break;
                                }

                                break;
                        }

                        break;
                    #endregion

                    #region Trainer
                    case "2": // Trainer

                        Console.WriteLine("Please enter your Username");
                        string usernameTrainer = validate.UserName(usersList.AllTrainers);

                        Console.WriteLine("Please enter your Password");
                        string paswordTrainer = validate.Password(usersList.AllTrainers, usernameTrainer);

                        print.TrainerOptions();
                        string trainertOption = validate.Option1or2();

                        switch (trainertOption)
                        {
                            case "1": // All Students

                                Console.WriteLine("Please chose from the following student");
                                print.Users(usersList.AllStudents);

                                Student chosenStudent = validate.StudentFullName(usersList.AllStudents);

                                print.StudentSubjectAndGrades(chosenStudent);
                                break;

                            case "2": // All subjects

                                print.SubjectAndAttendance(subjects.AllSubjects);
                                break;
                        }
                        break;
                    #endregion

                    #region Student
                    case "3": //Student

                        Console.WriteLine("Please enter your Username");
                        string usernameStudent = validate.UserName(usersList.AllStudents);

                        Console.WriteLine("Please enter your Password");
                        string paswordStudent = validate.Password(usersList.AllStudents, usernameStudent);

                        print.StudentOptions();
                        string studentOption = validate.Option1or2();

                        switch (studentOption)
                        {
                            case "1": // Enrol

                                Console.WriteLine("Please chose from the following subjects");
                                print.SubjectAndAttendance(subjects.AllSubjects);

                                string inputSubject = validate.Subject();

                                edit.UserStudent(usersList, usernameStudent, paswordStudent, inputSubject, subjects);

                                break;
                            case "2": //Show Grades

                                print.StudentSubjectAndGrades(usersList, usernameStudent, paswordStudent);

                                break;
                        }
                        break;
                }
                #endregion

                Console.WriteLine("________________________________________");
                Console.WriteLine("Do you want to chek another number Y/N ");
                RunProgram = start.RunProgramAgain();

            } while (RunProgram);

        }
    }
}
