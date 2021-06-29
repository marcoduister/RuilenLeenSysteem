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
    public partial class TakeProductReview : UserControl
    {
        private ProductController _ProductController;
        private int _Product_id;
        private Product _CurentProduct;

        public TakeProductReview(int Product_id)
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
            if (_ProductController.EditProduct(_Product_id, Txt_ProductName.Text, Txt_ProductDescription.Text, Int32.Parse(Txt_ProductWorth.Text), 0, Model.Status.InStock))
            {
                MessageBox.Show("Uw heeft zo juist een Product gereviewd");
                ReturnBack();
            }
            else
            {
                MessageBox.Show("Er is iets fout gedaan probeer het later opnieuw!! ");
            }

        }

        private void Btn_ProductNotGood_Click(object sender, EventArgs e)
        {
            
            if (_ProductController.EditProduct(_Product_id, Txt_ProductName.Text,Txt_ProductDescription.Text, Int32.Parse(Txt_ProductWorth.Text),0, Model.Status.GivingBack))
            {
                MessageBox.Show("Uw heeft zo juist een Product gereviewd");
                ReturnBack();
            }
            else
            {
                MessageBox.Show("Er is iets fout gedaan probeer het later opnieuw!! ");
            }
        }

        private void ReturnBack()
        {
            this.Controls.Clear();
            TakeProductOverview Page = new TakeProductOverview();
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
        }
    }
}
