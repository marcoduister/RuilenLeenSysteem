using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    class BorrowOrder
    {
        protected int Id { get; }
        public int Total_points
        {
            get
            {
                int points = 0;
                foreach (var product in AllBorrowProducts)
                {
                    points += product.Points;
                }
                return points;
            }
        }

        public List<BorrowProduct> AllBorrowProducts = new List<BorrowProduct>();

        public int Customer_id { get; }
        public Customer Customer { get; set; }
    }
}
