using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Enum;

namespace ClassLibrary.Class
{
    public class Student : User
    {
        public Dictionary<string, byte> EnroledSubjects { get; set; }
        public Subject CurrentSubject{ get; set; }

        public Student() : base()
        {
            Role = Role.Student;
            EnroledSubjects = new Dictionary<string, byte>();
        }

        public Student(string firstName, string lastName, string userName, string password) : base(firstName, lastName, userName, password)
        {

            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;

            Role = Role.Student;
            EnroledSubjects = new Dictionary<string, byte>();
        }

        public void Enrol(Subject subject)
        {
            CurrentSubject = subject;
        }
    }
}
