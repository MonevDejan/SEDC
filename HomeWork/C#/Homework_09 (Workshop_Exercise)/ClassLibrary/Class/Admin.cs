using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Enum;

namespace ClassLibrary.Class
{
    public class Admin : User
    {

        public Admin() : base()
        {
            Role = Role.Admin;
        }

        public Admin(string firstName, string lastName, string userName, string password) : base(firstName, lastName,userName,password)
        {

            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;

            Role = Role.Admin;
        }

        public void AddUser(ref List<User> usersList)
        {

        }

        public void RemoveUser(ref List<User> usersList)
        {

        }

    }
}
