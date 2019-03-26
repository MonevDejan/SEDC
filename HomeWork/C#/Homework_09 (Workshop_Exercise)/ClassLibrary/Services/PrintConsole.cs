using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary.Class;

namespace ClassLibrary.Services
{
    public class PrintConsole
    {
        public void Choices ()
        {
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Trainer");
            Console.WriteLine("3. Student");
        }
        
        public void SubjectAndAttendance(List<Subject> allSubjects)
        {
            foreach (Subject subject in allSubjects)
            {
                Console.WriteLine($"Subject: {subject.Name}, Attendence: {subject.Attendence.Count}");
            }
        }

        public void Users(List<User> userList)
        {
            foreach (var user in userList)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }
        }

        public void SubjectAndGrades(Dictionary<string, int> subjectAndGrades)
        {
            foreach (var pair in subjectAndGrades)
            {
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
            }
        }

        public void StudentOptions()
        {
            Console.WriteLine("Please chose what do you want to do");
            Console.WriteLine("1. Enrol new subject");
            Console.WriteLine("2. Show grades");
        }
    }
}
