using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary.Class;
using ClassLibrary.Enum;

namespace ClassLibrary.Services
{
    public class Find
    {
        public User Person(List<User> users, string username, string pasword)
        {
            User foundUser = null;
            foreach (var user in users)
            {
                if ((user.Password == username) && (user.UserName == pasword))
                {
                    foundUser = user;
                }
            }
            return foundUser;
        }
    }
}
