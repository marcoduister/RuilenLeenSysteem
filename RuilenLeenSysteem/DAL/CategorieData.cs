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

        public List<Categorie> GetAllCategories()
        {
            List<Categorie> ListOfCategorie = new List<Categorie>();
            _Conn = new SqlConnection(ConnectionString);
            using (_Conn)
            {
                SqlCommand SQLCmd = new SqlCommand($"Select * From Category", _Conn);
                _Conn.Open();
                using (SqlDataReader oReader = SQLCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Categorie TempCategorie = new Categorie()
                        {
                            Id = Int32.Parse(oReader["Id"].ToString()),
                            Name = oReader["Name"].ToString(),
                            Description = oReader["Description"].ToString(),
                            Created_date = Convert.ToDateTime(oReader["Created_Date"].ToString()),

                        };
                        ListOfCategorie.Add(TempCategorie);
                    }
                    _Conn.Close();
                }
            }
            return ListOfCategorie;
        }

        public void GetCategorieById()
        {

        }

        public void DeleteCategories()
        {

        }

        public void AddCategories()
        {

        }

        public void EditCategories()
        {

        }
    }
}
