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

namespace RuilenLeenSysteem.View.UserControls.Take
{
    public partial class TakeProduct : UserControl
    {
        private CustomerController _CustomerController = new CustomerController();

        public TakeProduct()
        {
            InitializeComponent();
        }

        private void TakeProduct_Load(object sender, EventArgs e)
        {

            //this wil get a list of Customers
            List<Customer> CustomerList = _CustomerController.GetAllCustomers();

            //this will fill the CustomerDrowDown
            FillCustomerDropDown(CustomerList);
        }
        private void FillCustomerDropDown(List<Customer> CustomerList)
        {
            var Customers = CustomerList.Where(A => A.BlackList == false).Select(A => new { Value = A.Id, Text = A.FirstName + " " + A.LastName }).ToList();
            Customers.Insert(0, new { Value = 0, Text = "--Select--" });
            Cbx_ProductCustomer.DataSource = Customers;

            Cbx_ProductCustomer.ValueMember = "Value";
            Cbx_ProductCustomer.DisplayMember = "Text";
        }

        private void Btn_TakeProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = Txt_ProductName.Text;
            product.Description = Txt_ProductDescription.Text;
            product.Customer_Id = (int)Cbx_ProductCustomer.SelectedValue;
            product.Type = Model.Type.Borrow;
            product.Status = Model.Status.OnderReview;

            ProductController _ProductController = new ProductController();
            _ProductController.AddProduct(product);
        }
    }
}
