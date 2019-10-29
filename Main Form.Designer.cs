namespace Inventory_Management_System
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.partGridView = new System.Windows.Forms.DataGridView();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.searchPartButton = new System.Windows.Forms.Button();
            this.partSearchTextBox = new System.Windows.Forms.TextBox();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.deleteProductButton);
            this.groupBox1.Controls.Add(this.productGridView);
            this.groupBox1.Controls.Add(this.modifyProductButton);
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.searchProductButton);
            this.groupBox1.Controls.Add(this.productSearchTextBox);
            this.groupBox1.Location = new System.Drawing.Point(516, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 297);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Products";
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(386, 255);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProductButton.TabIndex = 19;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.AllowUserToResizeColumns = false;
            this.productGridView.AllowUserToResizeRows = false;
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productGridView.Location = new System.Drawing.Point(61, 58);
            this.productGridView.MultiSelect = false;
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(400, 171);
            this.productGridView.TabIndex = 13;
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(305, 255);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductButton.TabIndex = 18;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(224, 255);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 23);
            this.addProductButton.TabIndex = 17;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // searchProductButton
            // 
            this.searchProductButton.Location = new System.Drawing.Point(205, 19);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(75, 23);
            this.searchProductButton.TabIndex = 15;
            this.searchProductButton.Text = "Search";
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Location = new System.Drawing.Point(305, 22);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(156, 20);
            this.productSearchTextBox.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.deletePartButton);
            this.groupBox2.Controls.Add(this.partGridView);
            this.groupBox2.Controls.Add(this.modifyPartButton);
            this.groupBox2.Controls.Add(this.addPartButton);
            this.groupBox2.Controls.Add(this.searchPartButton);
            this.groupBox2.Controls.Add(this.partSearchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 297);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Parts";
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(365, 255);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(75, 23);
            this.deletePartButton.TabIndex = 19;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // partGridView
            // 
            this.partGridView.AllowUserToAddRows = false;
            this.partGridView.AllowUserToDeleteRows = false;
            this.partGridView.AllowUserToResizeColumns = false;
            this.partGridView.AllowUserToResizeRows = false;
            this.partGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partGridView.Location = new System.Drawing.Point(40, 58);
            this.partGridView.MultiSelect = false;
            this.partGridView.Name = "partGridView";
            this.partGridView.RowHeadersVisible = false;
            this.partGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partGridView.Size = new System.Drawing.Size(400, 171);
            this.partGridView.TabIndex = 13;
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Location = new System.Drawing.Point(284, 255);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(75, 23);
            this.modifyPartButton.TabIndex = 18;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(203, 255);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 23);
            this.addPartButton.TabIndex = 17;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // searchPartButton
            // 
            this.searchPartButton.Location = new System.Drawing.Point(185, 22);
            this.searchPartButton.Name = "searchPartButton";
            this.searchPartButton.Size = new System.Drawing.Size(75, 23);
            this.searchPartButton.TabIndex = 15;
            this.searchPartButton.Text = "Search";
            this.searchPartButton.UseVisualStyleBackColor = true;
            this.searchPartButton.Click += new System.EventHandler(this.SearchPartButton_Click);
            // 
            // partSearchTextBox
            // 
            this.partSearchTextBox.Location = new System.Drawing.Point(284, 22);
            this.partSearchTextBox.Name = "partSearchTextBox";
            this.partSearchTextBox.Size = new System.Drawing.Size(156, 20);
            this.partSearchTextBox.TabIndex = 16;
            // 
            // exitAppButton
            // 
            this.exitAppButton.Location = new System.Drawing.Point(856, 367);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(75, 23);
            this.exitAppButton.TabIndex = 21;
            this.exitAppButton.Text = "Exit";
            this.exitAppButton.UseVisualStyleBackColor = true;
            this.exitAppButton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1015, 407);
            this.Controls.Add(this.exitAppButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Inventory Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button searchProductButton;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button searchPartButton;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitAppButton;
        public System.Windows.Forms.DataGridView productGridView;
        public System.Windows.Forms.DataGridView partGridView;
    }
}

