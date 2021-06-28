using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuilenLeenSysteem.BUS;
using RuilenLeenSysteem.Model;

namespace RuilenLeenSysteem.View.UserControls.Categorie
{
    public partial class CategorieOverview : UserControl
    {

        private CategoryController _CategoryController;
        public CategorieOverview()
        {
            InitializeComponent();
            _CategoryController = new CategoryController();
        }



        private void Btn_CategorieAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            CategorieAdd Page = new CategorieAdd();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }

        private void CategorieOverview_Load(object sender, EventArgs e)
        {
            List<Category> CategoryList = _CategoryController.GetAllCategories();

            foreach (var Category in CategoryList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv_Category);
                row.Cells[0].Value = Category.Id;
                row.Cells[1].Value = Category.Name;
                row.Cells[2].Value = Category.Description;

                Dgv_Category.Rows.Add(row);

            }
        }

        private void Dgv_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Category_id = int.Parse(Dgv_Category.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (Dgv_Category.Columns[e.ColumnIndex].Name == "btn_Edit")
            {
                this.Controls.Clear();
                CategorieEdit uc = new CategorieEdit(Category_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (Dgv_Category.Columns[e.ColumnIndex].Name == "btn_Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Weet uw zekker dat uw deze klant wilt verwijderen", "Klant verwijderen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (_CategoryController.DeleteCategory(Category_id))
                    {
                        MessageBox.Show("uw heeft een Category verwijdered");
                    }
                    else
                    {
                        MessageBox.Show("er is iets fout gedaan probeer het later opnieuw !!!! ");
                    }
                }
            }

        }
    }
}
