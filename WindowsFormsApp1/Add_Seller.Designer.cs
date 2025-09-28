namespace WindowsFormsApp1
{
    partial class Add_Seller
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
            this.grpInputSellerDetails = new System.Windows.Forms.GroupBox();
            this.grpSellerAddressDetails = new System.Windows.Forms.GroupBox();
            this.txtSellerStateName = new System.Windows.Forms.TextBox();
            this.lblSellerStateName = new System.Windows.Forms.Label();
            this.txtSellerBuildingNum = new System.Windows.Forms.TextBox();
            this.lblSellerBuildingNum = new System.Windows.Forms.Label();
            this.txtSellerStreetName = new System.Windows.Forms.TextBox();
            this.lblSellerStreetName = new System.Windows.Forms.Label();
            this.txtSellerCityName = new System.Windows.Forms.TextBox();
            this.lblSellerCityName = new System.Windows.Forms.Label();
            this.txtSellerPassword = new System.Windows.Forms.TextBox();
            this.lblSellerPassword = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.btnAcceptNewSeller = new System.Windows.Forms.Button();
            this.btnCancelSeller = new System.Windows.Forms.Button();
            this.lblCancelSeller = new System.Windows.Forms.Label();
            this.grpInputSellerDetails.SuspendLayout();
            this.grpSellerAddressDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputSellerDetails
            // 
            this.grpInputSellerDetails.Controls.Add(this.grpSellerAddressDetails);
            this.grpInputSellerDetails.Controls.Add(this.txtSellerPassword);
            this.grpInputSellerDetails.Controls.Add(this.lblSellerPassword);
            this.grpInputSellerDetails.Controls.Add(this.txtSellerName);
            this.grpInputSellerDetails.Controls.Add(this.lblSellerName);
            this.grpInputSellerDetails.Location = new System.Drawing.Point(213, 12);
            this.grpInputSellerDetails.Name = "grpInputSellerDetails";
            this.grpInputSellerDetails.Size = new System.Drawing.Size(395, 270);
            this.grpInputSellerDetails.TabIndex = 0;
            this.grpInputSellerDetails.TabStop = false;
            this.grpInputSellerDetails.Text = "Input the seller details below:";
            this.grpInputSellerDetails.Enter += new System.EventHandler(this.grpInputSellerDetails_Enter);
            // 
            // grpSellerAddressDetails
            // 
            this.grpSellerAddressDetails.Controls.Add(this.txtSellerStateName);
            this.grpSellerAddressDetails.Controls.Add(this.lblSellerStateName);
            this.grpSellerAddressDetails.Controls.Add(this.txtSellerBuildingNum);
            this.grpSellerAddressDetails.Controls.Add(this.lblSellerBuildingNum);
            this.grpSellerAddressDetails.Controls.Add(this.txtSellerStreetName);
            this.grpSellerAddressDetails.Controls.Add(this.lblSellerStreetName);
            this.grpSellerAddressDetails.Controls.Add(this.txtSellerCityName);
            this.grpSellerAddressDetails.Controls.Add(this.lblSellerCityName);
            this.grpSellerAddressDetails.Location = new System.Drawing.Point(0, 103);
            this.grpSellerAddressDetails.Name = "grpSellerAddressDetails";
            this.grpSellerAddressDetails.Size = new System.Drawing.Size(395, 167);
            this.grpSellerAddressDetails.TabIndex = 4;
            this.grpSellerAddressDetails.TabStop = false;
            this.grpSellerAddressDetails.Text = "Address details:";
            this.grpSellerAddressDetails.Enter += new System.EventHandler(this.grpSellerAddressDetails_Enter);
            // 
            // txtSellerStateName
            // 
            this.txtSellerStateName.Location = new System.Drawing.Point(233, 108);
            this.txtSellerStateName.Name = "txtSellerStateName";
            this.txtSellerStateName.Size = new System.Drawing.Size(100, 20);
            this.txtSellerStateName.TabIndex = 7;
            this.txtSellerStateName.TextChanged += new System.EventHandler(this.txtStateName_TextChanged);
            // 
            // lblSellerStateName
            // 
            this.lblSellerStateName.AutoSize = true;
            this.lblSellerStateName.Location = new System.Drawing.Point(266, 92);
            this.lblSellerStateName.Name = "lblSellerStateName";
            this.lblSellerStateName.Size = new System.Drawing.Size(35, 13);
            this.lblSellerStateName.TabIndex = 6;
            this.lblSellerStateName.Text = "State:";
            this.lblSellerStateName.Click += new System.EventHandler(this.lblSellerStateName_Click);
            // 
            // txtSellerBuildingNum
            // 
            this.txtSellerBuildingNum.Location = new System.Drawing.Point(51, 108);
            this.txtSellerBuildingNum.Name = "txtSellerBuildingNum";
            this.txtSellerBuildingNum.Size = new System.Drawing.Size(100, 20);
            this.txtSellerBuildingNum.TabIndex = 5;
            this.txtSellerBuildingNum.TextChanged += new System.EventHandler(this.txtSellerBuildingNum_TextChanged);
            // 
            // lblSellerBuildingNum
            // 
            this.lblSellerBuildingNum.AutoSize = true;
            this.lblSellerBuildingNum.Location = new System.Drawing.Point(55, 92);
            this.lblSellerBuildingNum.Name = "lblSellerBuildingNum";
            this.lblSellerBuildingNum.Size = new System.Drawing.Size(85, 13);
            this.lblSellerBuildingNum.TabIndex = 4;
            this.lblSellerBuildingNum.Text = "Building number:";
            this.lblSellerBuildingNum.Click += new System.EventHandler(this.lblSellerBuildingNum_Click);
            // 
            // txtSellerStreetName
            // 
            this.txtSellerStreetName.Location = new System.Drawing.Point(233, 48);
            this.txtSellerStreetName.Name = "txtSellerStreetName";
            this.txtSellerStreetName.Size = new System.Drawing.Size(100, 20);
            this.txtSellerStreetName.TabIndex = 3;
            this.txtSellerStreetName.TextChanged += new System.EventHandler(this.txtSellerStreetName_TextChanged);
            // 
            // lblSellerStreetName
            // 
            this.lblSellerStreetName.AutoSize = true;
            this.lblSellerStreetName.Location = new System.Drawing.Point(266, 32);
            this.lblSellerStreetName.Name = "lblSellerStreetName";
            this.lblSellerStreetName.Size = new System.Drawing.Size(38, 13);
            this.lblSellerStreetName.TabIndex = 2;
            this.lblSellerStreetName.Text = "Street:";
            this.lblSellerStreetName.Click += new System.EventHandler(this.lblSellerStreetName_Click);
            // 
            // txtSellerCityName
            // 
            this.txtSellerCityName.Location = new System.Drawing.Point(51, 48);
            this.txtSellerCityName.Name = "txtSellerCityName";
            this.txtSellerCityName.Size = new System.Drawing.Size(100, 20);
            this.txtSellerCityName.TabIndex = 1;
            this.txtSellerCityName.TextChanged += new System.EventHandler(this.txtCityName_TextChanged);
            // 
            // lblSellerCityName
            // 
            this.lblSellerCityName.AutoSize = true;
            this.lblSellerCityName.Location = new System.Drawing.Point(87, 32);
            this.lblSellerCityName.Name = "lblSellerCityName";
            this.lblSellerCityName.Size = new System.Drawing.Size(27, 13);
            this.lblSellerCityName.TabIndex = 0;
            this.lblSellerCityName.Text = "City:";
            this.lblSellerCityName.Click += new System.EventHandler(this.lblSellerCityName_Click);
            // 
            // txtSellerPassword
            // 
            this.txtSellerPassword.Location = new System.Drawing.Point(233, 57);
            this.txtSellerPassword.Name = "txtSellerPassword";
            this.txtSellerPassword.Size = new System.Drawing.Size(118, 20);
            this.txtSellerPassword.TabIndex = 3;
            this.txtSellerPassword.TextChanged += new System.EventHandler(this.txtSellerPassword_TextChanged);
            // 
            // lblSellerPassword
            // 
            this.lblSellerPassword.AutoSize = true;
            this.lblSellerPassword.Location = new System.Drawing.Point(266, 41);
            this.lblSellerPassword.Name = "lblSellerPassword";
            this.lblSellerPassword.Size = new System.Drawing.Size(56, 13);
            this.lblSellerPassword.TabIndex = 2;
            this.lblSellerPassword.Text = "Password:";
            this.lblSellerPassword.Click += new System.EventHandler(this.lblSellerPassword_Click);
            // 
            // txtSellerName
            // 
            this.txtSellerName.Location = new System.Drawing.Point(36, 57);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(115, 20);
            this.txtSellerName.TabIndex = 1;
            this.txtSellerName.TextChanged += new System.EventHandler(this.txtSellerName_TextChanged);
            // 
            // lblSellerName
            // 
            this.lblSellerName.Location = new System.Drawing.Point(62, 39);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(70, 15);
            this.lblSellerName.TabIndex = 0;
            this.lblSellerName.Text = "Seller name:";
            this.lblSellerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAcceptNewSeller
            // 
            this.btnAcceptNewSeller.Location = new System.Drawing.Point(357, 301);
            this.btnAcceptNewSeller.Name = "btnAcceptNewSeller";
            this.btnAcceptNewSeller.Size = new System.Drawing.Size(98, 40);
            this.btnAcceptNewSeller.TabIndex = 1;
            this.btnAcceptNewSeller.Text = "Add Seller";
            this.btnAcceptNewSeller.UseVisualStyleBackColor = true;
            this.btnAcceptNewSeller.Click += new System.EventHandler(this.btnAcceptNewSeller_Click);
            // 
            // btnCancelSeller
            // 
            this.btnCancelSeller.Location = new System.Drawing.Point(357, 347);
            this.btnCancelSeller.Name = "btnCancelSeller";
            this.btnCancelSeller.Size = new System.Drawing.Size(98, 43);
            this.btnCancelSeller.TabIndex = 2;
            this.btnCancelSeller.Text = "Cancel";
            this.btnCancelSeller.UseVisualStyleBackColor = true;
            this.btnCancelSeller.Click += new System.EventHandler(this.btnCancelSeller_Click);
            // 
            // lblCancelSeller
            // 
            this.lblCancelSeller.AutoSize = true;
            this.lblCancelSeller.Location = new System.Drawing.Point(468, 362);
            this.lblCancelSeller.Name = "lblCancelSeller";
            this.lblCancelSeller.Size = new System.Drawing.Size(96, 13);
            this.lblCancelSeller.TabIndex = 3;
            this.lblCancelSeller.Text = "(Cancel - Go back)";
            this.lblCancelSeller.Click += new System.EventHandler(this.lblCancelSeller_Click);
            // 
            // Add_Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.lblCancelSeller);
            this.Controls.Add(this.btnCancelSeller);
            this.Controls.Add(this.btnAcceptNewSeller);
            this.Controls.Add(this.grpInputSellerDetails);
            this.Name = "Add_Seller";
            this.Text = "Add a seller";
            this.Load += new System.EventHandler(this.Add_Seller_Load);
            this.grpInputSellerDetails.ResumeLayout(false);
            this.grpInputSellerDetails.PerformLayout();
            this.grpSellerAddressDetails.ResumeLayout(false);
            this.grpSellerAddressDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputSellerDetails;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.TextBox txtSellerPassword;
        private System.Windows.Forms.Label lblSellerPassword;
        private System.Windows.Forms.GroupBox grpSellerAddressDetails;
        private System.Windows.Forms.TextBox txtSellerCityName;
        private System.Windows.Forms.Label lblSellerCityName;
        private System.Windows.Forms.TextBox txtSellerStreetName;
        private System.Windows.Forms.Label lblSellerStreetName;
        private System.Windows.Forms.TextBox txtSellerBuildingNum;
        private System.Windows.Forms.Label lblSellerBuildingNum;
        private System.Windows.Forms.TextBox txtSellerStateName;
        private System.Windows.Forms.Label lblSellerStateName;
        private System.Windows.Forms.Button btnAcceptNewSeller;
        private System.Windows.Forms.Button btnCancelSeller;
        private System.Windows.Forms.Label lblCancelSeller;
    }
}