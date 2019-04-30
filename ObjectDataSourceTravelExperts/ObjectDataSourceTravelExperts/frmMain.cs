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
    public partial class frmMain : Form
    {
        public const int EDIT_SUPPLIER_INDEX = 2 ; // index number of edit column in supplier table
        public frmMain()
        {
            InitializeComponent();
        }

        List<Packages> packages = null;
        List<Suppliers> suppliers = null;

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            packages = Packages_DB.GetPackages();
            packagesDataGridView.DataSource = packages;

            //Suppliers 
            suppliers = Suppliers_DB.GetSuppliers();
            suppliersDataGridView.DataSource = suppliers;
            

        }

        private void suppliersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EDIT_SUPPLIER_INDEX)
            {
                frmSupplierUpdate updateSupplierForm = new frmSupplierUpdate();
                updateSupplierForm.supplier = suppliers[e.RowIndex]; // pass current customer to the update form
                DialogResult result = updateSupplierForm.ShowDialog(); // display modal

                if (result == DialogResult.OK)
                {
                    CurrencyManager cm = (CurrencyManager)suppliersDataGridView.BindingContext[suppliers];
                    cm.Refresh();
                }
                else
                {
                    suppliers = Suppliers_DB.GetSuppliers();
                    suppliersDataGridView.DataSource = suppliers;
                }
            }
        }
    }
}
