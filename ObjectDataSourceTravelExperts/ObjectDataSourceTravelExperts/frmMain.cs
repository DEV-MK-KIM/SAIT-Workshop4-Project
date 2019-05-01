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
        const int EDIT_SUPPLIER_INDEX = 2 ; // index number of edit column in supplier table
        const int EDIT_PACKAGES_INDX = 7;

        public frmMain()
        {
            InitializeComponent();
        }

        List<Packages> packages = null;
        List<Suppliers> suppliers = null;
        Suppliers supplier;

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            packages = Packages_DB.GetAllPackages();
            packagesDataGridView.DataSource = packages;

            //Suppliers 
            suppliers = Suppliers_DB.GetSuppliers();
            suppliersDataGridView.DataSource = suppliers;
            

        }

        private void suppliersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EDIT_SUPPLIER_INDEX)
            {
                frmSuppliersUpdate updateSupplierForm = new frmSuppliersUpdate();
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

        private void packagesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EDIT_PACKAGES_INDX)// user click in the buttons column
            {
                //oldCustomer = customers[e.RowIndex].Clone(); // copy of current customer
                frmPackageUpdate updateForm = new frmPackageUpdate();
                updateForm.package = packages[e.RowIndex];// pass current customer to the update form
                DialogResult result = updateForm.ShowDialog(); // display modal
                if (result == DialogResult.OK)// update accepted
                {
                    // refresh the grid contents
                    CurrencyManager cm = (CurrencyManager)packagesDataGridView.BindingContext[packages];
                    cm.Refresh();
                }
                else // update cancelled
                {
                    //customers[e.RowIndex] = oldCustomer;
                    packages = Packages_DB.GetAllPackages();
                    packagesDataGridView.DataSource = packages;
                }
            }
        }
        
        private void btnSupAdd_Click(object sender, EventArgs e)
        {
            frmSuppliersAdd addSupplierForm = new frmSuppliersAdd();
            addSupplierForm.addSupplier = true;
            DialogResult result = addSupplierForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                supplier = addSupplierForm.supplier;
              
            }
        }

        private void btnAddPkg_Click(object sender, EventArgs e)
        {

        }
    }
}
