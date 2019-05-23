using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace ObjectDataSourceTravelExperts
{
    //Done by Dingli
    public partial class frmAddProduct : Form
    {
        public bool addProduct;
        public Products products;

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            products = new Products();
            this.putProducts(products);
            frmMain mainForm = new frmMain();
            try
            {
                products.ProductID = Products_DB.AddProducts(products);

                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Successfully added", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void putProducts(Products products)
        {
            products.ProductID = Convert.ToInt32(txtProductID.Text);
            products.ProdName = txtProdName.Text;
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}

