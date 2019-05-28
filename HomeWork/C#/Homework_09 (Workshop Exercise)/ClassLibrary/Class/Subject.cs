using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Enum;


namespace ClassLibrary.Class
{
    public class Subject
    {
        public ClassSubject Name { get; set; }
        public List<string> Attendence { get; set; }

        public Subject()
        {
            Name = ClassSubject.Undeclared;
            Attendence = new List<string>();
        }

        public Subject(ClassSubject subjectName)
        {
            Name = subjectName;
            Attendence = new List<string>();
        }
    }
}
