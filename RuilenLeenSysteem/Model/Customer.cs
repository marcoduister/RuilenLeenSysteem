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
        public int _Id { get; }
        public string _Voornaam { get; set; }
        public string _Achternaam { get; set; }
        public string _Adress { get; set; }
        public string _Email { get; set; }
        public string TelefoonNummer { get; }

        public List<TradeOrder> AllTradeOrders = new List<TradeOrder>();
        public List<BorrowOrder> AllBorrowOrders = new List<BorrowOrder>();
    }
}
