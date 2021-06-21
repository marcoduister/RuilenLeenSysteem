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
        private int Total_points
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

        private List<BorrowProduct> AllBorrowProducts = new List<BorrowProduct>();

        private int Customer_id { get; }
        private Customer _Customer { get; set; }
    }
}
