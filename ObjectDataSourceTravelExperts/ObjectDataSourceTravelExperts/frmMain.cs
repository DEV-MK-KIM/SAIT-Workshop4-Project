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
        public frmMain()
        {
            InitializeComponent();
        }

        List<Packages> packages = null;

        private void frmMain_Load(object sender, EventArgs e)
        {
            packages = Packages_DB.GetPackages();
            packagesDataGridView.DataSource = packages;
            // comment test 2
        }

    }
}
