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

namespace RuilenLeenSysteem.View.UserControls.Categorie
{
    public partial class CategorieAdd : UserControl
    {
        private CategoryController _CategoryController;
        public CategorieAdd()
        {
            InitializeComponent();
            _CategoryController = new CategoryController();
        }

        private void Btn_CategorieAdd_Click(object sender, EventArgs e)
        {
            if (_CategoryController.AddCategory(Txt_CategorieName.Text, Txt_CategorieDescription.Text))
            {
                MessageBox.Show("Uw heeft zo juist een categorie aangemaakt");
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
            CategorieOverview Page = new CategorieOverview();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }
    }
}
