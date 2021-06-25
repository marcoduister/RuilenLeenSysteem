using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    class TradeOrder
    {
        // Property / Attributes
        protected int Id { get; }
        public DateTime Order_Date { get; set; }

        // Relationships
        public int Prdouct_id { get; set; }
        public Product Product = new Product();

        public int Customer_id { get; }
        public Customer Customer { get; set; }
    }
}
