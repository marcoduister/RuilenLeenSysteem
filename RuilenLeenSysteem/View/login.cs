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
using RuilenLeenSysteem.Model;

namespace RuilenLeenSysteem.View
{
    public partial class login : Form
    {
        private UserController _UserController;
        public login()
        {
            InitializeComponent();
            _UserController = new UserController();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (_UserController.LogIn(Textbox_email.Text, Textbox_password.Text))
            {
                this.Hide();
                MainForm MainForm = new MainForm();
                MainForm.ShowDialog();
                MainForm.Dispose();
                this.Show();
                this.Textbox_email.Text = "";
                this.Textbox_password.Text = "";
            }
            else
            {
                MessageBox.Show("U hebt mogelijk foute inlog gegevens gebruik!!");
            }
        }
    }
}
