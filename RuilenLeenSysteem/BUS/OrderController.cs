using RuilenLeenSysteem.DAL;
using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuilenLeenSysteem.BUS
{
    class OrderController
    {
        private OrderData _OrderDbData;
        private ProductData _ProductDbData;
        private CustomerData _CustomerDbData;

        public OrderController()
        {
            _OrderDbData = new OrderData();
            _ProductDbData = new ProductData();
            _CustomerDbData = new CustomerData();
        }

        internal bool AddTradeOrder(int product_id, int customer_id,int points)
        {
            bool created = false;
            if (_ProductDbData.ExistProductById(product_id))
            {
                if (_CustomerDbData.ExistCustomerById(customer_id))
                {
                    Customer Customer = _CustomerDbData.GetCustomersById(customer_id);
                    if (Customer.balance >= points)
                    {
                        Customer.balance -= points;
                        TradeOrder AddTradeOrder = new TradeOrder()
                        {
                            Product_id = product_id,
                            Customer_id = customer_id,
                            Order_Date = DateTime.Now
                        };

                        _OrderDbData.AddTradeOrder(AddTradeOrder);
                        _ProductDbData.EditStatus(product_id, Status.Sold);
                        _CustomerDbData.PointsExchange(customer_id, Customer.balance);
                        created = true;
                    }
                }
            }
            return created;
        }

        internal bool AddBorrowOrder(int product_id, int customer_id, int points, DateTime start, DateTime Eind)
        {
            bool created = false;
            if (_ProductDbData.ExistProductById(product_id))
            {
                if (_CustomerDbData.ExistCustomerById(customer_id))
                {
                    Customer Customer = _CustomerDbData.GetCustomersById(customer_id);
                    if (Customer.balance >= points)
                    {
                        Customer.balance -= points;
                        BorrowOrder AddBorrowOrder = new BorrowOrder()
                        {
                            Product_id = product_id,
                            Customer_id = customer_id,
                            Start_date = start,
                            End_Date = Eind,
                        };

                        _OrderDbData.AddBorrowOrder(AddBorrowOrder);
                        _ProductDbData.EditStatus(product_id, Status.Loaned);
                        _CustomerDbData.PointsExchange(customer_id, Customer.balance);
                        created = true;
                    }
                }
            }
            return created;
        }
    }
}
