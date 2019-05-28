using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary.Class;
using ClassLibrary.Enum;

namespace ClassLibrary.Database
{
    public class EditDatabase
    {
        public void UserStudent(ListOfUsers users, string username, string pasword, string enrolSubject, ListOfSubjects subjects )
        {
            foreach (var student in users.AllStudents)
            {
                if ((student.UserName == username) && (student.Password == pasword))
                {

                    student.CurrentSubject = enrolSubject;
                    student.EnroledSubjects.Add(enrolSubject, 0);
                    Console.WriteLine($"Studetn {student.FirstName} {student.LastName} has enroled in {enrolSubject}");

                    // To add student to the class attendance
                    ClassSubject chosenSubject = (ClassSubject)System.Enum.Parse(typeof(ClassSubject), enrolSubject);
                    foreach (var subjectToListen in subjects.AllSubjects)
                    {
                        if (chosenSubject == subjectToListen.Name)
                        {
                            subjectToListen.Attendence.Add($"{student.FirstName} {student.LastName}");
                        }

                    }

                }
            }
        }
        
    }
}
