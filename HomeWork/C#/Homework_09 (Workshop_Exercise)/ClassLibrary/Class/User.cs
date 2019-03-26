using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Enum;

namespace ClassLibrary.Class
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User()
        {
            FirstName = "unknown";
            LastName = "unknown";
            UserName = "unknown";
            Password = "unknown";
            Role = Role.Undeclared;
        }

        public User(string firstName, string lastName, string userName, string password )
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
        }
    }   
}
