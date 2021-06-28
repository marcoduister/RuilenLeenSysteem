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
        private CustomerController _CustomerController;
        public CustomerOverview()
        {
            InitializeComponent();
            _CustomerController = new CustomerController();
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
            List<Customer> CustomerList = _CustomerController.GetAllCustomers();

            foreach (var Customer in CustomerList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv_CustomerOverview);
                row.Cells[0].Value = Customer.Id;
                row.Cells[1].Value = Customer.FirstName;
                row.Cells[2].Value = Customer.LastName;
                row.Cells[3].Value = Customer.Email;
                row.Cells[4].Value = Customer.BlackList;

                Dgv_CustomerOverview.Rows.Add(row);

            }
        }

        private void Dgv_CustomerOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Customer_id = int.Parse(Dgv_CustomerOverview.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (Dgv_CustomerOverview.Columns[e.ColumnIndex].Name == "btn_Read")
            {
                this.Controls.Clear();
                CustomerReadProduct uc = new CustomerReadProduct(Customer_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (Dgv_CustomerOverview.Columns[e.ColumnIndex].Name == "btn_Edit")
            {
                this.Controls.Clear();
                CustomerEdit uc = new CustomerEdit(Customer_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (Dgv_CustomerOverview.Columns[e.ColumnIndex].Name == "btn_Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Weet uw zekker dat uw deze klant wilt verwijderen", "Klant verwijderen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (_CustomerController.DeleteCustomer(Customer_id))
                    {
                        MessageBox.Show("uw heeft een klant verwijdered");
                    }
                    else
                    {
                        MessageBox.Show("er is iets fout gedaan probeer het later opnieuw !!!! ");
                    }
                }
            }
        }
    }
}
