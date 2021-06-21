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

namespace RuilenLeenSysteem.View
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Gebruiker Login_user = new Gebruiker("", "", Textbox_email.Text, Textbox_password.Text);
            if (Login_user.LogIn())
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
