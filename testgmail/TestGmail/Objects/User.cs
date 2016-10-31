using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGmail
{
    public class User
    {
        public readonly string Name;
        public readonly string Password;

        public User(string Name, string Password)
        {
            this.Name = Name;
            this.Password = Password;
        }
    }
}
