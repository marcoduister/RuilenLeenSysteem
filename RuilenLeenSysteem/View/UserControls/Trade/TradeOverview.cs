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

namespace RuilenLeenSysteem.View.UserControls.Trade
{
    public partial class TradeOverview : UserControl
    {
        private ProductController _ProductControlle;

        public TradeOverview()
        {
            InitializeComponent();
            _ProductControlle = new ProductController();
        }

        private void TradeOverview_Load(object sender, EventArgs e)
        {
            List<Product> TradeProductList = _ProductControlle.GetAllProductsByType(Type.Trade);

            foreach (var product in TradeProductList.Where(A => A.Status == Model.Status.InStock))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv_TradeProductOverview);
                row.Cells[0].Value = product.Id;
                row.Cells[1].Value = product.Name;
                row.Cells[2].Value = product.Description;
                row.Cells[3].Value = product.Points;
                row.Cells[4].Value = product.Status;

                Dgv_TradeProductOverview.Rows.Add(row);
            }
        }

        private void Dgv_TradeProductOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Product_id = int.Parse(Dgv_TradeProductOverview.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (Dgv_TradeProductOverview.Columns[e.ColumnIndex].Name == "btn_Ruilen")
            {
                this.Controls.Clear();
                Trading uc = new Trading(Product_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
        }
    }
}
