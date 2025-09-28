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
    public partial class Display_Sellers_Info : Form
    {
        private List<Seller> sellers;

        public Display_Sellers_Info(List<Seller> sellers)
        {
            InitializeComponent();
            this.sellers = sellers;
            DisplaySellerInformation();
        }

        public Display_Sellers_Info()
        {
            InitializeComponent();
        }

        private void DisplaySellerInformation()
        {
            rtbAllSellersInfo.Clear();

            foreach (var seller in sellers)
            {
                StringBuilder sellerInfo = new StringBuilder();

                int itemsSoldCount = seller.GetitemsSold().Length;
                sellerInfo.AppendLine($"Name: {seller.Getusername()}, Password: {seller.Getpassword()}, Address: {seller.Getaddress().GetStreetName()} {seller.Getaddress().GetbuildingNum()}, {seller.Getaddress().Getcity()}, {seller.Getaddress().Getstate()} \nTotal items sold: {itemsSoldCount}");

                sellerInfo.AppendLine();
                sellerInfo.AppendLine("Items seller is currently selling:");

                var itemsForSale = seller.GetitemsForSale();
                if (itemsForSale.Any())
                {
                    foreach (var item in itemsForSale)
                    {
                        sellerInfo.AppendLine($"ID: {item.Getid()}, Item Name: {item.Getitemname()}, Price: {item.Getprice()} ₪, Category: {item.Getcategory()}.");
                    }
                }
                else
                {
                    sellerInfo.AppendLine("No items available.");
                }

                sellerInfo.AppendLine("-----------------------------------------------------------------------------------");

                rtbAllSellersInfo.AppendText(sellerInfo.ToString() + Environment.NewLine);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
