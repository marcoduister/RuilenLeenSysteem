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
    class OrderData : DataAcces
    {
        /*
         * Order
         * 
         * All functions for data handling for the order are below
         */

        public void GetAllOrders()
        {

        }

        public void GetAllTradeOrders()
        {

        }

        public void GetAllBorrowOrders()
        {

        }

        public void GetOrderById()
        {

        }

        public void DeleteOrder()
        {

        }

        public void AddTradeOrder()
        {

        }

        public void AddBorrowOrder()
        {

        }

        public void EditTradeOrders()
        {

        }

        public void EditBorrowOrders()
        {

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
                            Start_date = DateTime.Parse(oReader["Start_date"].ToString()),
                            Eind_date = DateTime.Parse(oReader["Eind_date"].ToString()),
                            Product = tmpproduct,
                        };

                        ListBorrowOrders.Add(TempCustomer);
                    }
                    _Conn.Close();
                }
            }
            return ListBorrowOrders;
        }
    }
}
