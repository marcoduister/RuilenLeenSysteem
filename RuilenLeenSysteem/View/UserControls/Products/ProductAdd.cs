using RuilenLeenSysteem.BUS;
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
    public partial class ProductAdd : UserControl
    {
        private ProductController _ProductController;
        private CategoryController _CategoryController;
        public ProductAdd()
        {
            InitializeComponent();
           
            _ProductController = new ProductController();
            _CategoryController = new CategoryController();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {

            List<Model.Categorie> CategorieList = _CategoryController.GetAllCategories();

            //this will fill the CustomerDrowDown
            FillCategorieDropDown(CategorieList);
        }

        private void Btn_ProductAdd_Click(object sender, EventArgs e)
        {
            if (_ProductController.AddProduct(Txt_ProductName.Text, Txt_ProductDescription.Text, int.Parse(Txt_ProductPoints.Text), (int)Cbx_ProductCategorie.SelectedValue))

            {
                MessageBox.Show("Uw heeft zo juist een Product aangemaakt");
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

        private void Txt_ProductPoints_TextChanged(object sender, EventArgs e)
        {

        }


        private void FillCategorieDropDown(List<Model.Categorie> CategorieList)
        {
            var Categorie = CategorieList.Select(A => new { Value = A.Id, Text = A.Name }).ToList();
            Categorie.Insert(0, new { Value = 0, Text = "--Select--" });
            Cbx_ProductCategorie.DataSource = Categorie;

            Cbx_ProductCategorie.ValueMember = "Value";
            Cbx_ProductCategorie.DisplayMember = "Text";
        }

        private void Pbx_ProductImage_Click(object sender, EventArgs e)
        {

        }
    }
}
