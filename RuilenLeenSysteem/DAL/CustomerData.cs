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
    class CustomerData : DataAcces
    {
        /*
         * Customer
         * 
         * All functions for data handling for the customer are below
         */

        internal List<Customer> GetAllCustomers()
        {
            List<Customer> ListOfCustomers = new List<Customer>();
            _Conn = new SqlConnection(ConnectionString);
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"SELECT * FROM Customer",_Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Customer TempCustomer = new Customer()
                        {
                            Id = int.Parse(oReader["Id"].ToString()),
                            FirstName = oReader["FirstName"].ToString(),
                            LastName = oReader["LastName"].ToString(),
                            Adress = oReader["Adress"].ToString(),
                            balance = int.Parse(oReader["balance"].ToString()),
                            BlackList = bool.Parse(oReader["BlackList"].ToString()),
                            PhoneNumber = int.Parse(oReader["PhoneNumber"].ToString()),
                            Email = oReader["Email"].ToString(),
                            Created_date = DateTime.Parse(oReader["Created_date"].ToString())
                        };
                        ListOfCustomers.Add(TempCustomer);
                    }
                    _Conn.Close();
                }
            }
            return ListOfCustomers;
        }

        internal bool ExistCustomerByEmail(string email)
        {
            bool ValidUser = false;
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                using (_Conn)
                {
                    SqlCommand SQLCmd = new SqlCommand($"Select * From [Customer] where Email= '{email}' COLLATE SQL_Latin1_General_CP1_CS_AS",_Conn);
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
            }
            catch (SqlException ex) { throw ex; }
            finally { _Conn.Dispose();  }
            return ValidUser;
        }


        internal void AddCustomer(Customer Customer)
        {

            _Conn = new SqlConnection(ConnectionString);
            try
            {
                _Conn.Open();
                String SQLString = $"INSERT INTO Customer ([FirstName],[LastName]," +
                    $"[Adress],[Balance],[PhoneNumber],[Email],[Created_Date],[BlackList])" +
                    $"VALUES('{Customer.FirstName}', '{Customer.LastName}', '{Customer.Adress}', {0},{Customer.PhoneNumber}" +
                    $",'{Customer.Email}','{DateTime.Now.ToString("yyyy/MM/dd")}',{0})";

                using (SqlCommand SQLCmd = new SqlCommand(SQLString,_Conn))
                {
                    SQLCmd.ExecuteNonQuery();
                }
                _Conn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally {_Conn.Dispose(); }
        }
        internal void UpdateCustomer(Customer Customer)
        {
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                _Conn.Open();

                String SQLString = $"UPDATE Customer SET " +
                    $"FirstName = '{Customer.FirstName}', " +
                    $"LastName = '{Customer.LastName}'," +
                    $"Adress = '{Customer.Adress}'," +
                    $"BlackList = '{Customer.balance}'," +
                    $"PhoneNumber = '{Customer.PhoneNumber}'," +
                    $"Email = '{Customer.Email}' WHERE Id = {Customer.Id};";

                using (SqlCommand SQLCmd = new SqlCommand(SQLString,_Conn))
                {
                    SQLCmd.ExecuteNonQuery();
                }
                _Conn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally {_Conn.Dispose(); }
        }

        internal void DeleteCustomers(int Id)
        {
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                _Conn.Open();

                String SQLString = $"Delete Customer Where Id ={Id}";

                using (SqlCommand SQLCmd = new SqlCommand(SQLString,_Conn))
                {
                    SQLCmd.ExecuteNonQuery();
                }
               _Conn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { _Conn.Dispose(); }
        }
    }
}
