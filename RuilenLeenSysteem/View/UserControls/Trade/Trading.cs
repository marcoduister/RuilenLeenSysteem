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

namespace RuilenLeenSysteem.View.UserControls.Trade
{
    public partial class Trading : UserControl
    {
        private int _Product_id;
        private ProductController _ProductController;
        private OrderController _OrderController;
        private CustomerController _CustomerController;
        public Trading(int product_id)
        {
            InitializeComponent();
            _Product_id = product_id;
            _ProductController = new ProductController();
            _OrderController = new OrderController();
            _CustomerController = new CustomerController();
        }

        private void Trading_Load(object sender, EventArgs e)
        {
            // this wil het the current Product by id
            Product RuilProduct = _ProductController.GetProductById(_Product_id);
            Txt_TradeProductName.Text = RuilProduct.Name;
            Txt_TradeProductDescription.Text = RuilProduct.Description;
            Txt_TradeProductPoints.Text = RuilProduct.Points.ToString();

            //this wil get a list of Customers
            List<Customer> CustomerList = _CustomerController.GetAllCustomers();

            //this will fill the CustomerDrowDown
            FillCustomerDropDown( CustomerList);
        }

        private void FillCustomerDropDown(List<Customer> CustomerList)
        {
            var Customers = CustomerList.Where(A => A.BlackList == false).Select(A => new { Value = A.Id, Text = A.FirstName + " " + A.LastName }).ToList();
            Customers.Insert(0, new { Value = 0, Text = "--Select--" });
            Cbx_TradeProductCustomer.DataSource = Customers;

            Cbx_TradeProductCustomer.ValueMember = "Value";
            Cbx_TradeProductCustomer.DisplayMember = "Text";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            TradeOverview Page = new TradeOverview();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }

        private void Btn_ProductAdd_Click(object sender, EventArgs e)
        {
            if (Cbx_TradeProductCustomer.SelectedValue.ToString() != null)
            {
                int Customer_id = int.Parse(Cbx_TradeProductCustomer.SelectedValue.ToString());
                if (_OrderController.AddTradeOrder(_Product_id, Customer_id,int.Parse(Txt_TradeProductPoints.Text)))
                {
                    MessageBox.Show("Uw heeft zo juist een product geruiled");
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
    }
}
