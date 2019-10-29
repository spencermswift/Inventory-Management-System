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
    public partial class Modify_Product : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];
        public Modify_Product(Product prod)
        {
            InitializeComponent();

            //product fields populated with selected product
            modProductIDTextBox.Text = prod.ProductID.ToString();
            modProductNameTextBox.Text = prod.Name;
            modProductInventoryTextBox.Text = prod.Inventory.ToString();
            modProductPriceTextBox.Text = prod.Price.Substring(1).ToString();
            modProductMaxTextBox.Text = prod.Max.ToString();
            modProductMinTextBox.Text = prod.Min.ToString();

            //populates top table with all products
            var topTable = new BindingSource();
            topTable.DataSource = Inventory.Parts;
            modCandidatePartsGrid.DataSource = topTable;

            //populates bottom table with linked parts
            foreach (Part part in prod.AssociatedParts)
            {
                addedParts.Add(part);
            }
            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            modAssociatedPartsGrid.DataSource = botTable;
        }
        private void CancelAddProductbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveNewProductButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inventory;
            decimal price;
            
            try
            {
                min = int.Parse(modProductMinTextBox.Text);
                max = int.Parse(modProductMaxTextBox.Text);
                inventory = int.Parse(modProductInventoryTextBox.Text);
                price = decimal.Parse(modProductPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min must be numeric values.");
                return;
            }

            int id = int.Parse(modProductIDTextBox.Text);
            string name = modProductNameTextBox.Text;
            inventory = int.Parse(modProductInventoryTextBox.Text);
            price = decimal.Parse(modProductPriceTextBox.Text);
            min = int.Parse(modProductMinTextBox.Text);
            max = int.Parse(modProductMaxTextBox.Text);

            //prevents user from having higher min than max.
            if (min > max)
            {
                MessageBox.Show("Error: min cannot be greater than max");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }
            //creates new Product and adds it to inventory with parts
            Product product = new Product(id, name, inventory, price, max, min);
            foreach(Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Inventory.UpdateProduct(id, product);
            Close();

            MainWindow.productGridView.Update();
            MainWindow.productGridView.Refresh();
        }

        private void AddPartToItemButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)modCandidatePartsGrid.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        private void SearchPartListButton_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(modPartSearchTextBox.Text);
            Part match = Inventory.LookupPart(partID);
            foreach (DataGridViewRow row in modCandidatePartsGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void DeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                Part part = (Part)modAssociatedPartsGrid.CurrentRow.DataBoundItem;
                int id = int.Parse(modProductIDTextBox.Text);

                Product product = Inventory.LookupProduct(id);
                product.RemoveAssociatedPart(part.PartID);

                foreach (DataGridViewRow row in modAssociatedPartsGrid.SelectedRows)
                {
                    modAssociatedPartsGrid.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
    }
}
