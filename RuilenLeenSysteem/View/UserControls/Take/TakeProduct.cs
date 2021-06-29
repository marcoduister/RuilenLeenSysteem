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
        ProductController _ProductController = new ProductController();
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
            if ((int)Cbx_ProductCustomer.SelectedValue != 0)
            {
                Product product = new Product();
                product.Name = Txt_ProductName.Text;
                product.Description = Txt_ProductDescription.Text;
                product.Customer_Id = (int)Cbx_ProductCustomer.SelectedValue;
                product.Type = Model.Type.Borrow;
                product.Status = Model.Status.OnderReview;



                if (_ProductController.AddProduct(product))
                {
                    MessageBox.Show("Uw heeft zo juist een Product aangenomen");
                    Btn_Cancel_Click(null, null);

                }
                else
                {
                    MessageBox.Show("Er is iets fout gedaan probeer het later opnieuw!! ");
                }
            }
            else
            {
                MessageBox.Show("Selecteer een klant!! ");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            TakeProductOverview Page = new TakeProductOverview();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }
    }
}
