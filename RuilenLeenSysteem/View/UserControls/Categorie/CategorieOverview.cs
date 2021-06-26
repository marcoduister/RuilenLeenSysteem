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
            List<Model.Categorie> CategoryList = _CategoryController.GetAllCategories(); //afleiden van klanten

            foreach (var Category in CategoryList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv_CustomerOverview);
                row.Cells[0].Value = Customer.Id;
                row.Cells[1].Value = Customer.FirstName; //aanpassen naar category
                row.Cells[2].Value = Customer.LastName;
                row.Cells[3].Value = Customer.Email;
                row.Cells[4].Value = Customer.BlackList;

                Dgv_CustomerOverview.Rows.Add(row);

            }
        }

        private void Dgv_CustomerOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_CustomerOverview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
