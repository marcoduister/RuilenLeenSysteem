using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    class Categorie
    {
        protected int Id { get; }
        public string  Name { get; set; }
        public string Description { get; set; }

        public List<Product> AllProducts = new List<Product>();

    }
}
