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
        private CustomerData _CustomerDbData;
        public ProductController()
        {
            _DbData = new ProductData();
            _CustomerDbData = new CustomerData();
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
                Product.Customer = _CustomerDbData.GetCustomersById(Product.Customer_Id);
            }
            return Product;
        }

        internal bool AddProduct(Product product)
        {
            bool Created = false;
            Created = _DbData.AddProduct(product);
            return Created;
        }

        internal List<Product> GetAllProducts()
        {
            return _DbData.GetAllProducts();
        }

        internal bool DeleteProduct(int Product_Id)
        {
            bool Deleted = false;
            if (_DbData.ExistProductById(Product_Id))
            {
                _DbData.DeleteProduct(Product_Id);
                Deleted = true;
            }

            return Deleted;
        }

        internal bool EditProduct(int Id, string Name, string Description, int Points, int Categorie_id, Status status)
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
                if (status == Status.GivingBack)
                    EditProduct.Status = Status.GivingBack;
                else if(status == Status.InStock)
                {
                    EditProduct.Status = Status.InStock;
                    Product produdct = GetProductById(Id);

                    Customer Customer = _CustomerDbData.GetCustomersById(produdct.Customer_Id);
                    Customer.balance += Points;
                    _CustomerDbData.PointsExchange(produdct.Customer_Id, Customer.balance);
                }
                    

                _DbData.EditProduct(EditProduct);
                
                created = true;
            }

            return created;
        }

        internal bool AddProduct( string Name, string Description, int Points, int Categorie_id, int Customer_id)
        {
            bool Created = false;
            if (_CustomerDbData.ExistCustomerById(Customer_id))
            {
                Customer Customer = _CustomerDbData.GetCustomersById(Customer_id);

                    Customer.balance += Points;
                    Product AddProduct = new Product()
                    {
                        Name = Name,
                        Description = Description,
                        Points = Points,
                        Status = Status.InStock,
                        Type = Model.Type.Trade,
                        Categorie_id = Categorie_id,
                        Customer_Id = Customer_id
                    };

                    Created = _DbData.AddProduct(AddProduct);
                    _CustomerDbData.PointsExchange(Customer_id, Customer.balance);
                
            }
            return Created;
        }
    }
}
