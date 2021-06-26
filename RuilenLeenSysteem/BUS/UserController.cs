using RuilenLeenSysteem.DAL;
using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.BUS
{
    class UserController
    {
        private UserData _UserData;

        public UserController()
        {
            _UserData = new UserData();
        }

        public bool LogIn(Roll UserRoll)
        {
            User CurrentUser = new User();
            if (UserRoll == Roll.Admin)
            {
                CurrentUser.UserName = "Beheerder";
                CurrentUser.Password = "Qwerty3";
            }
            bool LoggedIn = _UserData.VerifyAccount(CurrentUser);
            return LoggedIn;
        }

        public bool LogOut()
        {
            return false;
        }
    }
}
