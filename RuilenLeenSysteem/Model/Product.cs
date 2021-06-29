using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    public class Product
    {
        // Property / Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public byte Image { get; set; }
        public Status Status { get; set; }
        public Type Type { get; set; }

        // Relationships
        public int Customer_Id { get; set; }
        public Customer Customer { get; set; }
        public int Categorie_id { get; set; }
        public Category Category { get; set; }

    }
}
