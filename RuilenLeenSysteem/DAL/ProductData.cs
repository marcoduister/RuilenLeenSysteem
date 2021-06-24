using RuilenLeenSysteem.BUS;
using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuilenLeenSysteem.DAL
{
    class ProductData : DataAcces
    {
        /*
         * Product
         * 
         * All functions for data handling for the product are below
         */

        public List<Product> GetAllProducts()
        {
            List<Product> ListOfProducts = new List<Product>();
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Select * From Product", _Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Product TempProduct = new Product()
                        {
                            Id = Int32.Parse(oReader["Id"].ToString()),
                            Name = oReader["Name"].ToString(),
                            Description = oReader["Desctiption"].ToString(),
                            Worth = Int32.Parse(oReader["worth"].ToString()),
                            Status = Int32.Parse(oReader["Status"].ToString()),
                            Type = Int32.Parse(oReader["Type"].ToString()),
                            Categorie_Id = Int32.Parse(oReader["Categorie_Id"].ToString()),
                            Customer_Id = Int32.Parse(oReader["Customer_Id"].ToString()),
                            Maker_Id = Int32.Parse(oReader["Maker_Id"].ToString()),
                        };
                        ListOfProducts.Add(TempProduct);
                    }
                    _Conn.Close();
                }
            }
            return ListOfProducts;
        }

        public List<Product> GetAllTradeProducts()
        {
            List<Product> ListOfTradeProducts = new List<Product>();
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Select * From Product where Type ='2'", _Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Product TempTradeProduct = new Product()
                        {
                            Id = Int32.Parse(oReader["Id"].ToString()),
                            Name = oReader["Name"].ToString(),
                            Description = oReader["Desctiption"].ToString(),
                            Worth = Int32.Parse(oReader["worth"].ToString()),
                            Status = Int32.Parse(oReader["Status"].ToString()),
                            Type = Int32.Parse(oReader["Type"].ToString()),
                            Categorie_Id = Int32.Parse(oReader["Categorie_Id"].ToString()),
                            Customer_Id = Int32.Parse(oReader["Customer_Id"].ToString()),
                            Maker_Id = Int32.Parse(oReader["Maker_Id"].ToString()),
                        };
                        ListOfTradeProducts.Add(TempTradeProduct);
                    }
                    _Conn.Close();
                }
            }
            return ListOfTradeProducts;
        }

        public List<Product> GetAllBorrowProducts()
        {
            List<Product> ListOfBorrowProducts = new List<Product>();
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Select * From Product where Type ='2'", _Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Product TempBorrowProduct = new Product()
                        {
                            Id = Int32.Parse(oReader["Id"].ToString()),
                            Name = oReader["Name"].ToString(),
                            Description = oReader["Desctiption"].ToString(),
                            Worth = Int32.Parse(oReader["worth"].ToString()),
                            Status = Int32.Parse(oReader["Status"].ToString()),
                            Type = Int32.Parse(oReader["Type"].ToString()),
                            Categorie_Id = Int32.Parse(oReader["Categorie_Id"].ToString()),
                            Customer_Id = Int32.Parse(oReader["Customer_Id"].ToString()),
                            Maker_Id = Int32.Parse(oReader["Maker_Id"].ToString()),
                        };
                        ListOfBorrowProducts.Add(TempBorrowProduct);
                    }
                    _Conn.Close();
                }
            }
            return ListOfBorrowProducts;
        }

        public Product GetProductById(int Id)
        {
            Product product = new Product();
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Select * From Product where Id ='{Id}'", _Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        product.Id = Int32.Parse(oReader["Id"].ToString());
                        product.Name = oReader["Name"].ToString();
                        product.Description = oReader["Desctiption"].ToString();
                        product.Worth = Int32.Parse(oReader["Worth"].ToString());
                        product.Status = Int32.Parse(oReader["Status"].ToString());
                        product.Type = Int32.Parse(oReader["Type"].ToString());
                        product.Categorie_Id = Int32.Parse(oReader["Categorie_Id"].ToString());
                        product.Customer_Id = Int32.Parse(oReader["Customer_Id"].ToString());
                        product.Maker_Id = Int32.Parse(oReader["Maker_Id"].ToString());
                    }
                    _Conn.Close();
                }
            }
            return product;
        }

        public void DeleteProduct(int Id)
        {
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Delete From Product where Id ='{Id}'", _Conn);
                _Conn.Open();

                try
                {
                    SQLCmd.ExecuteNonQuery();
                    MessageBox.Show("delete successful");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                _Conn.Close();
            }
        }

        public void AddProduct(Product product)
        {
            using (_Conn)
            {
                // Idk of deze query et doet        #TODO
                SqlCommand SQLCmd = new SqlCommand($"Insert Into Product values ({product.Name}, {product.Description}, {product.Worth}, {product.Status}, {product.Type}, {product.Categorie_Id}, {product.Customer_Id}, {product.Maker_Id})", _Conn);
                _Conn.Open();

                try
                {
                    SQLCmd.ExecuteNonQuery();
                    MessageBox.Show("Add successful");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                _Conn.Close();
            }
        }

        public void EdidtProduct(Product product)
        {
            using (_Conn)
            {
                // Idk of deze query et doet        #TODO
                SqlCommand SQLCmd = new SqlCommand($"Update Product set ({product.Id}, {product.Name}, {product.Description}, {product.Worth}, {product.Status}, {product.Type}, {product.Categorie_Id}, {product.Customer_Id}, {product.Maker_Id})", _Conn);
                _Conn.Open();

                try
                {
                    SQLCmd.ExecuteNonQuery();
                    MessageBox.Show("Update successful");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                _Conn.Close();
            }
        }
    }
}
