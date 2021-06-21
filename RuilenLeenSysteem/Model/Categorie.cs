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
        private string  Name { get; set; }
        private string Description { get; set; }

        private List<Product> AllProducts = new List<Product>();

    }
}
