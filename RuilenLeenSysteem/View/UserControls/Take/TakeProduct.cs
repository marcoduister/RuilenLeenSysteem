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
    public partial class TakeProduct : UserControl
    {

        public TakeProduct()
        {
            InitializeComponent();
        }

        private void TakeProduct_Load(object sender, EventArgs e)
        {

        }

        private void Btn_TakeProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = Txt_ProductName.Text;
            product.Description = Txt_ProductDescription.Text;
            //product.Customer_Id = Cbx_ProductCustomer.toInt();
            product.Type = Model.Type.Borrow;

            ProductController _ProductController = new ProductController();
            _ProductController.AddProduct(product);
        }
    }
}
