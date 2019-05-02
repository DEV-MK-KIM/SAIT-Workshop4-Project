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
           

            try
            {
                supplier.SupplierID = Suppliers_DB.AddSupplier(supplier);
                
                this.DialogResult = DialogResult.OK;
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
    }
}
