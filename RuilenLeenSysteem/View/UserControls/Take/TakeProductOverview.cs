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

namespace RuilenLeenSysteem.View.UserControls.Take
{
    public partial class TakeProductOverview : UserControl
    {
        private ProductController _ProductController;
        public TakeProductOverview()
        {
            InitializeComponent();
            _ProductController = new ProductController();
        }

        private void Btn_TakeProduct_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            TakeProduct Page = new TakeProduct();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }

        private void TakeProductOverview_Load(object sender, EventArgs e)
        {
            List<Product> ProductList = _ProductController.GetAllProductsByType(Model.Type.Borrow);

            foreach (var Product in ProductList)
            {
                if (Product.Status == Model.Status.OnderReview || Product.Status == Model.Status.GivingBack)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Dgv_TakeProductOverview);
                    row.Cells[0].Value = Product.Id;
                    row.Cells[1].Value = Product.Name;
                    row.Cells[2].Value = Product.Status;
                    if (Product.Status != Model.Status.GivingBack)
                    {
                        DataGridViewButtonCell Btn_Review = new DataGridViewButtonCell() { Value = "Review" };
                        row.Cells[3] = Btn_Review;
                    }
                    if (Product.Status == Model.Status.GivingBack)
                    {
                        DataGridViewButtonCell btn_Delete = new DataGridViewButtonCell() { Value = "Verwijderen" };
                        row.Cells[4] = btn_Delete;
                    }

                    Dgv_TakeProductOverview.Rows.Add(row);
                }
            }
        }

        private void Dgv_TakeProductOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Product_id = int.Parse(Dgv_TakeProductOverview.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (Dgv_TakeProductOverview.Columns[e.ColumnIndex].Name == "btn_Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Weet uw zekker dat uw deze klant wilt verwijderen", "Klant verwijderen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _ProductController.DeleteProduct(Product_id);
                    
                    MessageBox.Show("uw heeft een product verwijdered");
                    
                }
            }
            if (Dgv_TakeProductOverview.Columns[e.ColumnIndex].Name == "Btn_Review")
            {
                this.Controls.Clear();
                TakeProductReview Page = new TakeProductReview(Product_id);
                Page.Dock = DockStyle.Fill;
                this.Controls.Add(Page);
            }
        }
    }
}
