using RuilenLeenSysteem.BUS;
using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuilenLeenSysteem.View.UserControls.Products
{
    public partial class ProductEdit : UserControl
    {
        private ProductController _ProductController;
        private CategoryController _CategoryController;
        private int _Product_id;
        public ProductEdit(int Product_id)
        {
            InitializeComponent();
            _Product_id = Product_id;
            _ProductController = new ProductController();
            _CategoryController = new CategoryController();
        }

      

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            Product EditProduct = _ProductController.GetProductById(_Product_id);
            Txt_ProductName.Text = EditProduct.Name;
            Txt_ProductDescription.Text = EditProduct.Description;
            Txt_ProductPoints.Text = EditProduct.Points.ToString();
            string customerName = EditProduct.Customer.FirstName + " " + EditProduct.Customer.LastName;
            Txt_Customer.Text = customerName;
            // Cbx_ProductCategorie.Text = EditCustomer.Email;



            List<Category> CategorieList = _CategoryController.GetAllCategories();

            //this will fill the CustomerDrowDown
            FillCategorieDropDown(CategorieList, EditProduct.Categorie_id);

        }
        private void FillCategorieDropDown(List<Category> CategorieList,int category_id)
        {
            
            var Categorie = CategorieList.Select(A => new { Value = A.Id, Text = A.Name }).ToList();
            Categorie.Insert(0, new { Value = 0, Text = "--Select--" });
            Cbx_ProductCategorie.DataSource = Categorie;

            Cbx_ProductCategorie.ValueMember = "Value";
            Cbx_ProductCategorie.DisplayMember = "Text";
            int index = Cbx_ProductCategorie.Items.IndexOf(Categorie.Where(e => e.Value != category_id).First());
            Cbx_ProductCategorie.SelectedIndex = index;
        }




        private void Cbx_ProductCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_ProductEdit_Click(object sender, EventArgs e)
        {
            if (_ProductController.EditProduct(_Product_id, Txt_ProductName.Text, Txt_ProductDescription.Text, int.Parse(Txt_ProductPoints.Text), (int)Cbx_ProductCategorie.SelectedValue,Status.Sold))
            {
                MessageBox.Show("Uw heeft zo juist een Product bewerkt");
                Btn_Cancel_Click(null, null);
            }
            else
            {
                MessageBox.Show("Er is iets fout gedaan probeer het later opnieuw!! ");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ProductOverview Page = new ProductOverview();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }
    }
}
