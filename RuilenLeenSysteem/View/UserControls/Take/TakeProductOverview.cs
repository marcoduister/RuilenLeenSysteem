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
        public TakeProductOverview()
        {
            InitializeComponent();
        }

        private void Btn_TakeProduct_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            TakeProduct Page = new TakeProduct();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }
    }
}
