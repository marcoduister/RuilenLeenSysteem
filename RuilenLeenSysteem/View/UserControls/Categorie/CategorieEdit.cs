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

namespace RuilenLeenSysteem.View.UserControls.Categorie
{
    public partial class CategorieEdit : UserControl
    {
        private CategoryController _CategoryController;
        private int _Category_id;
        public CategorieEdit(int Category_id)
        {
            InitializeComponent();
            _Category_id = Category_id;
            _CategoryController = new CategoryController();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            CategorieOverview Page = new CategorieOverview();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }

        private void CategorieEdit_Load(object sender, EventArgs e)
        {
            Category EditCategory = _CategoryController.GetCategoryById(_Category_id);
            Txt_CategorieName.Text = EditCategory.Name;
            Txt_CategorieDescription.Text = EditCategory.Description;
        }

        private void Btn_CategorieChange_Click(object sender, EventArgs e)
        {
            if (_CategoryController.EditCategory(_Category_id, Txt_CategorieName.Text, Txt_CategorieDescription.Text ))
            {
                MessageBox.Show("Uw heeft zo juist een Klant bewerkt");
                Btn_Cancel_Click(null, null);
            }
            else
            {
                MessageBox.Show("Er is iets fout gedaan probeer het later opnieuw!! ");
            }
        }
    }
}
