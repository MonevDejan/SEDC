using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary.Class;
using ClassLibrary.Enum;

namespace ClassLibrary.Database
{
    public class ListOfUsers
    {
        public List<Admin> AllAdmins { get; set; }
        public List<Trainer> AllTrainers { get; set; }
        public List<Student> AllStudents { get; set; }

        public ListOfUsers()
        {
            AllAdmins = new List<Admin>()
            {
                new Admin("Admin1", "Manager1", "Neo-Geo1", "1111"),
                new Admin("Admin2", "Manager2", "Neo-Geo2", "2222"),
                new Admin("Admin3", "Manager3", "Neo-Geo3", "3333")
            };

            AllTrainers = new List<Trainer>()
            {
                new Trainer("Trainer1","Teacher1","Master1", "4444",ClassSubject.Algebra),
                new Trainer("Trainer2","Teacher2","Master2", "5555",ClassSubject.Biology),
                new Trainer("Trainer3","Teacher3","Master3", "6666",ClassSubject.Physics)
            };

            AllStudents = new List<Student>()
            {
                new Student("Student1", "Learner1", "Kloshar1","7777"),
                new Student("Student2", "Learner2", "Kloshar2","8888"),
                new Student("Student3", "Learner3", "Kloshar3",""),
            };

        }
    }
}
