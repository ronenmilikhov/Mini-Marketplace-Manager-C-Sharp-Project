namespace WindowsFormsApp1
{
    partial class Add_Item_Seller
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
            this.grpSellerInfo = new System.Windows.Forms.GroupBox();
            this.cmbboxChooseFromListOfSellers = new System.Windows.Forms.ComboBox();
            this.lblChooseSellerForItem = new System.Windows.Forms.Label();
            this.btnContinueAddingItemForSeller = new System.Windows.Forms.Button();
            this.btnCancelAddItemToSeller = new System.Windows.Forms.Button();
            this.lblCancelAddItemToSeller = new System.Windows.Forms.Label();
            this.grpSellerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSellerInfo
            // 
            this.grpSellerInfo.Controls.Add(this.cmbboxChooseFromListOfSellers);
            this.grpSellerInfo.Controls.Add(this.lblChooseSellerForItem);
            this.grpSellerInfo.Controls.Add(this.btnContinueAddingItemForSeller);
            this.grpSellerInfo.Location = new System.Drawing.Point(85, 36);
            this.grpSellerInfo.Name = "grpSellerInfo";
            this.grpSellerInfo.Size = new System.Drawing.Size(593, 180);
            this.grpSellerInfo.TabIndex = 0;
            this.grpSellerInfo.TabStop = false;
            this.grpSellerInfo.Text = "Adding the item:";
            this.grpSellerInfo.Enter += new System.EventHandler(this.grpSellerInfo_Enter);
            // 
            // cmbboxChooseFromListOfSellers
            // 
            this.cmbboxChooseFromListOfSellers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxChooseFromListOfSellers.FormattingEnabled = true;
            this.cmbboxChooseFromListOfSellers.Location = new System.Drawing.Point(250, 85);
            this.cmbboxChooseFromListOfSellers.Name = "cmbboxChooseFromListOfSellers";
            this.cmbboxChooseFromListOfSellers.Size = new System.Drawing.Size(121, 21);
            this.cmbboxChooseFromListOfSellers.TabIndex = 4;
            this.cmbboxChooseFromListOfSellers.SelectedIndexChanged += new System.EventHandler(this.cmbboxChooseFromListOfSellers_SelectedIndexChanged);
            // 
            // lblChooseSellerForItem
            // 
            this.lblChooseSellerForItem.AutoSize = true;
            this.lblChooseSellerForItem.Location = new System.Drawing.Point(195, 53);
            this.lblChooseSellerForItem.Name = "lblChooseSellerForItem";
            this.lblChooseSellerForItem.Size = new System.Drawing.Size(238, 13);
            this.lblChooseSellerForItem.TabIndex = 3;
            this.lblChooseSellerForItem.Text = "Choose one of the existing sellers (dropdown list):";
            // 
            // btnContinueAddingItemForSeller
            // 
            this.btnContinueAddingItemForSeller.Location = new System.Drawing.Point(271, 124);
            this.btnContinueAddingItemForSeller.Name = "btnContinueAddingItemForSeller";
            this.btnContinueAddingItemForSeller.Size = new System.Drawing.Size(78, 27);
            this.btnContinueAddingItemForSeller.TabIndex = 2;
            this.btnContinueAddingItemForSeller.Text = "OK";
            this.btnContinueAddingItemForSeller.UseVisualStyleBackColor = true;
            this.btnContinueAddingItemForSeller.Click += new System.EventHandler(this.btnAcceptProductForSeller_Click);
            // 
            // btnCancelAddItemToSeller
            // 
            this.btnCancelAddItemToSeller.Location = new System.Drawing.Point(292, 235);
            this.btnCancelAddItemToSeller.Name = "btnCancelAddItemToSeller";
            this.btnCancelAddItemToSeller.Size = new System.Drawing.Size(87, 42);
            this.btnCancelAddItemToSeller.TabIndex = 1;
            this.btnCancelAddItemToSeller.Text = "Cancel";
            this.btnCancelAddItemToSeller.UseVisualStyleBackColor = true;
            this.btnCancelAddItemToSeller.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCancelAddItemToSeller
            // 
            this.lblCancelAddItemToSeller.AutoSize = true;
            this.lblCancelAddItemToSeller.Location = new System.Drawing.Point(385, 250);
            this.lblCancelAddItemToSeller.Name = "lblCancelAddItemToSeller";
            this.lblCancelAddItemToSeller.Size = new System.Drawing.Size(96, 13);
            this.lblCancelAddItemToSeller.TabIndex = 2;
            this.lblCancelAddItemToSeller.Text = "(Cancel - Go back)";
            this.lblCancelAddItemToSeller.Click += new System.EventHandler(this.lblCancelAddItemToSeller_Click);
            // 
            // Add_Item_Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.lblCancelAddItemToSeller);
            this.Controls.Add(this.btnCancelAddItemToSeller);
            this.Controls.Add(this.grpSellerInfo);
            this.Name = "Add_Item_Seller";
            this.Text = "Add item to seller";
            this.grpSellerInfo.ResumeLayout(false);
            this.grpSellerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSellerInfo;
        private System.Windows.Forms.Button btnContinueAddingItemForSeller;
        private System.Windows.Forms.Button btnCancelAddItemToSeller;
        private System.Windows.Forms.Label lblCancelAddItemToSeller;
        private System.Windows.Forms.ComboBox cmbboxChooseFromListOfSellers;
        private System.Windows.Forms.Label lblChooseSellerForItem;
    }
}