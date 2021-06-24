using System;
using RuilenLeenSysteem.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    class BorrowOrder
    {
        // Property / Attributes
        protected int Id { get; }
        public DateTime Start_date { get; set; }
        public DateTime Eind_date { get; set; }

        // Relationships
        public int Customer_id { get; }
        public Customer Customer { get; set; }
    }
}
