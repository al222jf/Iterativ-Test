using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkod
{
    class Login
    {
        private string _user;
        private string _password;


        public string User
        {
            get { return _user; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Användarnamnet är tomt!");
                }
                _user = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set 
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Lösenordet är tomt!");
                }
                _password = value;
            }
        }

        public void UserValidate()
        {
            if (User != "stefan")
            {
                throw new ArgumentException("Fel användarnamn");
            }
        }

        public void PasswordValidate()
        {
            if (Password != "rules")
            {
                throw new ArgumentException("Fel lösenord!");
            }
        }



        public Login()
        {

        }
    }
}
