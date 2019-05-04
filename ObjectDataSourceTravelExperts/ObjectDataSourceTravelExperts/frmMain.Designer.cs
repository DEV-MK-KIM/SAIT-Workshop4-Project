namespace ObjectDataSourceTravelExperts
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.packagesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.groupSuppliers = new System.Windows.Forms.GroupBox();
            this.btnSupAdd = new System.Windows.Forms.Button();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupProducts = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupLinkTables = new System.Windows.Forms.GroupBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.packagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.groupProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.groupLinkTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // packagesDataGridView
            // 
            this.packagesDataGridView.AutoGenerateColumns = false;
            this.packagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Edit});
            this.packagesDataGridView.DataSource = this.packagesBindingSource;
            this.packagesDataGridView.Location = new System.Drawing.Point(16, 19);
            this.packagesDataGridView.Name = "packagesDataGridView";
            this.packagesDataGridView.Size = new System.Drawing.Size(895, 125);
            this.packagesDataGridView.TabIndex = 1;
            this.packagesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.packagesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PackageID";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Pkg ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PkgName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pkg Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PkgStartDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pkg StartDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PkgEndDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pkg EndDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PkgDesc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pkg Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "Base Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn7.HeaderText = "Agency Commission";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // Edit
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle6;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 60;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataSource = typeof(TravelExpertsData.Packages);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddPkg);
            this.groupBox1.Controls.Add(this.packagesDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Packages";
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.Location = new System.Drawing.Point(658, 150);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(61, 23);
            this.btnAddPkg.TabIndex = 2;
            this.btnAddPkg.Text = "&Add";
            this.btnAddPkg.UseVisualStyleBackColor = true;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // groupSuppliers
            // 
            this.groupSuppliers.Controls.Add(this.btnSupAdd);
            this.groupSuppliers.Controls.Add(this.suppliersDataGridView);
            this.groupSuppliers.Location = new System.Drawing.Point(468, 240);
            this.groupSuppliers.Name = "groupSuppliers";
            this.groupSuppliers.Size = new System.Drawing.Size(473, 334);
            this.groupSuppliers.TabIndex = 3;
            this.groupSuppliers.TabStop = false;
            this.groupSuppliers.Text = "Suppliers";
            // 
            // btnSupAdd
            // 
            this.btnSupAdd.Location = new System.Drawing.Point(394, 295);
            this.btnSupAdd.Name = "btnSupAdd";
            this.btnSupAdd.Size = new System.Drawing.Size(61, 23);
            this.btnSupAdd.TabIndex = 3;
            this.btnSupAdd.Text = "&Add";
            this.btnSupAdd.UseVisualStyleBackColor = true;
            this.btnSupAdd.Click += new System.EventHandler(this.btnSupAdd_Click);
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AutoGenerateColumns = false;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Update});
            this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
            this.suppliersDataGridView.Location = new System.Drawing.Point(17, 19);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.Size = new System.Drawing.Size(438, 266);
            this.suppliersDataGridView.TabIndex = 0;
            this.suppliersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Supplier ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Supplier Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 270;
            // 
            // Update
            // 
            this.Update.HeaderText = "Edit";
            this.Update.Name = "Update";
            this.Update.Text = "Edit";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 60;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataSource = typeof(TravelExpertsData.Suppliers);
            // 
            // groupProducts
            // 
            this.groupProducts.Controls.Add(this.btnAddProduct);
            this.groupProducts.Controls.Add(this.productsDataGridView);
            this.groupProducts.Location = new System.Drawing.Point(18, 240);
            this.groupProducts.Name = "groupProducts";
            this.groupProducts.Size = new System.Drawing.Size(444, 318);
            this.groupProducts.TabIndex = 4;
            this.groupProducts.TabStop = false;
            this.groupProducts.Text = "Products";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(307, 275);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(61, 23);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.pEdit});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(20, 19);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(348, 220);
            this.productsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn11.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // pEdit
            // 
            this.pEdit.HeaderText = "Edit";
            this.pEdit.Name = "pEdit";
            this.pEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pEdit.Text = "Edit";
            this.pEdit.UseColumnTextForButtonValue = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(TravelExpertsData.Products);
            // 
            // groupLinkTables
            // 
            this.groupLinkTables.Controls.Add(this.btnLink);
            this.groupLinkTables.Location = new System.Drawing.Point(965, 40);
            this.groupLinkTables.Name = "groupLinkTables";
            this.groupLinkTables.Size = new System.Drawing.Size(200, 275);
            this.groupLinkTables.TabIndex = 5;
            this.groupLinkTables.TabStop = false;
            this.groupLinkTables.Text = "Linked Tables";
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(22, 236);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(158, 23);
            this.btnLink.TabIndex = 0;
            this.btnLink.Text = "Manage Linked Tables";
            this.btnLink.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1085, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 26);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(976, 535);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(80, 26);
            this.btnWeb.TabIndex = 6;
            this.btnWeb.Text = "&Website";
            this.btnWeb.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(861, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 26);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 665);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupLinkTables);
            this.Controls.Add(this.groupProducts);
            this.Controls.Add(this.groupSuppliers);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.groupProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.groupLinkTables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource packagesBindingSource;
        private System.Windows.Forms.DataGridView packagesDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.GroupBox groupSuppliers;
        private System.Windows.Forms.GroupBox groupProducts;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.Button btnSupAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.GroupBox groupLinkTables;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.BindingSource productsBindingSource;
        public System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewButtonColumn pEdit;
    }
}

