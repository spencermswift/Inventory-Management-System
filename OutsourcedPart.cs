using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class OutsourcedPart : Part
    {
        private string compName;
        public string CompName { get; set; }
        public OutsourcedPart() { }
        public OutsourcedPart(int partID, string name, int inventory, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public OutsourcedPart(int partID, string name, int inventory, decimal price, int max, int min, string compName)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            CompName = compName;
        }
    }
}
