namespace WindowsFormsApp1
{
    partial class Add_Buyer
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
            this.grpInputBuyerDetails = new System.Windows.Forms.GroupBox();
            this.grpBuyerAddressDetails = new System.Windows.Forms.GroupBox();
            this.txtBuyerStateName = new System.Windows.Forms.TextBox();
            this.lblBuyerStateName = new System.Windows.Forms.Label();
            this.txtBuyerBuildingNum = new System.Windows.Forms.TextBox();
            this.lblBuyerBuildingNum = new System.Windows.Forms.Label();
            this.txtBuyerStreetName = new System.Windows.Forms.TextBox();
            this.lblBuyerStreetName = new System.Windows.Forms.Label();
            this.txtBuyerCityName = new System.Windows.Forms.TextBox();
            this.lblBuyerCityName = new System.Windows.Forms.Label();
            this.txtBuyerPassword = new System.Windows.Forms.TextBox();
            this.lblBuyerPassword = new System.Windows.Forms.Label();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.lblCancelBuyer = new System.Windows.Forms.Label();
            this.btnCancelBuyer = new System.Windows.Forms.Button();
            this.btnAcceptNewBuyer = new System.Windows.Forms.Button();
            this.grpInputBuyerDetails.SuspendLayout();
            this.grpBuyerAddressDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputBuyerDetails
            // 
            this.grpInputBuyerDetails.Controls.Add(this.grpBuyerAddressDetails);
            this.grpInputBuyerDetails.Controls.Add(this.txtBuyerPassword);
            this.grpInputBuyerDetails.Controls.Add(this.lblBuyerPassword);
            this.grpInputBuyerDetails.Controls.Add(this.txtBuyerName);
            this.grpInputBuyerDetails.Controls.Add(this.lblBuyerName);
            this.grpInputBuyerDetails.Location = new System.Drawing.Point(204, 12);
            this.grpInputBuyerDetails.Name = "grpInputBuyerDetails";
            this.grpInputBuyerDetails.Size = new System.Drawing.Size(395, 270);
            this.grpInputBuyerDetails.TabIndex = 1;
            this.grpInputBuyerDetails.TabStop = false;
            this.grpInputBuyerDetails.Text = "Input the buyer details below:";
            this.grpInputBuyerDetails.Enter += new System.EventHandler(this.grpInputBuyerDetails_Enter);
            // 
            // grpBuyerAddressDetails
            // 
            this.grpBuyerAddressDetails.Controls.Add(this.txtBuyerStateName);
            this.grpBuyerAddressDetails.Controls.Add(this.lblBuyerStateName);
            this.grpBuyerAddressDetails.Controls.Add(this.txtBuyerBuildingNum);
            this.grpBuyerAddressDetails.Controls.Add(this.lblBuyerBuildingNum);
            this.grpBuyerAddressDetails.Controls.Add(this.txtBuyerStreetName);
            this.grpBuyerAddressDetails.Controls.Add(this.lblBuyerStreetName);
            this.grpBuyerAddressDetails.Controls.Add(this.txtBuyerCityName);
            this.grpBuyerAddressDetails.Controls.Add(this.lblBuyerCityName);
            this.grpBuyerAddressDetails.Location = new System.Drawing.Point(0, 103);
            this.grpBuyerAddressDetails.Name = "grpBuyerAddressDetails";
            this.grpBuyerAddressDetails.Size = new System.Drawing.Size(395, 167);
            this.grpBuyerAddressDetails.TabIndex = 4;
            this.grpBuyerAddressDetails.TabStop = false;
            this.grpBuyerAddressDetails.Text = "Address details:";
            this.grpBuyerAddressDetails.Enter += new System.EventHandler(this.grpBuyerAddressDetails_Enter);
            // 
            // txtBuyerStateName
            // 
            this.txtBuyerStateName.Location = new System.Drawing.Point(233, 108);
            this.txtBuyerStateName.Name = "txtBuyerStateName";
            this.txtBuyerStateName.Size = new System.Drawing.Size(100, 20);
            this.txtBuyerStateName.TabIndex = 7;
            this.txtBuyerStateName.TextChanged += new System.EventHandler(this.txtStateName_TextChanged);
            // 
            // lblBuyerStateName
            // 
            this.lblBuyerStateName.AutoSize = true;
            this.lblBuyerStateName.Location = new System.Drawing.Point(266, 92);
            this.lblBuyerStateName.Name = "lblBuyerStateName";
            this.lblBuyerStateName.Size = new System.Drawing.Size(35, 13);
            this.lblBuyerStateName.TabIndex = 6;
            this.lblBuyerStateName.Text = "State:";
            this.lblBuyerStateName.Click += new System.EventHandler(this.lblBuyerStateName_Click);
            // 
            // txtBuyerBuildingNum
            // 
            this.txtBuyerBuildingNum.Location = new System.Drawing.Point(51, 108);
            this.txtBuyerBuildingNum.Name = "txtBuyerBuildingNum";
            this.txtBuyerBuildingNum.Size = new System.Drawing.Size(100, 20);
            this.txtBuyerBuildingNum.TabIndex = 5;
            this.txtBuyerBuildingNum.TextChanged += new System.EventHandler(this.txtBuildingNum_TextChanged);
            // 
            // lblBuyerBuildingNum
            // 
            this.lblBuyerBuildingNum.AutoSize = true;
            this.lblBuyerBuildingNum.Location = new System.Drawing.Point(55, 92);
            this.lblBuyerBuildingNum.Name = "lblBuyerBuildingNum";
            this.lblBuyerBuildingNum.Size = new System.Drawing.Size(85, 13);
            this.lblBuyerBuildingNum.TabIndex = 4;
            this.lblBuyerBuildingNum.Text = "Building number:";
            this.lblBuyerBuildingNum.Click += new System.EventHandler(this.lblBuyerBuildingNum_Click);
            // 
            // txtBuyerStreetName
            // 
            this.txtBuyerStreetName.Location = new System.Drawing.Point(233, 48);
            this.txtBuyerStreetName.Name = "txtBuyerStreetName";
            this.txtBuyerStreetName.Size = new System.Drawing.Size(100, 20);
            this.txtBuyerStreetName.TabIndex = 3;
            this.txtBuyerStreetName.TextChanged += new System.EventHandler(this.txtBuyerStreetName_TextChanged);
            // 
            // lblBuyerStreetName
            // 
            this.lblBuyerStreetName.AutoSize = true;
            this.lblBuyerStreetName.Location = new System.Drawing.Point(266, 32);
            this.lblBuyerStreetName.Name = "lblBuyerStreetName";
            this.lblBuyerStreetName.Size = new System.Drawing.Size(38, 13);
            this.lblBuyerStreetName.TabIndex = 2;
            this.lblBuyerStreetName.Text = "Street:";
            this.lblBuyerStreetName.Click += new System.EventHandler(this.lblBuyerStreetName_Click);
            // 
            // txtBuyerCityName
            // 
            this.txtBuyerCityName.Location = new System.Drawing.Point(51, 48);
            this.txtBuyerCityName.Name = "txtBuyerCityName";
            this.txtBuyerCityName.Size = new System.Drawing.Size(100, 20);
            this.txtBuyerCityName.TabIndex = 1;
            this.txtBuyerCityName.TextChanged += new System.EventHandler(this.txtBuyerCityName_TextChanged);
            // 
            // lblBuyerCityName
            // 
            this.lblBuyerCityName.AutoSize = true;
            this.lblBuyerCityName.Location = new System.Drawing.Point(87, 32);
            this.lblBuyerCityName.Name = "lblBuyerCityName";
            this.lblBuyerCityName.Size = new System.Drawing.Size(27, 13);
            this.lblBuyerCityName.TabIndex = 0;
            this.lblBuyerCityName.Text = "City:";
            this.lblBuyerCityName.Click += new System.EventHandler(this.lblBuyerCityName_Click);
            // 
            // txtBuyerPassword
            // 
            this.txtBuyerPassword.Location = new System.Drawing.Point(233, 57);
            this.txtBuyerPassword.Name = "txtBuyerPassword";
            this.txtBuyerPassword.Size = new System.Drawing.Size(118, 20);
            this.txtBuyerPassword.TabIndex = 3;
            this.txtBuyerPassword.TextChanged += new System.EventHandler(this.txtSellerPassword_TextChanged);
            // 
            // lblBuyerPassword
            // 
            this.lblBuyerPassword.AutoSize = true;
            this.lblBuyerPassword.Location = new System.Drawing.Point(266, 41);
            this.lblBuyerPassword.Name = "lblBuyerPassword";
            this.lblBuyerPassword.Size = new System.Drawing.Size(56, 13);
            this.lblBuyerPassword.TabIndex = 2;
            this.lblBuyerPassword.Text = "Password:";
            this.lblBuyerPassword.Click += new System.EventHandler(this.lblBuyerPassword_Click);
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(36, 57);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(115, 20);
            this.txtBuyerName.TabIndex = 1;
            this.txtBuyerName.TextChanged += new System.EventHandler(this.txtSellerName_TextChanged);
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.Location = new System.Drawing.Point(62, 39);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(70, 15);
            this.lblBuyerName.TabIndex = 0;
            this.lblBuyerName.Text = "Buyer name:";
            this.lblBuyerName.Click += new System.EventHandler(this.lblBuyerName_Click);
            // 
            // lblCancelBuyer
            // 
            this.lblCancelBuyer.AutoSize = true;
            this.lblCancelBuyer.Location = new System.Drawing.Point(464, 364);
            this.lblCancelBuyer.Name = "lblCancelBuyer";
            this.lblCancelBuyer.Size = new System.Drawing.Size(96, 13);
            this.lblCancelBuyer.TabIndex = 6;
            this.lblCancelBuyer.Text = "(Cancel - Go back)";
            this.lblCancelBuyer.Click += new System.EventHandler(this.lblCancelBuyer_Click);
            // 
            // btnCancelBuyer
            // 
            this.btnCancelBuyer.Location = new System.Drawing.Point(353, 349);
            this.btnCancelBuyer.Name = "btnCancelBuyer";
            this.btnCancelBuyer.Size = new System.Drawing.Size(98, 43);
            this.btnCancelBuyer.TabIndex = 5;
            this.btnCancelBuyer.Text = "Cancel";
            this.btnCancelBuyer.UseVisualStyleBackColor = true;
            this.btnCancelBuyer.Click += new System.EventHandler(this.btnCancelBuyer_Click);
            // 
            // btnAcceptNewBuyer
            // 
            this.btnAcceptNewBuyer.Location = new System.Drawing.Point(353, 303);
            this.btnAcceptNewBuyer.Name = "btnAcceptNewBuyer";
            this.btnAcceptNewBuyer.Size = new System.Drawing.Size(98, 40);
            this.btnAcceptNewBuyer.TabIndex = 4;
            this.btnAcceptNewBuyer.Text = "Add Buyer";
            this.btnAcceptNewBuyer.UseVisualStyleBackColor = true;
            this.btnAcceptNewBuyer.Click += new System.EventHandler(this.btnAcceptNewBuyer_Click);
            // 
            // Add_Buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.lblCancelBuyer);
            this.Controls.Add(this.btnCancelBuyer);
            this.Controls.Add(this.btnAcceptNewBuyer);
            this.Controls.Add(this.grpInputBuyerDetails);
            this.Name = "Add_Buyer";
            this.Text = "Add a buyer";
            this.grpInputBuyerDetails.ResumeLayout(false);
            this.grpInputBuyerDetails.PerformLayout();
            this.grpBuyerAddressDetails.ResumeLayout(false);
            this.grpBuyerAddressDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputBuyerDetails;
        private System.Windows.Forms.GroupBox grpBuyerAddressDetails;
        private System.Windows.Forms.TextBox txtBuyerStateName;
        private System.Windows.Forms.Label lblBuyerStateName;
        private System.Windows.Forms.TextBox txtBuyerBuildingNum;
        private System.Windows.Forms.Label lblBuyerBuildingNum;
        private System.Windows.Forms.TextBox txtBuyerStreetName;
        private System.Windows.Forms.Label lblBuyerStreetName;
        private System.Windows.Forms.TextBox txtBuyerCityName;
        private System.Windows.Forms.Label lblBuyerCityName;
        private System.Windows.Forms.TextBox txtBuyerPassword;
        private System.Windows.Forms.Label lblBuyerPassword;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.Label lblCancelBuyer;
        private System.Windows.Forms.Button btnCancelBuyer;
        private System.Windows.Forms.Button btnAcceptNewBuyer;
    }
}