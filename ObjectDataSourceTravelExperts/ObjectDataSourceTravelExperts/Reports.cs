using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TravelExpertsData;



namespace ObjectDataSourceTravelExperts
    /*************************************************************
        Auther By : Mohamed
        Date May 10,2019
        The report form to link the supplier with current products.
     ************************************************************/
{
    public partial class frmReports : Form
    {
        private bool IsValidData(Control control)
        {
            return
                Validator.IsPresent(control); /*&&*/
                //Validator. (txtProductId) &&
                //Validator.IsPresent(txtProSupId) &&
                //Validator.IsPresent(txtSupplierId);
             
        }
        SqlConnection con = new SqlConnection (@"Data Source=localhost\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True");
       
        public frmReports()
        {
            InitializeComponent();
        }
        // Assign operation between Product Id and Supplier ID in SupplierProducts Table

        private void btnAssign_Click(object sender, EventArgs e)
        {
            //int productID = Convert.ToInt32(txtProductId.Text);
            //int SupplierID = Convert.ToInt32(txtSupplierId.Text);
                       
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Products_Suppliers values ('" + txtProductId.Text + "', '" + txtSupplierId.Text + "')";
            cmd.ExecuteNonQuery();
            txtProductId.Text = "";
            txtSupplierId.Text = "";
            txtProSupId.Text = "";
            txtPackageId.Text = "";

            displayData();
            MessageBox.Show("Supplier has been assigned to product successfully");
        }

        // To diplay the infomrtion in the DataGridView
        public void displayData()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products_Suppliers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewLink.DataSource = dt;

            con.Close();
        }

        private void gvAllpkg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //To Dispplay information into Grid View
        private void Reports_Load(object sender, EventArgs e)
        {
            displayData();
        }

        //To clear Display Grid View

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewLink.DataSource = null;
            dataGridViewLink.Refresh();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
    }


        // Search Function for Product ID
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ps.ProductId, s.SupplierId, s.SupName, p.ProdName from Products_Suppliers ps, Products p, Suppliers s " +
                "where ps.ProductId ='" + txtProductId.Text + "' and p.ProductId = ps.ProductId and ps.SupplierId = s.SupplierId";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewLink.DataSource = dt;

            con.Close();
        }


        // Search Function for Supplier ID
        private void btnSearchSup_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ps.ProductId, s.SupplierId, s.SupName, p.ProdName from Products_Suppliers ps, Products p, Suppliers s " +
                "where ps.SupplierId ='" + txtSupplierId.Text + "' and ps.SupplierId = s.SupplierId and p.ProductId = ps.ProductId  ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewLink.DataSource = dt;

            con.Close();
        }

        // Search Function for Package ID
        private void btnSearchPackage_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select pps.ProductSupplierId, pps.PackageId, s.SupplierId, s.SupName, pk.pkgname " +
                "from Suppliers s, Packages pk, Packages_Products_Suppliers pps, Products_Suppliers ps " +
                "where pps.PackageId='" + txtPackageId.Text + "' and pps.ProductSupplierId = ps.ProductSupplierId and " +
                "ps.SupplierId = s.SupplierId and pk.PackageId = pps.PackageId";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewLink.DataSource = dt;

            con.Close();
        }

        private void btnAssignPackage_Click(object sender, EventArgs e)
        {
            //Validator vv = new Validator();

            //if (txtPackageId.Text)
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Packages_Products_Suppliers values ('" + txtPackageId.Text + "', '" + txtProSupId.Text + "')";
            cmd.ExecuteNonQuery();
            txtProductId.Text = "";
            txtSupplierId.Text = "";
            txtProSupId.Text = "";
            txtPackageId.Text = "";

            displayData();
            MessageBox.Show("Product has been assigned to package successfully");
        }
    }
}
