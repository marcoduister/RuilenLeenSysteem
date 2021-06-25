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
    public partial class CustomerEdit : UserControl
    {
        private CustomerController _CustomerControlle;
        private int _Customer_id;
        public CustomerEdit(int Customer_id)
        {
            InitializeComponent();
            _Customer_id = Customer_id;
            _CustomerControlle = new CustomerController();
        }

        private void CustomerEdit_Load(object sender, EventArgs e)
        {
            Customer EditCustomer =_CustomerControlle.GetCustomersById(_Customer_id);
            Txt_CustomerFirstName.Text = EditCustomer.FirstName;
            Txt_CustomerLastName.Text = EditCustomer.LastName;
            Txt_CustomerAdress.Text = EditCustomer.Adress;
            Txt_CustomerEmail.Text = EditCustomer.Email;
            Txt_CustomerPhoneNumber.Text = EditCustomer.PhoneNumber.ToString();
        }

        private void Btn_CustomerEdit_Click(object sender, EventArgs e)
        {
            if (_CustomerControlle.EditCustomer(_Customer_id,Txt_CustomerFirstName.Text, Txt_CustomerLastName.Text, Txt_CustomerAdress.Text, Txt_CustomerEmail.Text, int.Parse(Txt_CustomerPhoneNumber.Text)))
            {
                MessageBox.Show("Uw heeft zo juist een Klant bewerkt");
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
            CustomerOverview Page = new CustomerOverview();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }
    }
}
