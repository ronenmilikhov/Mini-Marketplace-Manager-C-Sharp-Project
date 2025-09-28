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
    public partial class Continue_Add_Item_Seller : Form
    {
        private Seller seller;
        public Continue_Add_Item_Seller(Seller seller)
        {
            InitializeComponent();
            this.seller = seller;
        }

        private void txtItemNameForSeller_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductNameForSeller_Click(object sender, EventArgs e)
        {

        }

        private void txtItemCategoryForSeller_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblItemCategoryForSeller_Click(object sender, EventArgs e)
        {

        }

        private void lblProductPriceForSeller_Click(object sender, EventArgs e)
        {

        }

        private void grpItemDetailsForSeller_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddItemForSeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtItemNameForSeller.Text))
                {
                    throw new Exception("Item name cannot be empty.");
                }

                if (!float.TryParse(txtProductPriceForSeller.Text.Trim(), out float price) || price <= 0)
                {
                    throw new Exception("Price must be a positive number.");
                }

                if (!rdiobtnKidsCategory.Checked && !rdiobtnElectricCategory.Checked && !rdiobtnOfficeCategory.Checked && !rdiobtnClothingCategory.Checked)
                {
                    throw new Exception("Please select a category for the item.");
                }

                Item.eCategory category = Item.eCategory.Undefined;
                if (rdiobtnKidsCategory.Checked) category = Item.eCategory.Kids;
                if (rdiobtnElectricCategory.Checked) category = Item.eCategory.Electric;
                if (rdiobtnOfficeCategory.Checked) category = Item.eCategory.Office;
                if (rdiobtnClothingCategory.Checked) category = Item.eCategory.Clothing;

                Item newItem = new Item(txtItemNameForSeller.Text.Trim(), price, category.ToString());

                seller.AddItemForSale(newItem);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelContinueAddItemToSeller_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCancelContinueAddItemToSeller_Click(object sender, EventArgs e)
        {

        }

        private void rdiobtnKidsCategory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdiobtnCategoryOffice_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
