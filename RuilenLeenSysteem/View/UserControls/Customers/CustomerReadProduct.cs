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
    public partial class CustomerReadProduct : UserControl
    {
        private CustomerController _CustomerControlle;
        private int _Customer_id;
        public CustomerReadProduct(int Customer_id)
        {
            InitializeComponent();
            _Customer_id = Customer_id;
            _CustomerControlle = new CustomerController();
        }

        private void CustomerReadProduct_Load(object sender, EventArgs e)
        {
            Customer Customer = _CustomerControlle.GetReadCustomersById(_Customer_id);
            Txt_CustomerFirstName.Text = Customer.FirstName;
            Txt_CustomerLastName.Text = Customer.LastName;
            Txt_CustomerAdress.Text = Customer.Adress;
            Txt_CustomerEmail.Text = Customer.Email;
            Txt_CustomerPhoneNumber.Text = Customer.PhoneNumber.ToString();
            Txt_balance.Text = Customer.balance.ToString();
            foreach (var Borrow in Customer.AllBorrowOrders)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv_BorrowView);

                row.Cells[0].Value = Borrow.Product.Name;
                row.Cells[1].Value = Borrow.Product.Points;
                row.Cells[2].Value = Borrow.Start_date.ToString();
                row.Cells[2].Value = Borrow.End_Date.ToString();

                Dgv_BorrowView.Rows.Add(row);
            }
            foreach (var trade in Customer.AllTradeOrders)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv_TradeView);

                row.Cells[0].Value = trade.Product.Name;
                row.Cells[1].Value = trade.Product.Points;
                row.Cells[2].Value = trade.Order_Date.ToString();

                Dgv_TradeView.Rows.Add(row);
            }
        }
    }
}
