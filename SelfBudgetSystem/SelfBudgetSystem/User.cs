using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBudgetSystem
{
    class User
    {
        public string name;
        public string login;
        public string password;

        public User (string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }
    }
}
