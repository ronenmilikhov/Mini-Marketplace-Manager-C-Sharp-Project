using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public abstract class User
    {
        protected string username;
        protected int password;
        protected Address address;
        protected Item[] items;

        public User(string username, int password, Address address)
        {
            this.username = username;
            this.password = password;
            this.address = address;
            this.items = new Item[0];
        }

        public User()
        {
            this.username = "";
            this.password = 0;
            this.address = new Address();
            this.items = new Item[0];
        }
        public string Getusername()
        {
            return username;
        }
        public int Getpassword()
        {
            return password;
        }
        public Address Getaddress()
        {
            return address;
        }
        public Item[] Getitems()
        {
            return items;
        }
        public void Setitems(Item[] items)
        {
            this.items = items;
        }
    }


}
