using RuilenLeenSysteem.BUS;
using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Type = RuilenLeenSysteem.Model.Type;

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
            _Conn = new SqlConnection(ConnectionString);
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
                            Description = oReader["Description"].ToString(),
                            Points = Int32.Parse(oReader["Points"].ToString()),
                            Status = (Status)Int32.Parse(oReader["Status"].ToString()),
                            Type = (Type)Int32.Parse(oReader["Type"].ToString()),
                            
                        };
                        if ( oReader["Category_Id"].ToString() != "")
                        {
                            TempProduct.Categorie_id = Int32.Parse(oReader["Category_Id"].ToString());
                            
                        }
                        if (oReader["Customer_Id"].ToString() != "")
                        {
                            TempProduct.Customer_Id = Int32.Parse(oReader["Customer_Id"].ToString());
                        }
                        ListOfProducts.Add(TempProduct);
                    }
                    _Conn.Close();
                }
            }
            return ListOfProducts;
        }

        internal void EditStatus(int product_id, Status Status)
        {
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                _Conn.Open();

                String SQLString = $"UPDATE Product SET " +
                    $"Status = {(int)Status}" +
                    $"WHERE Id = {product_id};";

                using (SqlCommand SQLCmd = new SqlCommand(SQLString, _Conn))
                {
                    SQLCmd.ExecuteNonQuery();
                }
                _Conn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { _Conn.Dispose(); }
        }

        internal bool ExistProductById(int product_id)
        {
            bool ProductExist = false;
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                using (_Conn)
                {
                    SqlCommand SQLCmd = new SqlCommand($"Select * From [Product] where Id= '{product_id}' COLLATE SQL_Latin1_General_CP1_CS_AS", _Conn);
                    _Conn.Open();
                    using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                    {
                        if (oReader.HasRows)
                        {
                            ProductExist = true;
                        }
                        else
                        {
                            ProductExist = false;
                        }
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
            finally { _Conn.Dispose(); }
            return ProductExist;
        }

        internal List<Product> GetAllProductsByType(Type type)
        {
            List<Product> ListOfProducts = new List<Product>();
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Select * From Product where Type ={(int)type}", _Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Product _Product = new Product()
                        {
                            Id = Int32.Parse(oReader["Id"].ToString()),
                            Name = oReader["Name"].ToString(),
                            Description = oReader["Description"].ToString(),
                            Points = Int32.Parse(oReader["Points"].ToString()),
                            Status = (Status)Int32.Parse(oReader["Status"].ToString()),
                        };
                        ListOfProducts.Add(_Product);
                    }
                    _Conn.Close();
                }
            }
            return ListOfProducts;
        }

        public Product GetProductById(int Id)
        {
            Product product = new Product();
            _Conn = new SqlConnection(ConnectionString);
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
                        product.Description = oReader["Description"].ToString();
                        product.Points = Int32.Parse(oReader["points"].ToString());
                        product.Status = (Status)Int32.Parse(oReader["Status"].ToString());
                        product.Type = (Type)Int32.Parse(oReader["Type"].ToString());
                        product.Customer_Id = Int32.Parse(oReader["Customer_Id"].ToString());
                    }
                    _Conn.Close();
                }
            }
            return product;
        }

        public void DeleteProduct(int Id)
        {
            _Conn = new SqlConnection(ConnectionString);
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Delete From Product where Id ='{Id}'", _Conn);
                _Conn.Open();

                try
                {
                    SQLCmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                _Conn.Close();
            }
        }

        public bool AddProduct(Product product)
        {

            _Conn = new SqlConnection(ConnectionString);
            try
            {
                _Conn.Open();
                string SQLString = string.Empty;
                if (product.Categorie_id == 0)
                {
                    SQLString = $"INSERT INTO [Product]([Name],[Description],[Points]," +
                    $"[Status],[Type],[Customer_Id]) VALUES('{product.Name}','{product.Description}'," +
                    $"{product.Points},{(int)product.Status},{(int)product.Type},{product.Customer_Id});";
                }
                else
                {
                    SQLString = $"INSERT INTO [Product]([Name],[Description],[Points]," +
                    $"[Status],[Type],[Category_Id],[Customer_Id]) VALUES('{product.Name}','{product.Description}'," +
                    $"{product.Points},{(int)product.Status},{(int)product.Type},{product.Categorie_id},{product.Customer_Id});";
                }

                using (SqlCommand SQLCmd = new SqlCommand(SQLString, _Conn))
                {
                    SQLCmd.ExecuteNonQuery();
                }
                _Conn.Close();
            }
            catch (SqlException ex) 
            { 
                return false;  }
            finally { _Conn.Dispose();  }
            return true;

        }

        public void EditProduct(Product product)
        {
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                _Conn.Open();
                String SQLString = string.Empty;
                if (product.Categorie_id != 0)
                {
                    SQLString = $"UPDATE [Product] SET [Name] ='{product.Name}',[Description] = '{product.Description}'" +
                    $",[Points] = {product.Points}, [Category_Id] = {product.Categorie_id} WHERE Id = {product.Id}; ";
                }
                else
                {
                    SQLString = $"UPDATE [Product] SET [Name] ='{product.Name}',[Description] = '{product.Description}'" +
                    $",[Points] = {product.Points}, [Status] = {(int)product.Status} WHERE Id = {product.Id}; ";
                }


                using (SqlCommand SQLCmd = new SqlCommand(SQLString, _Conn))
                {
                    SQLCmd.ExecuteNonQuery();
                }
                _Conn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { _Conn.Dispose(); }

        }


    }
}
