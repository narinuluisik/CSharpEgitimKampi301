using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        ProductManager productManager = new ProductManager(new EfProductDal());

        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = productManager.TGetAll();
            dataGridView1.DataSource = values;

        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = productManager.TGetProductsWithCategory();
            dataGridView1.DataSource= values;
        }
    }
}
