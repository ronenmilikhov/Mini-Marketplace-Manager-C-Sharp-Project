using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_Buyer : Form
    {
        private List<Buyer> buyers;
        public Add_Buyer(List<Buyer> buyers)
        {
            InitializeComponent();
            this.buyers = buyers;
        }

        private void txtSellerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSellerPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStateName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuildingNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpInputBuyerDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblBuyerName_Click(object sender, EventArgs e)
        {

        }

        private void lblBuyerPassword_Click(object sender, EventArgs e)
        {

        }

        private void grpBuyerAddressDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblBuyerCityName_Click(object sender, EventArgs e)
        {

        }

        private void lblBuyerStreetName_Click(object sender, EventArgs e)
        {

        }

        private void txtBuyerCityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuyerStreetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBuyerBuildingNum_Click(object sender, EventArgs e)
        {

        }

        private void lblBuyerStateName_Click(object sender, EventArgs e)
        {

        }

        private void btnAcceptNewBuyer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuyerName.Text) ||
                    string.IsNullOrWhiteSpace(txtBuyerPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtBuyerCityName.Text) ||
                    string.IsNullOrWhiteSpace(txtBuyerStreetName.Text) ||
                    string.IsNullOrWhiteSpace(txtBuyerBuildingNum.Text) ||
                    string.IsNullOrWhiteSpace(txtBuyerStateName.Text))
                {
                    throw new Exception("All fields must be filled out.");
                }

                string buyerName = txtBuyerName.Text.Trim();
                if (!Regex.IsMatch(buyerName, @"^[a-zA-Z\s]+$"))
                {
                    throw new Exception("Buyer name must contain only alphabetical characters.");
                }

                if (!int.TryParse(txtBuyerPassword.Text.Trim(), out int password))
                {
                    throw new Exception("Password must contain only integers.");
                }

                string cityName = txtBuyerCityName.Text.Trim();
                if (!Regex.IsMatch(cityName, @"^[a-zA-Z\s]+$"))
                {
                    throw new Exception("City name must contain only alphabetical characters.");
                }

                string streetName = txtBuyerStreetName.Text.Trim();
                if (!Regex.IsMatch(streetName, @"^[a-zA-Z\s]+$"))
                {
                    throw new Exception("Street name must contain only alphabetical characters.");
                }

                if (!int.TryParse(txtBuyerBuildingNum.Text.Trim(), out int buildingNum))
                {
                    throw new Exception("Building number must contain only integers.");
                }

                string stateName = txtBuyerStateName.Text.Trim();
                if (!Regex.IsMatch(stateName, @"^[a-zA-Z\s]+$"))
                {
                    throw new Exception("State name must contain only alphabetical characters.");
                }

                Address address = new Address(streetName, buildingNum, cityName, stateName);

                if (buyers.Any(b => b.Getusername().Equals(buyerName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("A buyer with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Buyer newBuyer = new Buyer(buyerName, password, address);
                buyers.Add(newBuyer);

                MessageBox.Show("Buyer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelBuyer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCancelBuyer_Click(object sender, EventArgs e)
        {

        }
    }
}
