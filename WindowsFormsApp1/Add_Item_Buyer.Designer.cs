namespace WindowsFormsApp1
{
    partial class Add_Item_Buyer
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
            this.lblCancelAddItemToBuyer = new System.Windows.Forms.Label();
            this.btnCancelAddItemToBuyer = new System.Windows.Forms.Button();
            this.grpBuyerInfo = new System.Windows.Forms.GroupBox();
            this.lblChooseBuyerForItem = new System.Windows.Forms.Label();
            this.cmbboxChooseFromListOfBuyers = new System.Windows.Forms.ComboBox();
            this.btnContinueAddItemForBuyer = new System.Windows.Forms.Button();
            this.grpBuyerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCancelAddItemToBuyer
            // 
            this.lblCancelAddItemToBuyer.AutoSize = true;
            this.lblCancelAddItemToBuyer.Location = new System.Drawing.Point(398, 262);
            this.lblCancelAddItemToBuyer.Name = "lblCancelAddItemToBuyer";
            this.lblCancelAddItemToBuyer.Size = new System.Drawing.Size(96, 13);
            this.lblCancelAddItemToBuyer.TabIndex = 5;
            this.lblCancelAddItemToBuyer.Text = "(Cancel - Go back)";
            this.lblCancelAddItemToBuyer.Click += new System.EventHandler(this.lblCancelAddItemToBuyer_Click);
            // 
            // btnCancelAddItemToBuyer
            // 
            this.btnCancelAddItemToBuyer.Location = new System.Drawing.Point(305, 247);
            this.btnCancelAddItemToBuyer.Name = "btnCancelAddItemToBuyer";
            this.btnCancelAddItemToBuyer.Size = new System.Drawing.Size(87, 42);
            this.btnCancelAddItemToBuyer.TabIndex = 4;
            this.btnCancelAddItemToBuyer.Text = "Cancel";
            this.btnCancelAddItemToBuyer.UseVisualStyleBackColor = true;
            this.btnCancelAddItemToBuyer.Click += new System.EventHandler(this.btnCancelAddItemToBuyer_Click);
            // 
            // grpBuyerInfo
            // 
            this.grpBuyerInfo.Controls.Add(this.btnContinueAddItemForBuyer);
            this.grpBuyerInfo.Controls.Add(this.cmbboxChooseFromListOfBuyers);
            this.grpBuyerInfo.Controls.Add(this.lblChooseBuyerForItem);
            this.grpBuyerInfo.Location = new System.Drawing.Point(102, 34);
            this.grpBuyerInfo.Name = "grpBuyerInfo";
            this.grpBuyerInfo.Size = new System.Drawing.Size(566, 185);
            this.grpBuyerInfo.TabIndex = 6;
            this.grpBuyerInfo.TabStop = false;
            this.grpBuyerInfo.Text = "Adding the item:";
            // 
            // lblChooseBuyerForItem
            // 
            this.lblChooseBuyerForItem.AutoSize = true;
            this.lblChooseBuyerForItem.Location = new System.Drawing.Point(168, 68);
            this.lblChooseBuyerForItem.Name = "lblChooseBuyerForItem";
            this.lblChooseBuyerForItem.Size = new System.Drawing.Size(240, 13);
            this.lblChooseBuyerForItem.TabIndex = 0;
            this.lblChooseBuyerForItem.Text = "Choose one of the existing buyers (dropdown list):";
            // 
            // cmbboxChooseFromListOfBuyers
            // 
            this.cmbboxChooseFromListOfBuyers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxChooseFromListOfBuyers.FormattingEnabled = true;
            this.cmbboxChooseFromListOfBuyers.Location = new System.Drawing.Point(218, 99);
            this.cmbboxChooseFromListOfBuyers.Name = "cmbboxChooseFromListOfBuyers";
            this.cmbboxChooseFromListOfBuyers.Size = new System.Drawing.Size(121, 21);
            this.cmbboxChooseFromListOfBuyers.TabIndex = 1;
            this.cmbboxChooseFromListOfBuyers.SelectedIndexChanged += new System.EventHandler(this.cmbboxChooseFromListOfBuyers_SelectedIndexChanged);
            // 
            // btnContinueAddItemForBuyer
            // 
            this.btnContinueAddItemForBuyer.Location = new System.Drawing.Point(243, 136);
            this.btnContinueAddItemForBuyer.Name = "btnContinueAddItemForBuyer";
            this.btnContinueAddItemForBuyer.Size = new System.Drawing.Size(75, 23);
            this.btnContinueAddItemForBuyer.TabIndex = 2;
            this.btnContinueAddItemForBuyer.Text = "OK";
            this.btnContinueAddItemForBuyer.UseVisualStyleBackColor = true;
            this.btnContinueAddItemForBuyer.Click += new System.EventHandler(this.btnContinueAddItemForBuyer_Click);
            // 
            // Add_Item_Buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.grpBuyerInfo);
            this.Controls.Add(this.lblCancelAddItemToBuyer);
            this.Controls.Add(this.btnCancelAddItemToBuyer);
            this.Name = "Add_Item_Buyer";
            this.Text = "Add item to buyer";
            this.grpBuyerInfo.ResumeLayout(false);
            this.grpBuyerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancelAddItemToBuyer;
        private System.Windows.Forms.Button btnCancelAddItemToBuyer;
        private System.Windows.Forms.GroupBox grpBuyerInfo;
        private System.Windows.Forms.Label lblChooseBuyerForItem;
        private System.Windows.Forms.ComboBox cmbboxChooseFromListOfBuyers;
        private System.Windows.Forms.Button btnContinueAddItemForBuyer;
    }
}