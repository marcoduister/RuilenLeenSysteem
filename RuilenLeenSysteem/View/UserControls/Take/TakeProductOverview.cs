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
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv_TakeProductOverview);
                row.Cells[0].Value = Product.Id;
                row.Cells[1].Value = Product.Name;
                row.Cells[2].Value = Product.Status;

                Dgv_TakeProductOverview.Rows.Add(row);
            }
        }

        private void Dgv_TakeProductOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
