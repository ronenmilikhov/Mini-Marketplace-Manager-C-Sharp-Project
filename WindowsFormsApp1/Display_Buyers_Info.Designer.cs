namespace WindowsFormsApp1
{
    partial class Display_Buyers_Info
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
            this.lblAllBuyersInfo = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblAllBuyersInfo
            // 
            this.lblAllBuyersInfo.AutoSize = true;
            this.lblAllBuyersInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAllBuyersInfo.Location = new System.Drawing.Point(173, 55);
            this.lblAllBuyersInfo.Name = "lblAllBuyersInfo";
            this.lblAllBuyersInfo.Size = new System.Drawing.Size(439, 24);
            this.lblAllBuyersInfo.TabIndex = 3;
            this.lblAllBuyersInfo.Text = "All the buyers and the information about them:";
            this.lblAllBuyersInfo.Click += new System.EventHandler(this.lblAllBuyersInfo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(782, 356);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Display_Buyers_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblAllBuyersInfo);
            this.Name = "Display_Buyers_Info";
            this.Text = "Buyers information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAllBuyersInfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}