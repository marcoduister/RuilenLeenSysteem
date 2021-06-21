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
        
        private int Total_points { 
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

        private List<TradeProduct> AllTradeProducts = new List<TradeProduct>();

        private  int Customer_id { get;  }
        private Customer _Customer { get; set; }
    }
}
