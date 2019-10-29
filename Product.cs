using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Inventory_Management_System
{
    public class Product
    {

        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int prodID;
        private string name;
        private int inventory;
        private decimal price;
        private int max;
        private int min;

        public int ProductID { get; set; }
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

        public Product() { }
        public Product(int prodID, string name, int inventory, decimal price, int max, int min)
        {
            ProductID = prodID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
       
        //manipulate parts attached to products
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partID)
        {
            bool success = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return success = true;
                }
                else
                {
                    success = false;
                } 
            }
            return success; 
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            InHousePart emptyInHousePart = new InHousePart();
            return emptyInHousePart;
        }
    }
}
