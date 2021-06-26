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
using Type = RuilenLeenSysteem.Model.Type;

namespace RuilenLeenSysteem.View.UserControls.Borrow
{
    public partial class BorrowProductOverview : UserControl
    {
        private ProductController _ProductControlle;

        public BorrowProductOverview()
        {
            InitializeComponent();
            _ProductControlle = new ProductController();
        }

        private void BorrowProductOverview_Load(object sender, EventArgs e)
        {
            List<Product> BorrowProductList = _ProductControlle.GetAllProductsByType(Type.Borrow);

            foreach (var product in BorrowProductList.Where(A =>A.Status == Model.Status.InStock))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv_BorrowProductOverview);
                row.Cells[0].Value = product.Id;
                row.Cells[1].Value = product.Name;
                row.Cells[2].Value = product.Description;
                row.Cells[3].Value = product.Points;
                row.Cells[4].Value = product.Status;

                Dgv_BorrowProductOverview.Rows.Add(row);
            }
        }

        private void Dgv_BorrowProductOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Product_id = int.Parse(Dgv_BorrowProductOverview.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (Dgv_BorrowProductOverview.Columns[e.ColumnIndex].Name == "btn_Borrow")
            {
                this.Controls.Clear();
                BorrowProduct uc = new BorrowProduct(Product_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
        }
    }
}
