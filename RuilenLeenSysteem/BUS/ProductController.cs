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

        internal Product GetProductById(int product_id)
        {
            Product Product = new Product();
            if (_DbData.ExistProductById(product_id))
            {
                Product = _DbData.GetProductById(product_id);
            }
            return Product;
        }

        internal List<Product> GetAllProducts()
        {
            return _DbData.GetAllProducts();
        }

        internal bool DeleteProduct(int Id)
        {
            bool Deleted = false;
            if (_DbData.ExistProductById(Id))
            {
                _DbData.DeleteProduct(Id);
                Deleted = true;
            }

            return Deleted;
        }

        internal bool EditProduct(int Id, string Name, string Description, int Points, int Categorie_id)
        {
            bool created = false;
            if (_DbData.ExistProductById(Id))
            {
                Product EditProduct = new Product()
                {
                    Id = Id,
                    Name = Name,
                    Description = Description,
                    Points = Points,
                    Categorie_id = Categorie_id,
                };
                _DbData.EditProduct(EditProduct);
                created = true;
            }

            return created;
        }

        internal bool AddProduct( string Name, string Description, int Points, int Categorie_id)
        {
            bool created = false;
            Product AddProduct = new Product()
            {
                Name = Name,
                Description = Description,
                Points = Points,
                Categorie_id = Categorie_id,
            };
            created = _DbData.AddProduct(AddProduct);

            return created;

        }




    }
}
