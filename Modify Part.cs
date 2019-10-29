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
    public partial class Modify_Part : Form
    {
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];

        //load selected data based on if part is inhouse or outsourced.
        public Modify_Part(InHousePart inPart)
        {
            InitializeComponent();
            modPartIDTextBox.Text = inPart.PartID.ToString();
            modPartNameTextBox.Text = inPart.Name;
            modPartInventoryTextBox.Text = inPart.Inventory.ToString();
            modPartCostTextBox.Text = inPart.Price.Substring(1).ToString();
            modPartMaxTextBox.Text = inPart.Max.ToString();
            modPartMinTextBox.Text = inPart.Min.ToString();
            modPartMacComTextBox.Text = inPart.MachineID.ToString();
        }

        public Modify_Part(OutsourcedPart outPart)
        {
            InitializeComponent();
            modPartIDTextBox.Text = outPart.PartID.ToString();
            modPartNameTextBox.Text = outPart.Name;
            modPartInventoryTextBox.Text = outPart.Inventory.ToString();
            modPartCostTextBox.Text = outPart.Price.Substring(1).ToString();
            modPartMaxTextBox.Text = outPart.Max.ToString();
            modPartMinTextBox.Text = outPart.Min.ToString();
            modPartMacComTextBox.Text = outPart.CompName;

            outsourcedRadioButton.Checked = true;
        }
        //override selected part with new data
        private void SavePartButton_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = int.Parse(modPartMinTextBox.Text);
                maxStock = int.Parse(modPartMaxTextBox.Text);
                invInStock = int.Parse(modPartInventoryTextBox.Text);
                price = decimal.Parse(modPartCostTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min must be numeric values.");
                return;
            }

            int id = int.Parse(modPartIDTextBox.Text);
            string name = modPartNameTextBox.Text;
            price = decimal.Parse(modPartCostTextBox.Text);
            minStock = int.Parse(modPartMinTextBox.Text);
            maxStock = int.Parse(modPartMaxTextBox.Text);
            invInStock = int.Parse(modPartInventoryTextBox.Text);


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
                InHousePart inPart = new InHousePart(id, name, invInStock, price, maxStock, minStock, int.Parse(modPartMacComTextBox.Text));
                Inventory.UpdatePart(id, inPart);
                inhouseRadioButton.Checked = true;
            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart(id, name, invInStock, price, maxStock, minStock, modPartMacComTextBox.Text);
                Inventory.UpdatePart(id, outPart);
                outsourcedRadioButton.Checked = true;
            }
            Close();
            MainWindow.partGridView.Update();
            MainWindow.partGridView.Refresh();
        }
        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            partMacComID.Text = "Company Name";
        }
        private void InhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            partMacComID.Text = "Machine ID";
        }
        private void CancelPartCreationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
