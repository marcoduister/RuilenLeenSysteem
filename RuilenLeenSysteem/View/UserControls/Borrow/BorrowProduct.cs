using RuilenLeenSysteem.BUS;
using RuilenLeenSysteem.Model;
using RuilenLeenSysteem.View.UserControls.Borrow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuilenLeenSysteem.View.UserControls.Borrow
{
    public partial class BorrowProduct : UserControl
    {
        private int _Product_id;
        private ProductController _ProductController;
        private OrderController _OrderController;
        private CustomerController _CustomerController;
        public BorrowProduct(int product_id)
        {
            InitializeComponent();
            _Product_id = product_id;
            _ProductController = new ProductController();
            _OrderController = new OrderController();
            _CustomerController = new CustomerController();
        }

        private void BorrowProduct_Load(object sender, EventArgs e)
        {
            // this wil het the current Product by id
            Product BorrowProduct = _ProductController.GetProductById(_Product_id);
            Txt_BorrowProductName.Text = BorrowProduct.Name;
            Txt_BorrowProductPoints.Text = BorrowProduct.Points.ToString();

            //this wil get a list of Customers
            List<Customer> CustomerList = _CustomerController.GetAllCustomers();

            //this will fill the CustomerDrowDown
            FillCustomerDropDown(CustomerList);
        }
        private void FillCustomerDropDown(List<Customer> CustomerList)
        {
            var Customers = CustomerList.Where(A => A.BlackList == false).Select(A => new { Value = A.Id, Text = A.FirstName + " " + A.LastName }).ToList();
            Customers.Insert(0, new { Value = 0, Text = "--Select--" });
            Cbx_BorrowProductCustomer.DataSource = Customers;

            Cbx_BorrowProductCustomer.ValueMember = "Value";
            Cbx_BorrowProductCustomer.DisplayMember = "Text";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            BorrowProductOverview Page = new BorrowProductOverview();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }

        private void Btn_ProductEdit_Click(object sender, EventArgs e)
        {
            if (Cbx_ContractCheck.Checked)
            {
                if (Cbx_BorrowProductCustomer.SelectedValue.ToString() != null)
                {
                    int Customer_id = int.Parse(Cbx_BorrowProductCustomer.SelectedValue.ToString());
                    if (_OrderController.AddBorrowOrder(_Product_id, Customer_id, int.Parse(Txt_BorrowProductPoints.Text), Dtp_BorrowProductStartDate.Value, Dtp_BorrowProductEndDate.Value))
                    {
                        MessageBox.Show("Uw heeft zo juist een product Uitgeleend");
                        Btn_Cancel_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Er is iets fout gegaan controleer uw saldo of probeer het later opnieuw!!! ");
                    }
                }
                else
                {
                    MessageBox.Show("Selecteer A.U.B een klant ");
                }
            }
            else
            {
                MessageBox.Show("Onderteken het contract en vink het vinkje aan!!!");
            }
            
        }
    }
}
