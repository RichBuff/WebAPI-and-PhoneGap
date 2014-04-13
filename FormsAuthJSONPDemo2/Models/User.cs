using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auth.Models
{
    /// <summary>
    /// Entity data class
    /// </summary>
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }

    /// <summary>
    /// View data class
    /// </summary>
    public class ViewUser 
    {
        public string Name { get; set; }
    }

    /// <summary>
    /// This is really just a test stub for a data access layer
    /// </summary>
    public class UserData
    {
        protected static List<User> UserList()
        {
            var list = new List<User>();
            list.Add(new User()
            {
                Name = "Rich",
                Password = "pass00"
            });

            list.Add(new User()
            {
                Name = "Pat",
                Password = "pass00"
            });

            list.Add(new User()
            {
                Name = "Susan",
                Password = "pass00"
            });

            list.Add(new User()
            {
                Name = "Fred",
                Password = "pass00"
            });

            return list;
        }

        public static ViewUser FindUser(string name, string password)
        {
            var user = UserList().FirstOrDefault(u => u.Name == name && u.Password == password);
            return user==null ? null : GetViewUserFromEntityUser(user);
        }

        public static ViewUser GetViewUserFromEntityUser(User user)
        {
            ViewUser vuser = new ViewUser()
            {
                Name = user.Name
            };

            return vuser;
        }
    }
}