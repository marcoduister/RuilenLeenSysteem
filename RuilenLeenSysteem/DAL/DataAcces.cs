using RuilenLeenSysteem.BUS;
using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.DAL
{
    class DataAcces
    {
        private string ConnectionString = "Data Source=.;Initial Catalog=RuilWinkelVaals.DEV; Integrated Security=SSPI;";
        private SqlConnection _Conn;

        /// <summary>
        /// Constructor
        /// </summary>
        public DataAcces()
        {
            InitializeDatabase();
  
        }

        /// <summary>
        /// Initialize the connection to the database
        /// </summary>
        public void InitializeDatabase()
        {
            _Conn = new SqlConnection(ConnectionString);
        }


        /*
         * User
         * 
         * All functions for data handling for the user are below
         */

        public bool VerifyAccount(string Email,String Password)
        {
            bool ValidUser = false;

            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Select * From [User] where Email='{Email}' AND Password='{Password}' COLLATE SQL_Latin1_General_CP1_CS_AS", _Conn);
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

        public void GetAllUsers()
        {

            List<User> ListOfUsers = new List<User>();
            using (_Conn)
            {
                string Email = "marco@zuyd.nlq";
                SqlCommand SQLCmd = new SqlCommand($"Select * From [User] where Email='{Email}';", _Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        User TempUser = new User()
                        {
                            Id = Int16.Parse(oReader["Id"].ToString()),
                            UserName = oReader["Email"].ToString(),
                            Password = oReader["Password"].ToString()
                        };
                        ListOfUsers.Add(TempUser);
                    }
                    _Conn.Close();
                }
            }
        }


        /*
         * Customer
         * 
         * All functions for data handling for the customer are below
         */

        /*
         * Order
         * 
         * All functions for data handling for the order are below
         */

        /*
         * Product
         * 
         * All functions for data handling for the product are below
         */

        /*
         * Category
         * 
         * All functions for data handling for the category are below
         */
    }
}
