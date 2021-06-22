using RuilenLeenSysteem.BUS;
using RuilenLeenSysteem.Model;
using RuilenLeenSysteem.View.UserControls.Home;
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

        }

        private void Btn_BorrowPage_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ProductPage_Click(object sender, EventArgs e)
        {

        }

        private void Btn_TakeInPage_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CategoryPage_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CustomerPage_Click(object sender, EventArgs e)
        {

        }


        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            //Alert moet nog geimplementeerd worden 
            //Properties.Settings.Default["UserId"] = "";
            //Properties.Settings.Default["UserRol"] = 0;
            //Properties.Settings.Default.Save();
        }
    }
}
