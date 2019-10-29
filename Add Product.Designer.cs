namespace Inventory_Management_System
{
    partial class Add_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.candidatePartsGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.addProductIDTextBox = new System.Windows.Forms.TextBox();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.addProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.addProductMinTextBox = new System.Windows.Forms.TextBox();
            this.searchPartTextBox = new System.Windows.Forms.TextBox();
            this.searchPartListButton = new System.Windows.Forms.Button();
            this.addPartToItemButton = new System.Windows.Forms.Button();
            this.associatedPartsGrid = new System.Windows.Forms.DataGridView();
            this.deleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelAddProductbutton = new System.Windows.Forms.Button();
            this.saveNewProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Min";
            // 
            // candidatePartsGrid
            // 
            this.candidatePartsGrid.AllowUserToAddRows = false;
            this.candidatePartsGrid.AllowUserToDeleteRows = false;
            this.candidatePartsGrid.AllowUserToResizeColumns = false;
            this.candidatePartsGrid.AllowUserToResizeRows = false;
            this.candidatePartsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.candidatePartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatePartsGrid.Location = new System.Drawing.Point(336, 65);
            this.candidatePartsGrid.Name = "candidatePartsGrid";
            this.candidatePartsGrid.RowHeadersVisible = false;
            this.candidatePartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candidatePartsGrid.Size = new System.Drawing.Size(426, 119);
            this.candidatePartsGrid.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "All Candidate Parts";
            // 
            // addProductIDTextBox
            // 
            this.addProductIDTextBox.Location = new System.Drawing.Point(113, 139);
            this.addProductIDTextBox.Name = "addProductIDTextBox";
            this.addProductIDTextBox.ReadOnly = true;
            this.addProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductIDTextBox.TabIndex = 9;
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Location = new System.Drawing.Point(113, 178);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductNameTextBox.TabIndex = 10;
            // 
            // addProductInventoryTextBox
            // 
            this.addProductInventoryTextBox.Location = new System.Drawing.Point(113, 218);
            this.addProductInventoryTextBox.Name = "addProductInventoryTextBox";
            this.addProductInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductInventoryTextBox.TabIndex = 11;
            // 
            // addProductPriceTextBox
            // 
            this.addProductPriceTextBox.Location = new System.Drawing.Point(113, 260);
            this.addProductPriceTextBox.Name = "addProductPriceTextBox";
            this.addProductPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductPriceTextBox.TabIndex = 12;
            // 
            // addProductMaxTextBox
            // 
            this.addProductMaxTextBox.Location = new System.Drawing.Point(113, 292);
            this.addProductMaxTextBox.Name = "addProductMaxTextBox";
            this.addProductMaxTextBox.Size = new System.Drawing.Size(51, 20);
            this.addProductMaxTextBox.TabIndex = 13;
            // 
            // addProductMinTextBox
            // 
            this.addProductMinTextBox.Location = new System.Drawing.Point(200, 292);
            this.addProductMinTextBox.Name = "addProductMinTextBox";
            this.addProductMinTextBox.Size = new System.Drawing.Size(56, 20);
            this.addProductMinTextBox.TabIndex = 14;
            // 
            // searchPartTextBox
            // 
            this.searchPartTextBox.Location = new System.Drawing.Point(593, 26);
            this.searchPartTextBox.Name = "searchPartTextBox";
            this.searchPartTextBox.Size = new System.Drawing.Size(168, 20);
            this.searchPartTextBox.TabIndex = 15;
            // 
            // searchPartListButton
            // 
            this.searchPartListButton.Location = new System.Drawing.Point(523, 26);
            this.searchPartListButton.Name = "searchPartListButton";
            this.searchPartListButton.Size = new System.Drawing.Size(55, 20);
            this.searchPartListButton.TabIndex = 16;
            this.searchPartListButton.Text = "Search";
            this.searchPartListButton.UseVisualStyleBackColor = true;
            this.searchPartListButton.Click += new System.EventHandler(this.SearchPartListButton_Click);
            // 
            // addPartToItemButton
            // 
            this.addPartToItemButton.Location = new System.Drawing.Point(704, 190);
            this.addPartToItemButton.Name = "addPartToItemButton";
            this.addPartToItemButton.Size = new System.Drawing.Size(58, 28);
            this.addPartToItemButton.TabIndex = 17;
            this.addPartToItemButton.Text = "Add";
            this.addPartToItemButton.UseVisualStyleBackColor = true;
            this.addPartToItemButton.Click += new System.EventHandler(this.AddPartToItemButton_Click);
            // 
            // associatedPartsGrid
            // 
            this.associatedPartsGrid.AllowUserToAddRows = false;
            this.associatedPartsGrid.AllowUserToDeleteRows = false;
            this.associatedPartsGrid.AllowUserToResizeColumns = false;
            this.associatedPartsGrid.AllowUserToResizeRows = false;
            this.associatedPartsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsGrid.Location = new System.Drawing.Point(336, 245);
            this.associatedPartsGrid.Name = "associatedPartsGrid";
            this.associatedPartsGrid.RowHeadersVisible = false;
            this.associatedPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsGrid.Size = new System.Drawing.Size(426, 119);
            this.associatedPartsGrid.TabIndex = 18;
            // 
            // deleteAssociatedPartButton
            // 
            this.deleteAssociatedPartButton.Location = new System.Drawing.Point(703, 370);
            this.deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            this.deleteAssociatedPartButton.Size = new System.Drawing.Size(59, 27);
            this.deleteAssociatedPartButton.TabIndex = 19;
            this.deleteAssociatedPartButton.Text = "Delete";
            this.deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.deleteAssociatedPartButton.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // cancelAddProductbutton
            // 
            this.cancelAddProductbutton.Location = new System.Drawing.Point(685, 469);
            this.cancelAddProductbutton.Name = "cancelAddProductbutton";
            this.cancelAddProductbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelAddProductbutton.TabIndex = 21;
            this.cancelAddProductbutton.Text = "Cancel";
            this.cancelAddProductbutton.UseVisualStyleBackColor = true;
            this.cancelAddProductbutton.Click += new System.EventHandler(this.CancelAddProductbutton_Click);
            // 
            // saveNewProductButton
            // 
            this.saveNewProductButton.Location = new System.Drawing.Point(593, 469);
            this.saveNewProductButton.Name = "saveNewProductButton";
            this.saveNewProductButton.Size = new System.Drawing.Size(75, 23);
            this.saveNewProductButton.TabIndex = 22;
            this.saveNewProductButton.Text = "Save";
            this.saveNewProductButton.UseVisualStyleBackColor = true;
            this.saveNewProductButton.Click += new System.EventHandler(this.SaveNewProductButton_Click);
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.saveNewProductButton);
            this.Controls.Add(this.cancelAddProductbutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteAssociatedPartButton);
            this.Controls.Add(this.associatedPartsGrid);
            this.Controls.Add(this.addPartToItemButton);
            this.Controls.Add(this.searchPartListButton);
            this.Controls.Add(this.searchPartTextBox);
            this.Controls.Add(this.addProductMinTextBox);
            this.Controls.Add(this.addProductMaxTextBox);
            this.Controls.Add(this.addProductPriceTextBox);
            this.Controls.Add(this.addProductInventoryTextBox);
            this.Controls.Add(this.addProductNameTextBox);
            this.Controls.Add(this.addProductIDTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.candidatePartsGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Add_Product";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView candidatePartsGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addProductIDTextBox;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.TextBox addProductInventoryTextBox;
        private System.Windows.Forms.TextBox addProductPriceTextBox;
        private System.Windows.Forms.TextBox addProductMaxTextBox;
        private System.Windows.Forms.TextBox addProductMinTextBox;
        private System.Windows.Forms.TextBox searchPartTextBox;
        private System.Windows.Forms.Button searchPartListButton;
        private System.Windows.Forms.Button addPartToItemButton;
        private System.Windows.Forms.DataGridView associatedPartsGrid;
        private System.Windows.Forms.Button deleteAssociatedPartButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancelAddProductbutton;
        private System.Windows.Forms.Button saveNewProductButton;
    }
}