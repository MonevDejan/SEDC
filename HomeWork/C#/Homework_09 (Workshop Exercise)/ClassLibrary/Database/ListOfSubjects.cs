using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary.Class;
using ClassLibrary.Enum;

namespace ClassLibrary.Database
{
    public class ListOfSubjects
    {
        public List<Subject> AllSubjects { get; set; }

        public ListOfSubjects()
        {
            AllSubjects = new List<Subject>()
            {
                new Subject(ClassSubject.Algebra),
                new Subject(ClassSubject.Biology),
                new Subject(ClassSubject.Geography),
                new Subject(ClassSubject.Geometry),
                new Subject(ClassSubject.History),
                new Subject(ClassSubject.Music),
                new Subject(ClassSubject.Physics),
                new Subject(ClassSubject.Science)
            };

        }
    }
}
