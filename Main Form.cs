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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Inventory.ExampleItems();

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.Parts;
            partGridView.DataSource = partTable;

            var prodTable = new BindingSource();
            prodTable.DataSource = Inventory.Products;
            productGridView.DataSource = prodTable;
        }


        private void AddPartButton_Click(object sender, EventArgs e)
        {
            new Add_Part().ShowDialog();
        }

      
        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if(partGridView.CurrentRow.DataBoundItem.GetType() == typeof(Inventory_Management_System.InHousePart))
            {
                InHousePart inHousePart = (InHousePart)partGridView.CurrentRow.DataBoundItem;
                new Modify_Part(inHousePart).ShowDialog();
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)partGridView.CurrentRow.DataBoundItem;
                new Modify_Part(outsourcedPart).ShowDialog();
            }
        }
        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in partGridView.SelectedRows)
                {
                    partGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        //checks if text in search box matches id of a part. If it does then it selects the row.
        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            int searchValue = int.Parse(partSearchTextBox.Text);

            if (searchValue < 1) return;

            Part match = Inventory.LookupPart(int.Parse(partSearchTextBox.Text));

            
            foreach (DataGridViewRow row in partGridView.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if(part.PartID == match.PartID)
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
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            
            new Add_Product().ShowDialog();
        }
     
        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            Product selectedProd = (Product)productGridView.CurrentRow.DataBoundItem;
            new Modify_Product(selectedProd).ShowDialog();
        }

        //if there is more than one associated part then displays error else it removes row at selected index.
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product product = (Product)productGridView.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete product with associated parts. Please remove parts attached to this product.");
                    return;
                }
                foreach (DataGridViewRow row in productGridView.SelectedRows)
                {
                    productGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            int searchValue = int.Parse(productSearchTextBox.Text);

            if (searchValue < 1) return;

            Product match = Inventory.LookupProduct(int.Parse(productSearchTextBox.Text));


            foreach (DataGridViewRow row in productGridView.Rows)
            {
                Product product = (Product)row.DataBoundItem;
                if (product.ProductID == match.ProductID)
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
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
