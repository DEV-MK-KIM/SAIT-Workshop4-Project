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
    public partial class frmSupplierUpdate : Form

    {

        public Suppliers supplier;
        public Suppliers oldSupplier;

        public frmSupplierUpdate()
        {
            InitializeComponent();
        }

        private void frmSupplierUpdate_Load(object sender, EventArgs e)
        {
            oldSupplier = supplier.Clone();

            suppliersBindingSource.Clear();
            suppliersBindingSource.Add(supplier);
            txtSupName.Focus();
        }
    }
}
