namespace ObjectDataSourceTravelExperts
{
    partial class frmProductsUpdate
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
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label productIDLabel;
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.butnCancel = new System.Windows.Forms.Button();
            prodNameLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(25, 66);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(63, 13);
            prodNameLabel.TabIndex = 0;
            prodNameLabel.Text = "Prod Name:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(27, 26);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 2;
            productIDLabel.Text = "Product ID:";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(94, 63);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(178, 20);
            this.txtProdName.TabIndex = 1;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(94, 23);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(178, 20);
            this.productIDTextBox.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(96, 108);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // butnCancel
            // 
            this.butnCancel.Location = new System.Drawing.Point(197, 108);
            this.butnCancel.Name = "butnCancel";
            this.butnCancel.Size = new System.Drawing.Size(75, 23);
            this.butnCancel.TabIndex = 8;
            this.butnCancel.Text = "Cancel";
            this.butnCancel.UseVisualStyleBackColor = true;
            this.butnCancel.Click += new System.EventHandler(this.butnCancel_Click);
            // 
            // frmProductsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 159);
            this.Controls.Add(this.butnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.txtProdName);
            this.Name = "frmProductsUpdate";
            this.Text = "frmProductsUpdate";
            this.Load += new System.EventHandler(this.frmProductsUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.Button butnCancel;
        private System.Windows.Forms.Button btnUpdate;
        //private System.Windows.Forms.Button butnCancel;
    }
}