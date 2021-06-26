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
    public class OrderData : DataAcces
    {
        /*
         * Order
         * 
         * All functions for data handling for the order are below
         */

        internal List<BorrowOrder> GetAllBorrowOrdersByCustomerId(int Id)
        {
            List<BorrowOrder> ListBorrowOrders = new List<BorrowOrder>();
            _Conn = new SqlConnection(ConnectionString);
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"SELECT * FROM BorrowOrder M " +
                    $"LEFT JOIN Product T ON M.Product_id = T.Id " +
                    $"WHERE M.Customer_id = {Id}; ", _Conn);

                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Product tmpproduct = new Product()
                        {
                            Name = oReader["Name"].ToString(),
                            Points = int.Parse(oReader["Points"].ToString())
                        };

                        BorrowOrder TempCustomer = new BorrowOrder()
                        {
                            Start_date = DateTime.Parse(oReader["Start_Date"].ToString()),
                            End_Date = DateTime.Parse(oReader["End_Date"].ToString()),
                            Product = tmpproduct,
                        };

                        ListBorrowOrders.Add(TempCustomer);
                    }
                    _Conn.Close();
                }
            }
            return ListBorrowOrders;
        }

        internal List<TradeOrder> GetAllBTradeOrdersByCustomerId(int Id)
        {
            List<TradeOrder> ListTradeOrders = new List<TradeOrder>();
            _Conn = new SqlConnection(ConnectionString);
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"SELECT * FROM TradeOrder M " +
                    $"LEFT JOIN Product T ON M.Product_id = T.Id " +
                    $"WHERE M.Customer_id = {Id}; ", _Conn);

                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Product tmpproduct = new Product()
                        {
                            Name = oReader["Name"].ToString(),
                            Points = int.Parse(oReader["Points"].ToString())
                        };

                        TradeOrder TempCustomer = new TradeOrder()
                        {
                            Order_Date = DateTime.Parse(oReader["Order_Date"].ToString()),
                            Product = tmpproduct
                        };
                        ListTradeOrders.Add(TempCustomer);
                    }
                    _Conn.Close();
                }
            }
            return ListTradeOrders;
        }

        internal void AddTradeOrder(TradeOrder TradeOrder)
        {
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                _Conn.Open();
                
                 String SQLString = $"INSERT INTO [TradeOrder] ([Order_Date],[Customer_Id],[Product_Id])" +
                    $"VALUES('{TradeOrder.Order_Date.ToString("yyyy/MM/dd")}'," +
                    $"{TradeOrder.Customer_id}, {TradeOrder.Product_id})";

                using (SqlCommand SQLCmd = new SqlCommand(SQLString, _Conn))
                {
                    SQLCmd.ExecuteNonQuery();
                }
                _Conn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { _Conn.Dispose(); }
        }


        internal void AddBorrowOrder(BorrowOrder BorrowOrder)
        {
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                _Conn.Open();

                String SQLString = $"INSERT INTO [BorrowOrder]" +
                    $"([Start_Date],[End_Date],[Product_Id],[Customer_Id])" +
                    $"VALUES('{BorrowOrder.Start_date.ToString("yyyy/MM/dd")}', " +
                    $"'{BorrowOrder.End_Date.ToString("yyyy/MM/dd")}', {BorrowOrder.Product_id}, {BorrowOrder.Customer_id})";

                using (SqlCommand SQLCmd = new SqlCommand(SQLString, _Conn))
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
