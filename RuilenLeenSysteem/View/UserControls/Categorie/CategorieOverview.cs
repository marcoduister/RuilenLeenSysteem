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
    public partial class CategorieOverview : UserControl
    {
        public CategorieOverview()
        {
            InitializeComponent();
        }

        private void Btn_CategorieAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            CategorieAdd Page = new CategorieAdd();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }
    }
}
