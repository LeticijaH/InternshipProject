using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Operator
    {
        private string _name;
        public string Name {get { return _name; } }
        private string _lastName;
        public string LastName{get { return _lastName; }}

        private string _userName;
        public string UserName { get { return _userName; } }
        private string _password;
        public string Password { get { return _password; } }
        public Operator(string Name, string LastName, string UserName, string Password)
        {
            _name = Name;
            _lastName = LastName;
            _userName = UserName;
            _password = Password;
        }
    }
}
