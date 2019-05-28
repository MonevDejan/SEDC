using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Enum;

namespace ClassLibrary.Class
{
    public class Trainer : User
    {
        public ClassSubject TeachingSubject { get; set; }

        public Trainer() : base()
        {
            
            Role = Role.Trainer;
            TeachingSubject = ClassSubject.Undeclared;
        }

        public Trainer(string firstName, string lastName, string userName, string password, ClassSubject teachingSubject) : base(firstName, lastName, userName, password)
        {

            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Role = Role.Trainer;

            TeachingSubject = TeachingSubject;

        }
    }
}
