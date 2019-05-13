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
    public partial class frmSuppliersAdd : Form
    {

        public bool addSupplier;
        public Suppliers supplier; // current supplier
        public frmSuppliersAdd()
        {
            InitializeComponent();

        }

              

        private void btnAccept_Click(object sender, EventArgs e)
        {
            supplier = new Suppliers();
            this.putSupplier(supplier);
            frmMain mainForm = new frmMain();
           

            try
            {
                supplier.SupplierID = Suppliers_DB.AddSupplier(supplier);
                
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Successfully added", "Success");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

          



        }

        private void putSupplier(Suppliers supplier)
        {
            supplier.SupplierID = Convert.ToInt32(txtSupplierID.Text);
            supplier.SupName = txtSupName.Text;

        }

        private void frmSuppliersAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSupName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
