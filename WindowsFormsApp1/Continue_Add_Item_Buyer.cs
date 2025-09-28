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
    public partial class Continue_Add_Item_Buyer : Form
    {
        private string selectedBuyer;
        private List<Buyer> buyers;
        private List<Seller> sellers;
        public Continue_Add_Item_Buyer(string selectedBuyer, List<Buyer> buyers, List<Seller> sellers)
        {
            InitializeComponent();
            this.selectedBuyer = selectedBuyer;
            this.buyers = buyers;
            this.sellers = sellers;
            lblDisplayCategory.Visible = false;
            lblDisplayItemPrice.Visible = false;
            comboboxSellersList.Items.AddRange(sellers.Select(s => s.Getusername()).ToArray());
        }

        private void comboboxSellersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxSellersList.SelectedItem != null)
            {
                string selectedSeller = comboboxSellersList.SelectedItem.ToString();
                Seller seller = sellers.First(s => s.Getusername() == selectedSeller);

                comboboxItemsList.Items.Clear();
                comboboxItemsList.Items.AddRange(seller.GetitemsForSale().Select(i => i.Getitemname()).ToArray());

                comboboxItemsList.Visible = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxItemsList.SelectedItem != null)
            {
                string selectedSeller = comboboxSellersList.SelectedItem.ToString();
                Seller seller = sellers.First(s => s.Getusername() == selectedSeller);

                string selectedItemName = comboboxItemsList.SelectedItem.ToString();
                Item selectedItem = seller.GetitemsForSale().First(i => i.Getitemname() == selectedItemName);

                lblDisplayItemPrice.Visible = true;
                lblDisplayCategory.Visible = true;
                lblDisplayItemPrice.Text = $"{selectedItem.Getprice()} ₪";
                lblDisplayCategory.Text = $"{selectedItem.Getcategory()}";
            }
        }

        private void lblChooseSeller_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayItemPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPriceOfItem_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPurchaseItem_Click(object sender, EventArgs e)
        {
            if (comboboxItemsList.SelectedItem == null || comboboxSellersList.SelectedItem == null)
            {
                MessageBox.Show("Please select a seller and an item.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedBuyerName = selectedBuyer;
            Buyer buyer = buyers.First(b => b.Getusername() == selectedBuyerName);

            string selectedSellerName = comboboxSellersList.SelectedItem.ToString();
            Seller seller = sellers.First(s => s.Getusername() == selectedSellerName);

            string selectedItemName = comboboxItemsList.SelectedItem.ToString();
            Item selectedItem = seller.GetitemsForSale().First(i => i.Getitemname() == selectedItemName);

            buyer.addItem(selectedItem);

            seller.AddItemSold(selectedItem);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelItemPurchase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCancelItemPurchase_Click(object sender, EventArgs e)
        {

        }

        private void Continue_Add_Item_Buyer_Load(object sender, EventArgs e)
        {

        }
    }
}
