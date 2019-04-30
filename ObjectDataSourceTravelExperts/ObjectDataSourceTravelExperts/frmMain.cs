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
        const int EDIT_BUTTON_INDX = 7;
        List<Packages> packages;

        public frmMain()
        {
            InitializeComponent();
        }

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                packages = Packages_DB.GetAllPackages();
                packagesDataGridView.DataSource = packages;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while loading packages data: " + ex.Message, ex.GetType().ToString());
            }

           
        }

        private void packagesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EDIT_BUTTON_INDX)// user click in the buttons column
            {
                
                frmPackageUpdate updateForm = new frmPackageUpdate();
                updateForm.package = packages[e.RowIndex];// pass current package to the update form
                DialogResult result = updateForm.ShowDialog(); // display modal
                if (result == DialogResult.OK)// update accepted
                {
                    // refresh the grid contents
                    CurrencyManager cm = (CurrencyManager)packagesDataGridView.BindingContext[packages];
                    cm.Refresh();
                }
                else // update cancelled
                {
                    
                    packages = Packages_DB.GetAllPackages();
                    packagesDataGridView.DataSource = packages;
                }
            }
        }
    }
}
