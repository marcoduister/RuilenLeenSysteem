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
        private string Name { get; set; }
        public int Points { get; set; }
        private string Description { get; set; }
        private byte Image  {get; set; }
        private int balance { get; set; }

        private int Maker_id { get; set; }
        private User User { get; set; }


        private int Categorie_id { get; set; }
        private Categorie Categorie  {get; set; }

    }
}
