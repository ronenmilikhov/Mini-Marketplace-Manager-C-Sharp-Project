using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private List<Seller> sellers = new List<Seller>();
        private List<Buyer> buyers = new List<Buyer>();
        private bool isSavingAndExiting = false;
        public MainForm()
        {
            InitializeComponent();
            LoadSellersFromFile();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            Add_Seller addSellerForm = new Add_Seller(sellers);
            if (addSellerForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Seller added successfully.");
            }
        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            Add_Buyer addBuyerForm = new Add_Buyer(buyers);
            addBuyerForm.ShowDialog();
        }

        private void btnAddItemToSeller_Click(object sender, EventArgs e)
        {
            if (sellers == null || !sellers.Any())
            {
                MessageBox.Show("No sellers available. Please add a seller first.", "No Sellers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Add_Item_Seller addItemForm = new Add_Item_Seller(sellers);
            addItemForm.ShowDialog();
        }

        private void btnAddItemToBuyer_Click(object sender, EventArgs e)
        {
            if (!buyers.Any())
            {
                MessageBox.Show("No buyers available. Please add a buyer first.", "No Buyers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!sellers.Any(s => s.GetitemsForSale().Any()))
            {
                MessageBox.Show("No sellers with items available for sale. Please add sellers and items first.", "No Items Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Add_Item_Buyer addItemToBuyerForm = new Add_Item_Buyer(buyers, sellers);
            if (addItemToBuyerForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Item added to buyer successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblMenuOptions_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAllSellers_Click(object sender, EventArgs e)
        {
            if (sellers == null || !sellers.Any())
            {
                MessageBox.Show("No sellers available.", "No Sellers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Display_Sellers_Info displayForm = new Display_Sellers_Info(sellers);
            displayForm.ShowDialog();
        }

        private void btnShowAllBuyers_Click(object sender, EventArgs e)
        {
            if (buyers == null || !buyers.Any())
            {
                MessageBox.Show("No buyers available.", "No Buyers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Display_Buyers_Info displayForm = new Display_Buyers_Info(buyers);
            displayForm.ShowDialog();
        }

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to save and exit?", "Save and Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                isSavingAndExiting = true;
                SaveSellersToFile();
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSavingAndExiting)
            {
                var result = MessageBox.Show("Are you sure you want to exit? You will exit the program without saving.", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void SaveSellersToFile()
        {
            string filePath = "sellers_data.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var seller in sellers)
                {
                    writer.WriteLine($"Name: {seller.Getusername()}, Password: {seller.Getpassword()}, Address: {seller.Getaddress().GetStreetName()}, {seller.Getaddress().GetbuildingNum()}, {seller.Getaddress().Getcity()}, {seller.Getaddress().Getstate()} \nTotal Items Sold: {seller.GetitemsSold().Length}");

                    var itemsForSale = seller.GetitemsForSale();
                    if (itemsForSale.Any())
                    {
                        writer.WriteLine("Items seller is currently selling:");
                        foreach (var item in itemsForSale)
                        {
                            writer.WriteLine($"ID: {item.Getid()}, Item Name: {item.Getitemname()}, Price: {item.Getprice()}, Category: {item.Getcategory()}.");
                        }
                    }
                    else
                    {
                        writer.WriteLine("No items available.");
                    }
                    writer.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
        }

        private void LoadSellersFromFile()
        {
            string filePath = "sellers_data.txt";
            if (File.Exists(filePath))
            {
                sellers = new List<Seller>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    Seller currentSeller = null;

                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            if (line.StartsWith("Name:"))
                            {
                                string[] parts = line.Split(new[] { ',', ':' }, StringSplitOptions.RemoveEmptyEntries);

                                if (parts.Length >= 9)
                                {
                                    string name = parts[1].Trim();
                                    int password = int.Parse(parts[3].Trim());
                                    string street = parts[5].Trim();
                                    int buildingNum = int.Parse(parts[6].Trim());
                                    string city = parts[7].Trim();
                                    string state = parts[8].Trim();
                                    Address address = new Address(street, buildingNum, city, state);
                                    currentSeller = new Seller(name, password, address);
                                    sellers.Add(currentSeller);
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect format detected in seller information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else if (line.StartsWith("ID:"))
                            {
                                string[] parts = line.Split(new[] { ',', ':' }, StringSplitOptions.RemoveEmptyEntries);

                                if (parts.Length >= 8)
                                {
                                    int id = int.Parse(parts[1].Trim());
                                    string itemName = parts[3].Trim();
                                    float price = float.Parse(parts[5].Trim());
                                    string category = parts[7].Trim().TrimEnd('.');
                                    Item.eCategory itemCategory;

                                    if (Enum.TryParse(category, out itemCategory))
                                    {
                                        Item item = new Item(itemName, price, itemCategory.ToString());
                                        currentSeller?.AddItemForSale(item);
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Unknown category '{category}' found in item information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect format detected in item information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show($"Error parsing data: {ex.Message}\nLine: {line}", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }
    }
}
