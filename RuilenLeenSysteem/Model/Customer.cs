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
        protected string TelefoonNummer { get; }

        private List<TradeOrder> AllTradeOrders = new List<TradeOrder>();
        private List<BorrowOrder> AllBorrowOrders = new List<BorrowOrder>();
    }
}
