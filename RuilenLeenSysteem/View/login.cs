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

        private void Btn_LoginAdmin_Click(object sender, EventArgs e)
        {
            if (_UserController.LogIn(Roll.Admin))
            {
                this.Hide();
                MainForm MainForm = new MainForm();
                MainForm.ShowDialog();
                MainForm.Dispose();
                this.Show();

            }
            else
            {
                MessageBox.Show("U hebt mogelijk foute inlog gegevens gebruik!!");
            }
        }

        private void Btn_LoginIT_Employee_Click(object sender, EventArgs e)
        {
            if (_UserController.LogIn(Roll.IT_Employee))
            {
                this.Hide();
                MainForm MainForm = new MainForm();
                MainForm.ShowDialog();
                MainForm.Dispose();
                this.Show();

            }
            else
            {
                MessageBox.Show("dit is nog niet geimplementeerd probeer het later opnieuw!!");
            }
        }

        private void Btn_LoginVolunteer_Click(object sender, EventArgs e)
        {
            if (_UserController.LogIn(Roll.Volunteer))
            {
                this.Hide();
                MainForm MainForm = new MainForm();
                MainForm.ShowDialog();
                MainForm.Dispose();
                this.Show();

            }
            else
            {
                MessageBox.Show("dit is nog niet geimplementeerd probeer het later opnieuw!!");
            }
        }
    }
}
