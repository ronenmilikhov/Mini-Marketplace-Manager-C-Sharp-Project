using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Display_Buyers_Info : Form
    {
        private List<Buyer> buyers;
        public Display_Buyers_Info(List<Buyer> buyers)
        {
            InitializeComponent();
            this.buyers = buyers;
            DisplayBuyerInformation();
        }

        private void DisplayBuyerInformation()
        {
            richTextBox1.Clear();

            foreach (var buyer in buyers)
            {
                StringBuilder buyerInfo = new StringBuilder();

                buyerInfo.AppendLine($"Name: {buyer.Getusername()}, Password: {buyer.Getpassword()}, Address: {buyer.Getaddress().GetStreetName()} {buyer.Getaddress().GetbuildingNum()}, {buyer.Getaddress().Getcity()}, {buyer.Getaddress().Getstate()}");

                buyerInfo.AppendLine($"Total items owned: {buyer.Getitems().Length}");

                buyerInfo.AppendLine("List of items the buyer owns:");
                var itemsOwned = buyer.Getitems();
                if (itemsOwned.Any())
                {
                    foreach (var item in itemsOwned)
                    {
                        if (!string.IsNullOrEmpty(item.Getitemname()))
                        {
                            buyerInfo.AppendLine($"* {item.Getitemname()}");
                        }
                    }
                }
                else
                {
                    buyerInfo.AppendLine("No items owned.");
                }

                buyerInfo.AppendLine("-------------------------------------------------------------------------------------");

                richTextBox1.AppendText(buyerInfo.ToString() + Environment.NewLine);
            }
        }

        private void lblAllBuyersInfo_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
