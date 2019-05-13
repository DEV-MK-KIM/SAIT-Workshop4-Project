namespace ObjectDataSourceTravelExperts
{
    partial class frmReports
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
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchSup = new System.Windows.Forms.Button();
            this.dataGridViewLink = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnSearchPackage = new System.Windows.Forms.Button();
            this.btnAssignPackage = new System.Windows.Forms.Button();
            this.txtProSupId = new System.Windows.Forms.TextBox();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLink)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(300, 51);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(99, 63);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "Assign Supplier";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(152, 55);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(118, 20);
            this.txtProductId.TabIndex = 1;
            this.txtProductId.Tag = "Product ID";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(153, 98);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(118, 20);
            this.txtSupplierId.TabIndex = 2;
            this.txtSupplierId.Tag = "Supplier ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Supplier ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Product ID";
            // 
            // btnSearchSup
            // 
            this.btnSearchSup.Location = new System.Drawing.Point(507, 101);
            this.btnSearchSup.Name = "btnSearchSup";
            this.btnSearchSup.Size = new System.Drawing.Size(117, 25);
            this.btnSearchSup.TabIndex = 5;
            this.btnSearchSup.Text = "Search By Supplier";
            this.btnSearchSup.UseVisualStyleBackColor = true;
            this.btnSearchSup.Click += new System.EventHandler(this.btnSearchSup_Click);
            // 
            // dataGridViewLink
            // 
            this.dataGridViewLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLink.Location = new System.Drawing.Point(29, 236);
            this.dataGridViewLink.Name = "dataGridViewLink";
            this.dataGridViewLink.Size = new System.Drawing.Size(750, 193);
            this.dataGridViewLink.TabIndex = 6;
            this.dataGridViewLink.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAllpkg_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(689, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Display";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(689, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 41);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Product Supplier ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product Package ID";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchProduct.Location = new System.Drawing.Point(506, 55);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(117, 26);
            this.btnSearchProduct.TabIndex = 11;
            this.btnSearchProduct.Text = "Search By product";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnSearchPackage
            // 
            this.btnSearchPackage.Location = new System.Drawing.Point(506, 151);
            this.btnSearchPackage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPackage.Name = "btnSearchPackage";
            this.btnSearchPackage.Size = new System.Drawing.Size(117, 25);
            this.btnSearchPackage.TabIndex = 12;
            this.btnSearchPackage.Text = "Search By Package";
            this.btnSearchPackage.UseVisualStyleBackColor = true;
            this.btnSearchPackage.Click += new System.EventHandler(this.btnSearchPackage_Click);
            // 
            // btnAssignPackage
            // 
            this.btnAssignPackage.Location = new System.Drawing.Point(300, 133);
            this.btnAssignPackage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssignPackage.Name = "btnAssignPackage";
            this.btnAssignPackage.Size = new System.Drawing.Size(99, 61);
            this.btnAssignPackage.TabIndex = 13;
            this.btnAssignPackage.Text = "Assign Product";
            this.btnAssignPackage.UseVisualStyleBackColor = true;
            this.btnAssignPackage.Click += new System.EventHandler(this.btnAssignPackage_Click);
            // 
            // txtProSupId
            // 
            this.txtProSupId.Location = new System.Drawing.Point(153, 138);
            this.txtProSupId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProSupId.Name = "txtProSupId";
            this.txtProSupId.Size = new System.Drawing.Size(116, 20);
            this.txtProSupId.TabIndex = 14;
            this.txtProSupId.Tag = "Product_Supplier ID";
            // 
            // txtPackageId
            // 
            this.txtPackageId.Location = new System.Drawing.Point(153, 175);
            this.txtPackageId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(116, 20);
            this.txtPackageId.TabIndex = 15;
            this.txtPackageId.Tag = "Package ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(23, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Links Operation Window";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPackageId);
            this.Controls.Add(this.txtProSupId);
            this.Controls.Add(this.btnAssignPackage);
            this.Controls.Add(this.btnSearchPackage);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridViewLink);
            this.Controls.Add(this.btnSearchSup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.btnAssign);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchSup;
        private System.Windows.Forms.DataGridView dataGridViewLink;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnSearchPackage;
        private System.Windows.Forms.Button btnAssignPackage;
        private System.Windows.Forms.TextBox txtProSupId;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.Label label5;
    }
}