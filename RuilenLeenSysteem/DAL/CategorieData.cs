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
    class CategorieData : DataAcces
    {
        /*
         * Categorie
         * 
         * All functions for data handling for the categorie are below
         */

        public List<Category> GetAllCategories()
        {
            List<Category> ListOfCategory = new List<Category>();
            _Conn = new SqlConnection(ConnectionString);
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Select * From Category", _Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Category TempCategorie = new Category()
                        {
                            Id = Int32.Parse(oReader["Id"].ToString()),
                            Name = oReader["Name"].ToString(),
                            Description = oReader["Description"].ToString(),
                            Created_date = Convert.ToDateTime(oReader["Created_Date"].ToString()),

                        };
                        ListOfCategory.Add(TempCategorie);
                    }
                    _Conn.Close();
                }
            }
            return ListOfCategory;
        }

        internal void DeleteCategory(int Category_id)
        {
            _Conn = new SqlConnection(ConnectionString);
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"DELETE FROM [Category] WHERE Id ='{Category_id}'", _Conn);
                _Conn.Open();

                try
                {
                    SQLCmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    if (true)
                    {
                        MessageBox.Show("controleer AUB dat uw de Category nergens meer gebruikt de volgend error is er ontstaan");
                        MessageBox.Show(ex.Message);
                    }
                    
                }

                _Conn.Close();
            }
        }

        internal bool ExistCategoryById(int Category_Id)
        {
            bool ValidUser = false;
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                using (_Conn)
                {
                    SqlCommand SQLCmd = new SqlCommand($"Select * From [Category] where Id= '{Category_Id}' COLLATE SQL_Latin1_General_CP1_CS_AS", _Conn);
                    _Conn.Open();
                    using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                    {
                        if (oReader.HasRows)
                        {
                            ValidUser = true;
                        }
                        else
                        {
                            ValidUser = false;
                        }
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
            finally { _Conn.Dispose(); }
            return ValidUser;
        }

        public Category GetCategorieById(int Category_id)
        {
            Category Categorie = new Category();
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                using (_Conn)
                {
                    SqlCommand SQLCmd = new SqlCommand($"Select * From [Category] where Id= '{Category_id}' COLLATE SQL_Latin1_General_CP1_CS_AS", _Conn);
                    _Conn.Open();
                    using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            Categorie.Id = int.Parse(oReader["Id"].ToString());
                            Categorie.Name = oReader["Name"].ToString();
                            Categorie.Description = oReader["Description"].ToString();
                            Categorie.Created_date = DateTime.Parse(oReader["Created_date"].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
            finally { _Conn.Dispose(); }
            return Categorie;
        }


        public bool AddCategory(Category Category)
        {
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                _Conn.Open();
                String SQLString = $"INSERT INTO [Category] ([Name],[Description],[Created_Date])" +
                    $"VALUES('{Category.Name}', '{Category.Description}','{DateTime.Now.ToString("yyyy/MM/dd")}')";

                using (SqlCommand SQLCmd = new SqlCommand(SQLString, _Conn))
                {
                    SQLCmd.ExecuteNonQuery();
                }
                _Conn.Close();
            }
            catch (SqlException ex) { return false; throw ex; }
            finally { _Conn.Dispose(); }
            return true;
        }

        public void EditCategory(Category Category)
        {
            _Conn = new SqlConnection(ConnectionString);
            try
            {
                _Conn.Open();

                String SQLString = $"UPDATE [Category] SET" +
                    $"[Name] = '{Category.Name}', " +
                    $"[Description] = '{Category.Description}'" +
                    $" WHERE Id = {Category.Id};";

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
