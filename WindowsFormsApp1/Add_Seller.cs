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
    public partial class Add_Seller : Form
    {
        private List<Seller> sellers;

        public Add_Seller(List<Seller> sellers)
        {
            InitializeComponent();
            this.sellers = sellers;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSellerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStateName_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpInputSellerDetails_Enter(object sender, EventArgs e)
        {

        }

        private void Add_Seller_Load(object sender, EventArgs e)
        {

        }

        private void txtSellerPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSellerPassword_Click(object sender, EventArgs e)
        {

        }

        private void grpSellerAddressDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblSellerCityName_Click(object sender, EventArgs e)
        {

        }

        private void lblSellerStreetName_Click(object sender, EventArgs e)
        {

        }

        private void txtSellerStreetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSellerBuildingNum_Click(object sender, EventArgs e)
        {

        }

        private void lblSellerStateName_Click(object sender, EventArgs e)
        {

        }

        private void txtSellerBuildingNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceptNewSeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSellerName.Text) ||
                    string.IsNullOrWhiteSpace(txtSellerPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtSellerStreetName.Text) ||
                    string.IsNullOrWhiteSpace(txtSellerBuildingNum.Text) ||
                    string.IsNullOrWhiteSpace(txtSellerCityName.Text) ||
                    string.IsNullOrWhiteSpace(txtSellerStateName.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sellerName = txtSellerName.Text.Trim();
                if (!Regex.IsMatch(sellerName, @"^[a-zA-Z]+$"))
                {
                    throw new Exception("Seller name must contain only alphabetical characters.");
                }

                string passwordInput = txtSellerPassword.Text.Trim();
                if (!int.TryParse(passwordInput, out int password))
                {
                    throw new Exception("Seller password must contain only numbers.");
                }

                string cityName = txtSellerCityName.Text.Trim();
                if (!Regex.IsMatch(cityName, @"^[a-zA-Z\s]+$"))
                {
                    throw new Exception("City name must contain only alphabetical characters and spaces.");
                }

                string streetName = txtSellerStreetName.Text.Trim();
                if (!Regex.IsMatch(streetName, @"^[a-zA-Z\s]+$"))
                {
                    throw new Exception("Street name must contain only alphabetical characters and spaces.");
                }

                string buildingNumInput = txtSellerBuildingNum.Text.Trim();
                if (!int.TryParse(buildingNumInput, out int buildingNum))
                {
                    throw new Exception("Building number must contain only numbers.");
                }

                string stateName = txtSellerStateName.Text.Trim();
                if (!Regex.IsMatch(stateName, @"^[a-zA-Z]+$"))
                {
                    throw new Exception("State name must contain only alphabetical characters.");
                }

                Address address = new Address(streetName, buildingNum, cityName, stateName);

                if (sellers.Any(s => s.Getusername().Equals(sellerName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("A seller with this name already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Seller newSeller = new Seller(sellerName, password, address);
                sellers.Add(newSeller);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelSeller_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCancelSeller_Click(object sender, EventArgs e)
        {

        }
    }
}
