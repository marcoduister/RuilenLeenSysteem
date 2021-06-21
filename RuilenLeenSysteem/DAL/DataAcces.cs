using RuilenLeenSysteem.BUS;
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
        private string ConnectionString = @"Data Source=.;Initial Catalog=I-CITE_db;Integrated Security=True";
        private SqlConnection connection;

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
            connection = new SqlConnection(ConnectionString);
        }

    }
}
