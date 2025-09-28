namespace WindowsFormsApp1
{
    partial class Continue_Add_Item_Seller
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
            this.grpItemDetailsForSeller = new System.Windows.Forms.GroupBox();
            this.rdiobtnClothingCategory = new System.Windows.Forms.RadioButton();
            this.rdiobtnOfficeCategory = new System.Windows.Forms.RadioButton();
            this.rdiobtnElectricCategory = new System.Windows.Forms.RadioButton();
            this.rdiobtnKidsCategory = new System.Windows.Forms.RadioButton();
            this.txtProductPriceForSeller = new System.Windows.Forms.TextBox();
            this.lblItemPriceForSeller = new System.Windows.Forms.Label();
            this.lblItemCategoryForSeller = new System.Windows.Forms.Label();
            this.txtItemNameForSeller = new System.Windows.Forms.TextBox();
            this.lblProductNameForSeller = new System.Windows.Forms.Label();
            this.btnCancelContinueAddItemToSeller = new System.Windows.Forms.Button();
            this.lblCancelContinueAddItemToSeller = new System.Windows.Forms.Label();
            this.btnAddItemForSeller = new System.Windows.Forms.Button();
            this.grpItemDetailsForSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpItemDetailsForSeller
            // 
            this.grpItemDetailsForSeller.Controls.Add(this.rdiobtnClothingCategory);
            this.grpItemDetailsForSeller.Controls.Add(this.rdiobtnOfficeCategory);
            this.grpItemDetailsForSeller.Controls.Add(this.rdiobtnElectricCategory);
            this.grpItemDetailsForSeller.Controls.Add(this.rdiobtnKidsCategory);
            this.grpItemDetailsForSeller.Controls.Add(this.txtProductPriceForSeller);
            this.grpItemDetailsForSeller.Controls.Add(this.lblItemPriceForSeller);
            this.grpItemDetailsForSeller.Controls.Add(this.lblItemCategoryForSeller);
            this.grpItemDetailsForSeller.Controls.Add(this.txtItemNameForSeller);
            this.grpItemDetailsForSeller.Controls.Add(this.lblProductNameForSeller);
            this.grpItemDetailsForSeller.Location = new System.Drawing.Point(225, 29);
            this.grpItemDetailsForSeller.Name = "grpItemDetailsForSeller";
            this.grpItemDetailsForSeller.Size = new System.Drawing.Size(349, 203);
            this.grpItemDetailsForSeller.TabIndex = 0;
            this.grpItemDetailsForSeller.TabStop = false;
            this.grpItemDetailsForSeller.Text = "Enter the item details:";
            this.grpItemDetailsForSeller.Enter += new System.EventHandler(this.grpItemDetailsForSeller_Enter);
            // 
            // rdiobtnClothingCategory
            // 
            this.rdiobtnClothingCategory.AutoSize = true;
            this.rdiobtnClothingCategory.Location = new System.Drawing.Point(226, 137);
            this.rdiobtnClothingCategory.Name = "rdiobtnClothingCategory";
            this.rdiobtnClothingCategory.Size = new System.Drawing.Size(63, 17);
            this.rdiobtnClothingCategory.TabIndex = 9;
            this.rdiobtnClothingCategory.TabStop = true;
            this.rdiobtnClothingCategory.Text = "Clothing";
            this.rdiobtnClothingCategory.UseVisualStyleBackColor = true;
            // 
            // rdiobtnOfficeCategory
            // 
            this.rdiobtnOfficeCategory.AutoSize = true;
            this.rdiobtnOfficeCategory.Location = new System.Drawing.Point(226, 114);
            this.rdiobtnOfficeCategory.Name = "rdiobtnOfficeCategory";
            this.rdiobtnOfficeCategory.Size = new System.Drawing.Size(53, 17);
            this.rdiobtnOfficeCategory.TabIndex = 8;
            this.rdiobtnOfficeCategory.TabStop = true;
            this.rdiobtnOfficeCategory.Text = "Office";
            this.rdiobtnOfficeCategory.UseVisualStyleBackColor = true;
            this.rdiobtnOfficeCategory.CheckedChanged += new System.EventHandler(this.rdiobtnCategoryOffice_CheckedChanged);
            // 
            // rdiobtnElectricCategory
            // 
            this.rdiobtnElectricCategory.AutoSize = true;
            this.rdiobtnElectricCategory.Location = new System.Drawing.Point(226, 91);
            this.rdiobtnElectricCategory.Name = "rdiobtnElectricCategory";
            this.rdiobtnElectricCategory.Size = new System.Drawing.Size(60, 17);
            this.rdiobtnElectricCategory.TabIndex = 7;
            this.rdiobtnElectricCategory.TabStop = true;
            this.rdiobtnElectricCategory.Text = "Electric";
            this.rdiobtnElectricCategory.UseVisualStyleBackColor = true;
            // 
            // rdiobtnKidsCategory
            // 
            this.rdiobtnKidsCategory.AutoSize = true;
            this.rdiobtnKidsCategory.Location = new System.Drawing.Point(226, 68);
            this.rdiobtnKidsCategory.Name = "rdiobtnKidsCategory";
            this.rdiobtnKidsCategory.Size = new System.Drawing.Size(45, 17);
            this.rdiobtnKidsCategory.TabIndex = 6;
            this.rdiobtnKidsCategory.TabStop = true;
            this.rdiobtnKidsCategory.Text = "Kids";
            this.rdiobtnKidsCategory.UseVisualStyleBackColor = true;
            this.rdiobtnKidsCategory.CheckedChanged += new System.EventHandler(this.rdiobtnKidsCategory_CheckedChanged);
            // 
            // txtProductPriceForSeller
            // 
            this.txtProductPriceForSeller.Location = new System.Drawing.Point(32, 142);
            this.txtProductPriceForSeller.Name = "txtProductPriceForSeller";
            this.txtProductPriceForSeller.Size = new System.Drawing.Size(100, 20);
            this.txtProductPriceForSeller.TabIndex = 5;
            // 
            // lblItemPriceForSeller
            // 
            this.lblItemPriceForSeller.AutoSize = true;
            this.lblItemPriceForSeller.Location = new System.Drawing.Point(43, 126);
            this.lblItemPriceForSeller.Name = "lblItemPriceForSeller";
            this.lblItemPriceForSeller.Size = new System.Drawing.Size(82, 13);
            this.lblItemPriceForSeller.TabIndex = 4;
            this.lblItemPriceForSeller.Text = "Item price (in ₪)";
            this.lblItemPriceForSeller.Click += new System.EventHandler(this.lblProductPriceForSeller_Click);
            // 
            // lblItemCategoryForSeller
            // 
            this.lblItemCategoryForSeller.AutoSize = true;
            this.lblItemCategoryForSeller.Location = new System.Drawing.Point(168, 105);
            this.lblItemCategoryForSeller.Name = "lblItemCategoryForSeller";
            this.lblItemCategoryForSeller.Size = new System.Drawing.Size(52, 13);
            this.lblItemCategoryForSeller.TabIndex = 2;
            this.lblItemCategoryForSeller.Text = "Category:";
            this.lblItemCategoryForSeller.Click += new System.EventHandler(this.lblItemCategoryForSeller_Click);
            // 
            // txtItemNameForSeller
            // 
            this.txtItemNameForSeller.Location = new System.Drawing.Point(32, 67);
            this.txtItemNameForSeller.Name = "txtItemNameForSeller";
            this.txtItemNameForSeller.Size = new System.Drawing.Size(100, 20);
            this.txtItemNameForSeller.TabIndex = 1;
            this.txtItemNameForSeller.TextChanged += new System.EventHandler(this.txtItemNameForSeller_TextChanged);
            // 
            // lblProductNameForSeller
            // 
            this.lblProductNameForSeller.AutoSize = true;
            this.lblProductNameForSeller.Location = new System.Drawing.Point(49, 51);
            this.lblProductNameForSeller.Name = "lblProductNameForSeller";
            this.lblProductNameForSeller.Size = new System.Drawing.Size(59, 13);
            this.lblProductNameForSeller.TabIndex = 0;
            this.lblProductNameForSeller.Text = "Item name:";
            this.lblProductNameForSeller.Click += new System.EventHandler(this.lblProductNameForSeller_Click);
            // 
            // btnCancelContinueAddItemToSeller
            // 
            this.btnCancelContinueAddItemToSeller.Location = new System.Drawing.Point(244, 256);
            this.btnCancelContinueAddItemToSeller.Name = "btnCancelContinueAddItemToSeller";
            this.btnCancelContinueAddItemToSeller.Size = new System.Drawing.Size(89, 44);
            this.btnCancelContinueAddItemToSeller.TabIndex = 1;
            this.btnCancelContinueAddItemToSeller.Text = "Cancel";
            this.btnCancelContinueAddItemToSeller.UseVisualStyleBackColor = true;
            this.btnCancelContinueAddItemToSeller.Click += new System.EventHandler(this.btnCancelContinueAddItemToSeller_Click);
            // 
            // lblCancelContinueAddItemToSeller
            // 
            this.lblCancelContinueAddItemToSeller.AutoSize = true;
            this.lblCancelContinueAddItemToSeller.Location = new System.Drawing.Point(349, 269);
            this.lblCancelContinueAddItemToSeller.Name = "lblCancelContinueAddItemToSeller";
            this.lblCancelContinueAddItemToSeller.Size = new System.Drawing.Size(96, 13);
            this.lblCancelContinueAddItemToSeller.TabIndex = 2;
            this.lblCancelContinueAddItemToSeller.Text = "(Cancel - Go back)";
            this.lblCancelContinueAddItemToSeller.Click += new System.EventHandler(this.lblCancelContinueAddItemToSeller_Click);
            // 
            // btnAddItemForSeller
            // 
            this.btnAddItemForSeller.Location = new System.Drawing.Point(470, 255);
            this.btnAddItemForSeller.Name = "btnAddItemForSeller";
            this.btnAddItemForSeller.Size = new System.Drawing.Size(75, 41);
            this.btnAddItemForSeller.TabIndex = 3;
            this.btnAddItemForSeller.Text = "Add item";
            this.btnAddItemForSeller.UseVisualStyleBackColor = true;
            this.btnAddItemForSeller.Click += new System.EventHandler(this.btnAddItemForSeller_Click);
            // 
            // Continue_Add_Item_Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.btnAddItemForSeller);
            this.Controls.Add(this.lblCancelContinueAddItemToSeller);
            this.Controls.Add(this.btnCancelContinueAddItemToSeller);
            this.Controls.Add(this.grpItemDetailsForSeller);
            this.Name = "Continue_Add_Item_Seller";
            this.Text = "Adding item to seller";
            this.grpItemDetailsForSeller.ResumeLayout(false);
            this.grpItemDetailsForSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpItemDetailsForSeller;
        private System.Windows.Forms.Button btnCancelContinueAddItemToSeller;
        private System.Windows.Forms.TextBox txtItemNameForSeller;
        private System.Windows.Forms.Label lblProductNameForSeller;
        private System.Windows.Forms.Label lblCancelContinueAddItemToSeller;
        private System.Windows.Forms.Label lblItemPriceForSeller;
        private System.Windows.Forms.Label lblItemCategoryForSeller;
        private System.Windows.Forms.TextBox txtProductPriceForSeller;
        private System.Windows.Forms.Button btnAddItemForSeller;
        private System.Windows.Forms.RadioButton rdiobtnClothingCategory;
        private System.Windows.Forms.RadioButton rdiobtnOfficeCategory;
        private System.Windows.Forms.RadioButton rdiobtnElectricCategory;
        private System.Windows.Forms.RadioButton rdiobtnKidsCategory;
    }
}