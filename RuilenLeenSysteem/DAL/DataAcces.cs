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

        public void GetAllUsers()
        {

            List<User> ListOfUsers = new List<User>();
            using (_Conn)
            {

                SqlCommand SQLCmd = new SqlCommand("SELECT * FROM [User]", _Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        User TempUser = new User()
                        {
                            Id = Int16.Parse(oReader["Id"].ToString()),
                            FirstName = oReader["FirstName"].ToString(),
                            LastName = oReader["LastName"].ToString(),
                            Email = oReader["Email"].ToString(),
                            Password = oReader["Password"].ToString()
                        };
                        ListOfUsers.Add(TempUser);
                    }
                    _Conn.Close();
                }
            }
        }
    }
}
