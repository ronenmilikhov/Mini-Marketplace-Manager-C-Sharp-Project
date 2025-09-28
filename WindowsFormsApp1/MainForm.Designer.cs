namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.lblMenuOptions = new System.Windows.Forms.Label();
            this.btnAddSeller = new System.Windows.Forms.Button();
            this.btnAddBuyer = new System.Windows.Forms.Button();
            this.btnAddItemToSeller = new System.Windows.Forms.Button();
            this.btnAddItemToBuyer = new System.Windows.Forms.Button();
            this.btnShowAllSellers = new System.Windows.Forms.Button();
            this.btnShowAllBuyers = new System.Windows.Forms.Button();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuOptions
            // 
            this.lblMenuOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMenuOptions.Location = new System.Drawing.Point(204, 34);
            this.lblMenuOptions.Name = "lblMenuOptions";
            this.lblMenuOptions.Size = new System.Drawing.Size(396, 28);
            this.lblMenuOptions.TabIndex = 0;
            this.lblMenuOptions.Text = "Please choose one of the options below:";
            this.lblMenuOptions.Click += new System.EventHandler(this.lblMenuOptions_Click);
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.Location = new System.Drawing.Point(355, 79);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(102, 37);
            this.btnAddSeller.TabIndex = 1;
            this.btnAddSeller.Text = "Add Seller";
            this.btnAddSeller.UseVisualStyleBackColor = true;
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // btnAddBuyer
            // 
            this.btnAddBuyer.Location = new System.Drawing.Point(355, 122);
            this.btnAddBuyer.Name = "btnAddBuyer";
            this.btnAddBuyer.Size = new System.Drawing.Size(102, 38);
            this.btnAddBuyer.TabIndex = 2;
            this.btnAddBuyer.Text = "Add Buyer";
            this.btnAddBuyer.UseVisualStyleBackColor = true;
            this.btnAddBuyer.Click += new System.EventHandler(this.btnAddBuyer_Click);
            // 
            // btnAddItemToSeller
            // 
            this.btnAddItemToSeller.Location = new System.Drawing.Point(355, 166);
            this.btnAddItemToSeller.Name = "btnAddItemToSeller";
            this.btnAddItemToSeller.Size = new System.Drawing.Size(102, 35);
            this.btnAddItemToSeller.TabIndex = 3;
            this.btnAddItemToSeller.Text = "Add item to seller";
            this.btnAddItemToSeller.UseVisualStyleBackColor = true;
            this.btnAddItemToSeller.Click += new System.EventHandler(this.btnAddItemToSeller_Click);
            // 
            // btnAddItemToBuyer
            // 
            this.btnAddItemToBuyer.Location = new System.Drawing.Point(355, 207);
            this.btnAddItemToBuyer.Name = "btnAddItemToBuyer";
            this.btnAddItemToBuyer.Size = new System.Drawing.Size(102, 33);
            this.btnAddItemToBuyer.TabIndex = 4;
            this.btnAddItemToBuyer.Text = "Add item to buyer";
            this.btnAddItemToBuyer.UseVisualStyleBackColor = true;
            this.btnAddItemToBuyer.Click += new System.EventHandler(this.btnAddItemToBuyer_Click);
            // 
            // btnShowAllSellers
            // 
            this.btnShowAllSellers.Location = new System.Drawing.Point(339, 246);
            this.btnShowAllSellers.Name = "btnShowAllSellers";
            this.btnShowAllSellers.Size = new System.Drawing.Size(134, 29);
            this.btnShowAllSellers.TabIndex = 5;
            this.btnShowAllSellers.Text = "Show all sellers info";
            this.btnShowAllSellers.UseVisualStyleBackColor = true;
            this.btnShowAllSellers.Click += new System.EventHandler(this.btnShowAllSellers_Click);
            // 
            // btnShowAllBuyers
            // 
            this.btnShowAllBuyers.Location = new System.Drawing.Point(339, 281);
            this.btnShowAllBuyers.Name = "btnShowAllBuyers";
            this.btnShowAllBuyers.Size = new System.Drawing.Size(134, 27);
            this.btnShowAllBuyers.TabIndex = 6;
            this.btnShowAllBuyers.Text = "Show all buyers info";
            this.btnShowAllBuyers.UseVisualStyleBackColor = true;
            this.btnShowAllBuyers.Click += new System.EventHandler(this.btnShowAllBuyers_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(339, 314);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(134, 42);
            this.btnSaveAndExit.TabIndex = 7;
            this.btnSaveAndExit.Text = "Save and Exit";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.btnShowAllBuyers);
            this.Controls.Add(this.btnShowAllSellers);
            this.Controls.Add(this.btnAddItemToBuyer);
            this.Controls.Add(this.btnAddItemToSeller);
            this.Controls.Add(this.btnAddBuyer);
            this.Controls.Add(this.btnAddSeller);
            this.Controls.Add(this.lblMenuOptions);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenuOptions;
        private System.Windows.Forms.Button btnAddSeller;
        private System.Windows.Forms.Button btnAddBuyer;
        private System.Windows.Forms.Button btnAddItemToSeller;
        private System.Windows.Forms.Button btnAddItemToBuyer;
        private System.Windows.Forms.Button btnShowAllSellers;
        private System.Windows.Forms.Button btnShowAllBuyers;
        private System.Windows.Forms.Button btnSaveAndExit;
    }
}