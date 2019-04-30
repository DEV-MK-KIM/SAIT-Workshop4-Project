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
    public partial class frmSuppliersUpdate : Form
    {
        public Suppliers supplier;
        public Suppliers oldSupplier;

        public frmSuppliersUpdate()
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
         // added accept function  
         // cooment2
        }
    }
}
