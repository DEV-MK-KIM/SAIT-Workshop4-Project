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
// May/10/2019
    public partial class frmPackageUpdate : Form
    {
        public Packages package;
        private Packages oldPackage;

        public frmPackageUpdate()
        {
            InitializeComponent();
        }

        // populates data from database
        private void frmPackageUpdate_Load(object sender, EventArgs e)
        {
            List<Packages> packages = Packages_DB.GetAllPackages();
            oldPackage = package.Clone();
            // bind controls to package object
            packagesBindingSource.Clear();
            packagesBindingSource.Add(package);
        }
        // adds package updates to database
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (isValidEndDate())
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
        }
        // closes form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        private bool isValidEndDate()
        {
            bool valid = true; // empty is valid
            DateTime endDate;


            if (pkgStartDateDateTimePicker.Text != "")// if not empty
            {
                if (DateTime.TryParse(pkgEndDateDateTimePicker.Text, out endDate))//valid date
                {
                    DateTime startDate = Convert.ToDateTime(pkgStartDateDateTimePicker.Text);

                    if (startDate >= endDate)// start date is earlier than end date
                    {
                        valid = false;
                        MessageBox.Show("Start date must be earlier than end date", "Data Error");

                        pkgStartDateDateTimePicker.Focus();
                    }


                }

            }
            return valid;
        }

    }
}
