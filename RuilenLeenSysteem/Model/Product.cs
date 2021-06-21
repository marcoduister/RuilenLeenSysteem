using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    class Product
    {
        protected int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string Description { get; set; }
        public byte Image  {get; set; }
        public int balance { get; set; }

        public int Maker_id { get; set; }
        public User User { get; set; }


        public int Categorie_id { get; set; }
        public Categorie Categorie  {get; set; }

    }
}
