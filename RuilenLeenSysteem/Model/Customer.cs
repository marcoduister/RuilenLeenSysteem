using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    class Customer
    {
        public int Id { get; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int balance { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; }

        public List<TradeOrder> AllTradeOrders = new List<TradeOrder>();
        public List<BorrowOrder> AllBorrowOrders = new List<BorrowOrder>();
    }
}
