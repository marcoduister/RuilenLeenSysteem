using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    public class Customer
    {
        // Property / Attributes
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int balance { get; set; }
        public Boolean BlackList { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Created_date { get; set; }


        // Relationships
        public List<TradeOrder> AllTradeOrders = new List<TradeOrder>();
        public List<BorrowOrder> AllBorrowOrders = new List<BorrowOrder>();
        public List<Product> AllBGivenProducts = new List<Product>();
    }
}
