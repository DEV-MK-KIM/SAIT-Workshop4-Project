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
        private Products oldProducts;

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load_1(object sender, EventArgs e)
        {
            oldProducts = products.Clone();
            productsBindingSource.Clear();
            productsBindingSource.Add(products);
            txtProdName.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = Products_DB.AddProducts(products, oldProducts);
                if (success)
                {
                    MessageBox.Show("Update successful", "Success");
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; // anything but ok
        }
    }
}

