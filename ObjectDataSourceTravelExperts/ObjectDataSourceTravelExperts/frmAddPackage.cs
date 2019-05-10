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
    //Author: Lee Neufeld
    // May/10/2019
    public partial class frmAddPackage : Form
    {
        public bool addPackage;
        public Packages package; // current package
        public frmAddPackage()
        {
            InitializeComponent();
        }

        private void frmAddPackage_Load(object sender, EventArgs e)
        {

        }

        private void putPackage(Packages package)
        {
            try
            {
                package.PkgName = txtPkgName.Text;
                package.PkgStartDate = Convert.ToDateTime(txtDateStart.Text);
                package.PkgEndDate = Convert.ToDateTime(txtDateEnd.Text);
                package.PkgDesc = txtPkgDesc.Text;
                package.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                package.PkgAgencyCommission = Convert.ToDecimal(txtPkgCommission.Text);
            }
            catch (Exception ex)
            {

            }
        }
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtPkgName) &&
                Validator.IsPresent(txtPkgCommission) &&
                Validator.IsPresent(txtPkgBasePrice) &&
                Validator.IsPresent(txtPkgDesc) &&
                Validator.IsPresent(txtDateEnd) &&
                Validator.IsPresent(txtDateStart);
        }



        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addPackage) // processing Add
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
