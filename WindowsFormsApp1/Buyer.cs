using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class Buyer : User
    {
        private Item[] itemsBought;
        public Buyer(string username, int password, Address address) : base(username, password, address) { }
        public Buyer() : base() { }

        public bool addItem(Item item)
        {
            if (item.Getprice() == 0)
            {
                return false;
            }

            if (items.Length == 0)
            {
                items = new Item[1];
                items[0] = item;
                return true;
            }

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Getitemname() == null)
                {
                    items[i] = item; return true;
                }
            }
            int ogLen = items.Length;
            Item[] temp = new Item[ogLen * 2];
            for (int i = 0; i < ogLen; i++)
            {
                temp[i] = items[i];
            }
            temp[ogLen] = item;
            items = temp;
            return true;
        }

        public float getCheck()
        {
            float check = 0;
            foreach (Item item in this.items)
            {
                if (item.Getitemname() == null)
                    break;
                check += item.Getprice();
            }
            return check;
        }

        public void Checkout()
        {
            if (itemsBought == null)
            {
                itemsBought = new Item[items.Length];
                for (int i = 0; i < itemsBought.Length; i++)
                {
                    if (items[i] == null)
                        break;
                    itemsBought[i] = items[i];
                }
            }
            else
            {
                Item[] temp = new Item[items.Length + itemsBought.Length];
                int itemsCount = 0;
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] == null)
                        break;
                    temp[itemsCount++] = items[i];
                }
                for (int i = 0; i < itemsBought.Length; i++)
                {
                    if (itemsBought[i] == null)
                        break;
                    temp[itemsCount++] = itemsBought[i];
                }
                itemsBought = temp;
            }
            items = new Item[0];
        }

        public void printItemsBought()
        {
            if (itemsBought == null)
            {
                Console.WriteLine("No Items were bought");
                return;
            }

            foreach (Item item in this.itemsBought)
            {
                if (item.Getitemname() == null)
                    break;
                item.printItem();
                Console.WriteLine("~~~~~~~~~~");
            }
        }
    }
}
