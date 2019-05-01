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
{// Author: Lee Neufeld
    public partial class frmPackageUpdate : Form
    {
        public Packages package;
        private Packages oldPackage;

        public frmPackageUpdate()
        {
            InitializeComponent();
        }

        private void frmPackageUpdate_Load(object sender, EventArgs e)
        {
            List<Packages> packages = Packages_DB.GetAllPackages();
            oldPackage = package.Clone();
            // bind controls to package object
            packagesBindingSource.Clear();
            packagesBindingSource.Add(package);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = Packages_DB.UpdatePackage(oldPackage, package);
                if (success)
                {
                    MessageBox.Show("Update Successful", "Good News");
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Another user updated or deleted the record. Try again.", "Concurrency Issue");
                    this.DialogResult = DialogResult.Retry;// closes the form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update:" + ex.Message, ex.GetType().ToString());
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        private void packageIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void pkgAgencyCommissionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pkgAgencyCommissionLabel_Click(object sender, EventArgs e)
        {

        }

        private void packageIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pkgBasePriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pkgBasePriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void pkgDescTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pkgEndDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void pkgEndDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pkgNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pkgNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pkgStartDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void pkgStartDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pkgDescLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
