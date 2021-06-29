using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    public class Category
    {
        // Property / Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created_date { get; set; }

        // Relationships
        public List<Product> AllProducts = new List<Product>();

    }
}
