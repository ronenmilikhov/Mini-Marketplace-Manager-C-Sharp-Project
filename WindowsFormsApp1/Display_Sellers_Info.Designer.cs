namespace WindowsFormsApp1
{
    partial class Display_Sellers_Info
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
            this.lblAllSellersInfo = new System.Windows.Forms.Label();
            this.rtbAllSellersInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblAllSellersInfo
            // 
            this.lblAllSellersInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAllSellersInfo.Location = new System.Drawing.Point(176, 51);
            this.lblAllSellersInfo.Name = "lblAllSellersInfo";
            this.lblAllSellersInfo.Size = new System.Drawing.Size(439, 27);
            this.lblAllSellersInfo.TabIndex = 0;
            this.lblAllSellersInfo.Text = "All the sellers and the information about them:";
            // 
            // rtbAllSellersInfo
            // 
            this.rtbAllSellersInfo.Location = new System.Drawing.Point(12, 81);
            this.rtbAllSellersInfo.Name = "rtbAllSellersInfo";
            this.rtbAllSellersInfo.ReadOnly = true;
            this.rtbAllSellersInfo.Size = new System.Drawing.Size(786, 367);
            this.rtbAllSellersInfo.TabIndex = 1;
            this.rtbAllSellersInfo.Text = "";
            this.rtbAllSellersInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Display_Sellers_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(808, 460);
            this.Controls.Add(this.rtbAllSellersInfo);
            this.Controls.Add(this.lblAllSellersInfo);
            this.Name = "Display_Sellers_Info";
            this.Text = "Sellers information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAllSellersInfo;
        private System.Windows.Forms.RichTextBox rtbAllSellersInfo;
    }
}