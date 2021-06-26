using RuilenLeenSysteem.DAL;
using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.BUS
{
    class ProductController
    {
        private ProductData _DbData;
        public ProductController()
        {
            _DbData = new ProductData();
        }
        internal List<Product> GetAllProductsByType(Model.Type Type)
        {
            return _DbData.GetAllProductsByType(Type);
        }
    }
}
