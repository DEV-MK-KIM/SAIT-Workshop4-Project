namespace ObjectDataSourceTravelExperts
{
    partial class frmSupplierUpdate
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
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label supplierIDLabel;
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            supNameLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(60, 86);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(79, 13);
            supNameLabel.TabIndex = 1;
            supNameLabel.Text = "Supplier Name:";
            // 
            // txtSupName
            // 
            this.txtSupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupName", true));
            this.txtSupName.Location = new System.Drawing.Point(145, 83);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(156, 20);
            this.txtSupName.TabIndex = 2;
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(77, 50);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(62, 13);
            supplierIDLabel.TabIndex = 3;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(145, 128);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataSource = typeof(TravelExpertsData.Suppliers);
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupplierID", true));
            this.supplierIDTextBox.Location = new System.Drawing.Point(145, 47);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.ReadOnly = true;
            this.supplierIDTextBox.Size = new System.Drawing.Size(97, 20);
            this.supplierIDTextBox.TabIndex = 7;
            // 
            // frmSupplierUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 228);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(supplierIDLabel);
            this.Name = "frmSupplierUpdate";
            this.Text = "frmSupplierUpdate";
            this.Load += new System.EventHandler(this.frmSupplierUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox supplierIDTextBox;
    }
}