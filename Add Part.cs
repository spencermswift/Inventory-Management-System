using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Add_Part : Form
    {
        
        public Add_Part()
        {
            InitializeComponent();
        }
        private void SavePartButton_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = int.Parse(partMinTextBox.Text);
                maxStock = int.Parse(partMaxTextBox.Text);
                invInStock = int.Parse(partInventoryTextBox.Text);
                price = decimal.Parse(partCostTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }



            string name = partNameTextBox.Text;
            price = decimal.Parse(partCostTextBox.Text);
            minStock = int.Parse(partMinTextBox.Text);
            maxStock = int.Parse(partMaxTextBox.Text);
            invInStock = int.Parse(partInventoryTextBox.Text);

            
            //exception handling
            if (minStock > maxStock)
            {
                MessageBox.Show("Error: Max must be greater than min");
                return;
            }

            if (invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }
            

            if (inhouseRadioButton.Checked)
            {
                InHousePart inPart = new InHousePart((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, int.Parse(partMacComTextBox.Text));
                Inventory.AddPart(inPart);
                
            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, partMacComTextBox.Text) ;
                Inventory.AddPart(outPart);
                
            }
            Close();
            
        }
        private void InhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
        }
        private void CancelPartCreationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
