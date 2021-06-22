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
                MainForm MainForm = new MainForm();
                this.Hide();
                MainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("please check credentials");
            }
        }
    }
}
