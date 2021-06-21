using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    class TradeOrder
    {
        protected int  Id { get; }

        public int Total_points { 
            get 
            {
                int points = 0;
                foreach (var product in AllTradeProducts)
                {
                    points += product.Points;
                }
                return points;
            } 
        }

        public List<TradeProduct> AllTradeProducts = new List<TradeProduct>();

        public int Customer_id { get;  }
        public Customer Customer { get; set; }
    }
}
