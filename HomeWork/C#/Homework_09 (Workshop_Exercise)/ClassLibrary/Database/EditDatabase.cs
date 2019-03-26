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
        public Subject SubjectName(List<Subject> subjects, ClassSubject nameOfSubject)
        {
            Subject foundSubject = null;

            foreach (var subject in subjects)
            {
                if (subject.Name == nameOfSubject)
                {
                    foundSubject = subject;
                }
            }
            return foundSubject;
        }
    }
}
