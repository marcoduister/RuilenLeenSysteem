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
        private SqlConnection _conn;

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
            _conn = new SqlConnection(ConnectionString);
        }

        public void test()
        {
            try
            {
                _conn.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            List<User> ListOfUsers = new List<User>();
            using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            {
                string oString = "SELECT * FROM [User]";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        User TempUser = new User()
                        {
                            _Voornaam = oReader["FirstName"].ToString(),
                            _Achternaam = oReader["LastName"].ToString(),
                            _Email = oReader["Email"].ToString()
                        };
                        ListOfUsers.Add(TempUser);
                    }

                    myConnection.Close();
                }
            }
            string hahahahahah = "";
        }

    }
}
