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
    public partial class ProductReview : UserControl
    {
        private ProductController _ProductController;
        private int _Product_id;
        private Product _CurentProduct;

        public ProductReview(int Product_id )
        {
            InitializeComponent();
            _Product_id = Product_id;
            _ProductController = new ProductController();
        }

        private void ProductReview_Load(object sender, EventArgs e)
        {
            _CurentProduct = _ProductController.GetProductById(_Product_id);
            Txt_ProductName.Text = _CurentProduct.Name;
            Txt_ProductDescription.Text = _CurentProduct.Description;
            Txt_ProductWorth.Text = _CurentProduct.Points.ToString();
        }

        private void Btn_ProductGood_Click(object sender, EventArgs e)
        {
            _CurentProduct.Name = Txt_ProductName.Text;
            _CurentProduct.Description = Txt_ProductDescription.Text;
            _CurentProduct.Points = Int32.Parse(Txt_ProductWorth.Text);
            _CurentProduct.Status = Model.Status.InStock;
            _ProductController.UpdateProduct(_CurentProduct);
        }

        private void Btn_ProductNotGood_Click(object sender, EventArgs e)
        {
            _CurentProduct.Name = Txt_ProductName.Text;
            _CurentProduct.Description = Txt_ProductDescription.Text;
            _CurentProduct.Points = Int32.Parse(Txt_ProductWorth.Text);
            _CurentProduct.Status = Model.Status.GivingBack;
            _ProductController.UpdateProduct(_CurentProduct);
        }
    }
}
