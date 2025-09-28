using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Address
    {
        string street_name;
        int buildingNum;
        string city;
        string state;
        private bool SetbuildingNum(int buildingNum)
        {
            if (buildingNum < 0)
            {
                buildingNum = 0;
                return false;
            }
            this.buildingNum = buildingNum;
            return true;
        }
        public string GetStreetName()
        {
            return street_name;
        }
        public int GetbuildingNum()
        {
            return buildingNum;
        }
        public string Getcity()
        {
            return city;
        }
        public string Getstate()
        {
            return state;
        }
        public Address(string street_name, int buildingNum, string city, string state)
        {
            bool res = SetbuildingNum(buildingNum);
            if (res == false)
            {
                return;
            }
            this.street_name = street_name;
            this.city = city;
            this.state = state;
        }
        public Address()
        {
            this.street_name = "";
            this.buildingNum = 0;
            this.state = "";
            this.city = "";
        }
    }
}
