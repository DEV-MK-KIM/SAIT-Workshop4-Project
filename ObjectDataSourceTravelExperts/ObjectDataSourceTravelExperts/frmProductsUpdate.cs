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
    public partial class frmProductsUpdate : Form
    {
        public Products products;
        public Products oldProducts;

        public frmProductsUpdate()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = Products_DB.UpdateProducts(products, oldProducts);
                if (success)
                {
                    MessageBox.Show("Update successful", "Good News");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Another user updated or deleted this record. Try again.",
                                     "Concurrency problem");
                    this.DialogResult = DialogResult.Retry; // closes the form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message,
                    ex.GetType().ToString());
                //this.DialogResult = DialogResult.Retry;
            }
        }
        private void frmProductsUpdate_Load(object sender, EventArgs e)
        {
            List<Products> products = Products_DB.GetProducts();
            oldProducts = products.Clone();
            //oldProducts = products.Clone();
            productsBindingSource.Clear();
            productsBindingSource.Add(products);
            txtProdName.Focus();
        }
        private void butnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; // anything but ok
        }
    }
}
