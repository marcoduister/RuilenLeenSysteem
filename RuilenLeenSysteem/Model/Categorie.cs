using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    class Categorie
    {
        // Property / Attributes
        protected int Id { get; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public DateTime Created_date { get; set; }

        // Relationships
        public List<Product> AllProducts = new List<Product>();

    }
}
