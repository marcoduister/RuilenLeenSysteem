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

namespace RuilenLeenSysteem.View.UserControls.Customers
{
    public partial class CustomerOverview : UserControl
    {
        private CustomerController _CustomerControlle;
        public CustomerOverview()
        {
            InitializeComponent();
            _CustomerControlle = new CustomerController();
        }

        private void Btn_CustomerAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            CustomerAdd Page = new CustomerAdd();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }

        private void CustomerOverview_Load(object sender, EventArgs e)
        {
            List<Customer> CustomerList = _CustomerControlle.GetAllCustomers();

            foreach (var Customer in CustomerList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv_CustomerOverview);
                row.Cells[0].Value = Customer.Id;
                row.Cells[1].Value = Customer.FirstName;
                row.Cells[2].Value = Customer.LastName;
                row.Cells[3].Value = Customer.Email;
                row.Cells[4].Value = Customer.balance;
                row.Cells[5].Value = Customer.BlackList;

                Dgv_CustomerOverview.Rows.Add(row);

            }
        }
    }
}
