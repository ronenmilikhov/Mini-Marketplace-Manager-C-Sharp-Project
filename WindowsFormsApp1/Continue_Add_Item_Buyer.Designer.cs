namespace WindowsFormsApp1
{
    partial class Continue_Add_Item_Buyer
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
            this.comboboxSellersList = new System.Windows.Forms.ComboBox();
            this.lblChooseSeller = new System.Windows.Forms.Label();
            this.comboboxItemsList = new System.Windows.Forms.ComboBox();
            this.lblChooseItem = new System.Windows.Forms.Label();
            this.lblPriceOfItem = new System.Windows.Forms.Label();
            this.lblDisplayItemPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDisplayCategory = new System.Windows.Forms.Label();
            this.btnPurchaseItem = new System.Windows.Forms.Button();
            this.btnCancelItemPurchase = new System.Windows.Forms.Button();
            this.lblCancelItemPurchase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboboxSellersList
            // 
            this.comboboxSellersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSellersList.FormattingEnabled = true;
            this.comboboxSellersList.Location = new System.Drawing.Point(152, 61);
            this.comboboxSellersList.Name = "comboboxSellersList";
            this.comboboxSellersList.Size = new System.Drawing.Size(107, 21);
            this.comboboxSellersList.TabIndex = 0;
            this.comboboxSellersList.SelectedIndexChanged += new System.EventHandler(this.comboboxSellersList_SelectedIndexChanged);
            // 
            // lblChooseSeller
            // 
            this.lblChooseSeller.AutoSize = true;
            this.lblChooseSeller.Location = new System.Drawing.Point(100, 42);
            this.lblChooseSeller.Name = "lblChooseSeller";
            this.lblChooseSeller.Size = new System.Drawing.Size(228, 13);
            this.lblChooseSeller.TabIndex = 1;
            this.lblChooseSeller.Text = "Choose one of the sellers you wish to buy from:";
            this.lblChooseSeller.Click += new System.EventHandler(this.lblChooseSeller_Click);
            // 
            // comboboxItemsList
            // 
            this.comboboxItemsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxItemsList.FormattingEnabled = true;
            this.comboboxItemsList.Location = new System.Drawing.Point(527, 61);
            this.comboboxItemsList.Name = "comboboxItemsList";
            this.comboboxItemsList.Size = new System.Drawing.Size(112, 21);
            this.comboboxItemsList.TabIndex = 2;
            this.comboboxItemsList.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblChooseItem
            // 
            this.lblChooseItem.AutoSize = true;
            this.lblChooseItem.Location = new System.Drawing.Point(489, 42);
            this.lblChooseItem.Name = "lblChooseItem";
            this.lblChooseItem.Size = new System.Drawing.Size(200, 13);
            this.lblChooseItem.TabIndex = 3;
            this.lblChooseItem.Text = "Choose one of the items you wish to buy:";
            this.lblChooseItem.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPriceOfItem
            // 
            this.lblPriceOfItem.AutoSize = true;
            this.lblPriceOfItem.Location = new System.Drawing.Point(221, 110);
            this.lblPriceOfItem.Name = "lblPriceOfItem";
            this.lblPriceOfItem.Size = new System.Drawing.Size(86, 13);
            this.lblPriceOfItem.TabIndex = 4;
            this.lblPriceOfItem.Text = "Price of the item:";
            this.lblPriceOfItem.Click += new System.EventHandler(this.lblPriceOfItem_Click);
            // 
            // lblDisplayItemPrice
            // 
            this.lblDisplayItemPrice.AutoSize = true;
            this.lblDisplayItemPrice.Location = new System.Drawing.Point(330, 110);
            this.lblDisplayItemPrice.Name = "lblDisplayItemPrice";
            this.lblDisplayItemPrice.Size = new System.Drawing.Size(246, 13);
            this.lblDisplayItemPrice.TabIndex = 5;
            this.lblDisplayItemPrice.Text = "(price based on choice which item did you choose)";
            this.lblDisplayItemPrice.Click += new System.EventHandler(this.lblDisplayItemPrice_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(244, 140);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblDisplayCategory
            // 
            this.lblDisplayCategory.AutoSize = true;
            this.lblDisplayCategory.Location = new System.Drawing.Point(330, 140);
            this.lblDisplayCategory.Name = "lblDisplayCategory";
            this.lblDisplayCategory.Size = new System.Drawing.Size(264, 13);
            this.lblDisplayCategory.TabIndex = 7;
            this.lblDisplayCategory.Text = "(category based on choice which item did you choose)";
            this.lblDisplayCategory.Click += new System.EventHandler(this.lblDisplayCategory_Click);
            // 
            // btnPurchaseItem
            // 
            this.btnPurchaseItem.Location = new System.Drawing.Point(348, 181);
            this.btnPurchaseItem.Name = "btnPurchaseItem";
            this.btnPurchaseItem.Size = new System.Drawing.Size(89, 33);
            this.btnPurchaseItem.TabIndex = 8;
            this.btnPurchaseItem.Text = "Purchase";
            this.btnPurchaseItem.UseVisualStyleBackColor = true;
            this.btnPurchaseItem.Click += new System.EventHandler(this.btnPurchaseItem_Click);
            // 
            // btnCancelItemPurchase
            // 
            this.btnCancelItemPurchase.Location = new System.Drawing.Point(295, 230);
            this.btnCancelItemPurchase.Name = "btnCancelItemPurchase";
            this.btnCancelItemPurchase.Size = new System.Drawing.Size(89, 33);
            this.btnCancelItemPurchase.TabIndex = 9;
            this.btnCancelItemPurchase.Text = "Cancel";
            this.btnCancelItemPurchase.UseVisualStyleBackColor = true;
            this.btnCancelItemPurchase.Click += new System.EventHandler(this.btnCancelItemPurchase_Click);
            // 
            // lblCancelItemPurchase
            // 
            this.lblCancelItemPurchase.AutoSize = true;
            this.lblCancelItemPurchase.Location = new System.Drawing.Point(402, 240);
            this.lblCancelItemPurchase.Name = "lblCancelItemPurchase";
            this.lblCancelItemPurchase.Size = new System.Drawing.Size(96, 13);
            this.lblCancelItemPurchase.TabIndex = 10;
            this.lblCancelItemPurchase.Text = "(Cancel - Go back)";
            this.lblCancelItemPurchase.Click += new System.EventHandler(this.lblCancelItemPurchase_Click);
            // 
            // Continue_Add_Item_Buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 294);
            this.Controls.Add(this.lblCancelItemPurchase);
            this.Controls.Add(this.btnCancelItemPurchase);
            this.Controls.Add(this.btnPurchaseItem);
            this.Controls.Add(this.lblDisplayCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDisplayItemPrice);
            this.Controls.Add(this.lblPriceOfItem);
            this.Controls.Add(this.lblChooseItem);
            this.Controls.Add(this.comboboxItemsList);
            this.Controls.Add(this.lblChooseSeller);
            this.Controls.Add(this.comboboxSellersList);
            this.Name = "Continue_Add_Item_Buyer";
            this.Text = "Adding item to buyer";
            this.Load += new System.EventHandler(this.Continue_Add_Item_Buyer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxSellersList;
        private System.Windows.Forms.Label lblChooseSeller;
        private System.Windows.Forms.ComboBox comboboxItemsList;
        private System.Windows.Forms.Label lblChooseItem;
        private System.Windows.Forms.Label lblPriceOfItem;
        private System.Windows.Forms.Label lblDisplayItemPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDisplayCategory;
        private System.Windows.Forms.Button btnPurchaseItem;
        private System.Windows.Forms.Button btnCancelItemPurchase;
        private System.Windows.Forms.Label lblCancelItemPurchase;
    }
}