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
        public Suppliers supplier;
        public Suppliers oldSupplier;
        internal Products products;

        public frmProductsUpdate()
        {
            InitializeComponent();
        }

        private void frmSuppliersUpdate_Load(object sender, EventArgs e)
        {
            oldSupplier = supplier.Clone();

            suppliersBindingSource.Clear();
            suppliersBindingSource.Add(supplier);
            txtSupName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; // anything but ok
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = Suppliers_DB.UpdateSuppliers(supplier, oldSupplier);
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
    }
}
