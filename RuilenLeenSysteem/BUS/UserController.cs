using RuilenLeenSysteem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.BUS
{
    class UserController
    {
        private DataAcces _DBContext;

        public UserController()
        {
            _DBContext = new DataAcces();
        }

        public bool LogIn(string Email, string Password)
        {
            bool LoggedIn = _DBContext.VerifyAccount(Email, Password);
            if (LoggedIn)
            {

            }

            return LoggedIn;
        }

        public bool LogOut()
        {
            return false;
        }
    }
}
