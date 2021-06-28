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

namespace RuilenLeenSysteem.View.UserControls.Customers
{
    public partial class CustomerAdd : UserControl
    {
        private CustomerController _CustomerControlle;
        public CustomerAdd()
        {
            InitializeComponent();
            _CustomerControlle = new CustomerController();
        }

        private void Btn_CustomerAdd_Click(object sender, EventArgs e)
        {
            if (_CustomerControlle.AddCustomer(Txt_CustomerFirstName.Text,Txt_CustomerLastName.Text, Txt_CustomerAdress.Text, Txt_CustomerEmail.Text, int.Parse(Txt_CustomerPhoneNumber.Text)))
            {
                MessageBox.Show("Uw heeft zo juist een Klant aangemaakt");
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
