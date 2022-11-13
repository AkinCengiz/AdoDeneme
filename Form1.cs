using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetDemo;

namespace AdoNetDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Temizle()
        {
            tbxName.Clear();
            tbxStockAmount.Clear();
            tbxUnitPrice.Clear();
            tbxName.Focus();
        }

        private ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = _productDal.GetAll();
        }
    }
}
