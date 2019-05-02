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
    public partial class frmAddPackage : Form
    {
        public bool addPackage;
        public Packages package; // current supplier
        public frmAddPackage()
        {
            InitializeComponent();
        }

        private void frmAddPackage_Load(object sender, EventArgs e)
        {
            package = new Packages();
            this.putPackage(package);


            try
            {
                package.PackageID = Packages_DB.AddPackage(package);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    
    private void putPackage(Packages package)
    {
            package.PkgName = txtPkgName.Text;
            package.PkgStartDate = Convert.ToDateTime(txtDateStart.Text);
            package.PkgEndDate = Convert.ToDateTime(txtDateEnd.Text);
            package.PkgDesc = txtPkgCommission.Text;
            package.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txtPkgCommission.Text);
        
        
        
        
        


        }
}
}
