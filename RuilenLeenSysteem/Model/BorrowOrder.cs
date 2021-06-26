using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    public class BorrowOrder
    {
        // Property / Attributes
        public int Id { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_Date { get; set; }

        // Relationships
        public int Product_id { get; set; }
        public Product Product { get; set; }

        public int Customer_id { get; set; }
        public Customer Customer { get; set; }
    }
}
