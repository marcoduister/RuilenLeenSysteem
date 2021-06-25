using RuilenLeenSysteem.BUS;
using RuilenLeenSysteem.Model;
using RuilenLeenSysteem.View.UserControls.Home;
using RuilenLeenSysteem.View.UserControls.Trade;
using RuilenLeenSysteem.View.UserControls.Borrow;
using RuilenLeenSysteem.View.UserControls.Categorie;
using RuilenLeenSysteem.View.UserControls.Customers;
using RuilenLeenSysteem.View.UserControls.Products;
using RuilenLeenSysteem.View.UserControls.Take;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuilenLeenSysteem.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Home Page = new Home();
            Page.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Page);
        }

        private void Btn_HomePage_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Home Page = new Home();
            Page.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Page);
        }

        private void Btn_TradePage_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            TradeOverview Page = new TradeOverview();
            Page.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Page);
        }

        private void Btn_BorrowPage_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            BorrowProductOverview Page = new BorrowProductOverview();
            Page.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Page);
        }

        private void Btn_ProductPage_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ProductOverview Page = new ProductOverview();
            Page.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Page);
        }

        private void Btn_TakeInPage_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            TakeProductOverview Page = new TakeProductOverview();
            Page.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Page);
        }

        private void Btn_CategoryPage_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            CategorieOverview Page = new CategorieOverview();
            Page.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Page);
        }

        private void Btn_CustomerPage_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            CustomerOverview Page = new CustomerOverview();
            Page.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Page);
        }


        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
