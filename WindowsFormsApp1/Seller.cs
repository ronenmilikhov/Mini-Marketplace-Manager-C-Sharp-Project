using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class Seller : User
    {

        private const float specialPackagePrice = 20;
        private List<Item> itemsForSale;
        private List<Item> itemsSold;
        public Seller(string username, int password, Address address) : base(username, password, address)
        {
            this.itemsForSale = new List<Item>();
            this.itemsSold = new List<Item>();
        }
        public Seller() : base() 
        {
            this.itemsForSale = new List<Item>();
            this.itemsSold = new List<Item>();
        }

        public float GetSpecialPackagePrice()
        {
            return specialPackagePrice;
        }

        public Item[] GetitemsForSale()
        {
            return itemsForSale.ToArray();
        }

        public Item[] GetitemsSold()
        {
            return itemsSold.ToArray();
        }

        public void AddItemForSale(Item item)
        {
            itemsForSale.Add(item);
        }

        public void AddItemSold(Item item)
        {
            itemsSold.Add(item);
            itemsForSale.Remove(item);
        }
    }
}
