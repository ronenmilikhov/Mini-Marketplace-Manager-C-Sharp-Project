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
    public partial class Add_Item_Buyer : Form
    {
        private List<Buyer> buyers;
        private List<Seller> sellers;
        public Add_Item_Buyer(List<Buyer> buyers, List<Seller> sellers)
        {
            InitializeComponent();
            this.buyers = buyers;
            this.sellers = sellers;
            cmbboxChooseFromListOfBuyers.Items.AddRange(buyers.Select(b => b.Getusername()).ToArray());
        }

        private void btnCancelAddItemToBuyer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCancelAddItemToBuyer_Click(object sender, EventArgs e)
        {

        }

        private void cmbboxChooseFromListOfBuyers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnContinueAddItemForBuyer_Click(object sender, EventArgs e)
        {
            if (cmbboxChooseFromListOfBuyers.SelectedItem == null)
            {
                MessageBox.Show("Please select a buyer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!sellers.Any(s => s.GetitemsForSale().Any()))
            {
                MessageBox.Show("No sellers with items available for sale.", "No Items Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedBuyer = cmbboxChooseFromListOfBuyers.SelectedItem.ToString();
            Continue_Add_Item_Buyer continueForm = new Continue_Add_Item_Buyer(selectedBuyer, buyers, sellers);
            if (continueForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Item added to buyer successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation was canceled or failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }
    }
}
