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

namespace RuilenLeenSysteem.View.UserControls.Products
{
    public partial class ProductOverview : UserControl
    {
        private ProductController _ProductController;
        public ProductOverview()
        {
            InitializeComponent();
            _ProductController = new ProductController();
        }

        private void Btn_ProductAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ProductAdd Page = new ProductAdd();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }

        private void ProductOverview_Load(object sender, EventArgs e)
        {
            List<Product> ProductList = _ProductController.GetAllProducts();

            foreach (var Product in ProductList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv_ProductOverview);
                row.Cells[0].Value = Product.Id;
                row.Cells[1].Value = Product.Name;
                row.Cells[2].Value = Product.Description;
                row.Cells[3].Value = Product.Points;
                row.Cells[4].Value = Product.Status;
                row.Cells[5].Value = Product.Type;

                Dgv_ProductOverview.Rows.Add(row);

            }
        }

        private void Dgv_ProductOverview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int Product_id = int.Parse(Dgv_ProductOverview.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (Dgv_ProductOverview.Columns[e.ColumnIndex].Name == "Btn_Edit")
            {
                this.Controls.Clear();
                ProductEdit uc = new ProductEdit(Product_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (Dgv_ProductOverview.Columns[e.ColumnIndex].Name == "Btn_Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Weet uw zekker dat uw dit product wilt verwijderen", "Product verwijderen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (_ProductController.DeleteProduct(Product_id))
                    {
                        MessageBox.Show("uw heeft een product verwijdered");
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
