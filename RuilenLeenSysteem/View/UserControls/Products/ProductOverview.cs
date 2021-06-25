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
        public ProductOverview()
        {
            InitializeComponent();
        }

        private void Btn_ProductAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ProductAdd Page = new ProductAdd();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }
    }
}
