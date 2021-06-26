using RuilenLeenSysteem.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuilenLeenSysteem.View.UserControls.Borrow
{
    public partial class BorrowProduct : UserControl
    {
        private int _product_id;
        private OrderController _OrderController;
        public BorrowProduct(int product_id)
        {
            InitializeComponent();
            _product_id = product_id;
            _OrderController = new OrderController();
        }

        private void BorrowProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
