﻿using RuilenLeenSysteem.BUS;
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
    public class DataAcces
    {
        private string ConnectionString = "Data Source=.;Initial Catalog=RuilWinkelVaals.DEV; Integrated Security=SSPI;";
        public SqlConnection _Conn;

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
    }
}
