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
    public partial class Add_Item_Seller : Form
    {
        private List<Seller> sellers;
        public Seller SelectedSeller { get; private set; }

        public Add_Item_Seller(List<Seller> sellers)
        {
            InitializeComponent();
            this.sellers = sellers;
            PopulateSellersComboBox();
        }

        private void PopulateSellersComboBox()
        {
            foreach (var seller in sellers)
            {
                cmbboxChooseFromListOfSellers.Items.Add(seller.Getusername());
            }
        }

        private void txtSellerNameForProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceptProductForSeller_Click(object sender, EventArgs e)
        {
            if (cmbboxChooseFromListOfSellers.SelectedItem == null)
            {
                MessageBox.Show("Please select a seller from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSellerName = cmbboxChooseFromListOfSellers.SelectedItem.ToString();
            SelectedSeller = sellers.FirstOrDefault(s => s.Getusername().Equals(selectedSellerName, StringComparison.OrdinalIgnoreCase));

            if (SelectedSeller == null)
            {
                MessageBox.Show("Seller not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Continue_Add_Item_Seller continueForm = new Continue_Add_Item_Seller(SelectedSeller);
            if (continueForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation was canceled or failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }

        private void grpSellerInfo_Enter(object sender, EventArgs e)
        {

        }

        private void lblSellerNameForItem_Click(object sender, EventArgs e)
        {

        }

        private void lblCancelAddItemToSeller_Click(object sender, EventArgs e)
        {

        }

        private void lstboxSellersNamesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbboxChooseFromListOfSellers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
