using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private int inventory;
        private decimal price;
        private int max;
        private int min;

        public int PartID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = decimal.Parse(value.Substring(1));
                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }
        public int Max { get; set; }
        public int Min { get; set; }
    }
}
