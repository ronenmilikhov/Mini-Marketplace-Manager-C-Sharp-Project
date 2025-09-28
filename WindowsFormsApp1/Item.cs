using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Item
    {
        private static int counter;
        private int id;
        private string item_name;
        private float price;
        public enum eCategory { Kids, Electric, Office, Clothing, Undefined };
        private eCategory category;
        private bool SetPrice(float price)
        {
            if (price > 0)
            {
                this.price = price;
                return true;
            }
            price = 0;
            return false;
        }
        public Item(string item_name, float price)
        {
            bool res = SetPrice(price);
            if (res == false)
            {
                return;
            }
            counter++;
            id = counter;
            this.item_name = item_name;
            category = eCategory.Undefined;
        }
        public Item(string item_name, float price, string category)
        {
            bool res = SetPrice(price);
            if (res == false)
            {
                return;
            }
            counter++;
            id = counter;
            this.item_name = item_name;
            setCategory(category);
        }
        public void setCategory(string category)
        {
            if (Enum.IsDefined(typeof(eCategory), category))
                this.category = (eCategory)Enum.Parse(typeof(eCategory), category);
            else
                this.category = eCategory.Undefined;
        }
        public Item()
        {
            this.price = 0;
            this.item_name = "";
            counter++;
            id = counter;
            this.category = eCategory.Undefined;
        }
        public string Getitemname()
        {
            return item_name;
        }
        public void setPrice(float price)
        {
            this.price = price;
        }
        public float Getprice()
        {
            return price;
        }
        public eCategory Getcategory()
        {
            return category;
        }
        public int Getid()
        {
            return id;
        }


        public void printItem()
        {
            Console.WriteLine("ID: " + id + "\nName: " + item_name + "\nCategory: " + category + "\nPrice: " + price);
        }
    }
}