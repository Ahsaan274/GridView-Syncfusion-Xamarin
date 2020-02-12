using System;
using System.Collections.Generic;
using System.Text;

namespace Grid.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string UserName, string Password)
        {
            this.Username = UserName;
            this.Password = Password;
        }
        public bool Check()
        {

            if (!this.Username.Equals("") && !this.Password.Equals(""))
            {
                return true;

            }
            else
                return false;
        }
    }
}
