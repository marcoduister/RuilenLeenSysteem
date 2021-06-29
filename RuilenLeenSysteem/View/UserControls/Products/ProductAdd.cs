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
    public partial class ProductAdd : UserControl
    {
        private ProductController _ProductController;
        private CategoryController _CategoryController;
        private CustomerController _CustomerController;
        public ProductAdd()
        {
            InitializeComponent();
           
            _ProductController = new ProductController();
            _CategoryController = new CategoryController();
            _CustomerController = new CustomerController();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {

            List<Category> CategorieList = _CategoryController.GetAllCategories();
            List<Model.Customer> CustemerList = _CustomerController.GetAllCustomers();

            //this will fill the CustomerDrowDown
            FillCategorieDropDown(CategorieList);
            FillCustomerDropDown(CustemerList);
        }

        private void Btn_ProductAdd_Click(object sender, EventArgs e)
        {
            if ((int)Cbx_Customer.SelectedValue !=0)
            {
                if (_ProductController.AddProduct(Txt_ProductName.Text, Txt_ProductDescription.Text, int.Parse(Txt_ProductPoints.Text), (int)Cbx_ProductCategorie.SelectedValue, (int)Cbx_Customer.SelectedValue))

                {
                    MessageBox.Show("Uw heeft zo juist een Product aangemaakt");
                    Btn_Cancel_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Er is iets fout gedaan probeer het later opnieuw!! ");
                }
            }
            else
            {
                MessageBox.Show("Selecteer A.U.B de klant waar het vandaan komt!! ");
            }

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ProductOverview Page = new ProductOverview();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }


        private void FillCategorieDropDown(List<Category> CategoryList)
        {
            var Category = CategoryList.Select(A => new { Value = A.Id, Text = A.Name }).ToList();
            Category.Insert(0, new { Value = 0, Text = "--Select--" });
            Cbx_ProductCategorie.DataSource = Category;

            Cbx_ProductCategorie.ValueMember = "Value";
            Cbx_ProductCategorie.DisplayMember = "Text";
        }
        private void FillCustomerDropDown(List<Model.Customer> CustomerList)
        {
            var Customer = CustomerList.Select(A => new { Value = A.Id, Text = A.FirstName +" "+A.LastName }).ToList();
            Customer.Insert(0, new { Value = 0, Text = "--Select--" });
            Cbx_Customer.DataSource = Customer;

            Cbx_Customer.ValueMember = "Value";
            Cbx_Customer.DisplayMember = "Text";
        }

        private void Pbx_ProductImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dit is helaas nog niet uitgewerkt vanwegen tijd tekort");
        }
    }
}
