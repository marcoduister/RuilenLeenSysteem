using RuilenLeenSysteem.BUS;
using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuilenLeenSysteem.DAL
{
    class UserData : DataAcces
    {
        /*
         * User
         * 
         * All functions for data handling for the user are below
         */
        DataAcces dbAcces = new  DataAcces();
        public bool VerifyAccount(User User)
        {
            bool ValidUser = false;

            using (dbAcces._Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Select * From [User] where UserName='{User.UserName}' AND Password='{User.Password}' COLLATE SQL_Latin1_General_CP1_CS_AS", _Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        ValidUser = true;
                    }
                    else
                    {
                        ValidUser = false;
                    }
                }
            }

            _Conn.Close();
            return ValidUser;
        }

    }
}
