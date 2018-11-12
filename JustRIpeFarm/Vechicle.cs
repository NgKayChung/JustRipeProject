using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRIpeFarm
{
    public class Vehicle
    {
        public Vehicle()
        {
            string model = "";
            string name = "";
            string category = "";
            string capacity = "";
            string Type = "";
            string Status = "";

        }

        public Vehicle(string m, string n, string t, string c, string cap, string s)
        {
            model = m;
            name = n;
            Type = t;
            category = c;
            capacity = cap;
            Status = s;
        }


        public String model
        { get; set; }
        public String name
        { get; set; }
        public String Type
        { get; set; }
        public String category
        { get; set; }
        public String capacity
        { get; set; }
        public String Status
        { get; set; }
    }
}