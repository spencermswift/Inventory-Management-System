namespace Inventory_Management_System
{
    partial class Modify_Part
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
            this.cancelPartCreationButton = new System.Windows.Forms.Button();
            this.savePartButton = new System.Windows.Forms.Button();
            this.modPartMacComTextBox = new System.Windows.Forms.TextBox();
            this.modPartMinTextBox = new System.Windows.Forms.TextBox();
            this.modPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.modPartCostTextBox = new System.Windows.Forms.TextBox();
            this.modPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modPartNameTextBox = new System.Windows.Forms.TextBox();
            this.modPartIDTextBox = new System.Windows.Forms.TextBox();
            this.partMacComID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.inhouseRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cancelPartCreationButton
            // 
            this.cancelPartCreationButton.Location = new System.Drawing.Point(379, 296);
            this.cancelPartCreationButton.Name = "cancelPartCreationButton";
            this.cancelPartCreationButton.Size = new System.Drawing.Size(75, 23);
            this.cancelPartCreationButton.TabIndex = 38;
            this.cancelPartCreationButton.Text = "Cancel";
            this.cancelPartCreationButton.UseVisualStyleBackColor = true;
            this.cancelPartCreationButton.Click += new System.EventHandler(this.CancelPartCreationButton_Click);
            // 
            // savePartButton
            // 
            this.savePartButton.Location = new System.Drawing.Point(287, 296);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(75, 23);
            this.savePartButton.TabIndex = 37;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // modPartMacComTextBox
            // 
            this.modPartMacComTextBox.Location = new System.Drawing.Point(172, 229);
            this.modPartMacComTextBox.Name = "modPartMacComTextBox";
            this.modPartMacComTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartMacComTextBox.TabIndex = 36;
            // 
            // modPartMinTextBox
            // 
            this.modPartMinTextBox.Location = new System.Drawing.Point(320, 194);
            this.modPartMinTextBox.Name = "modPartMinTextBox";
            this.modPartMinTextBox.Size = new System.Drawing.Size(74, 20);
            this.modPartMinTextBox.TabIndex = 35;
            // 
            // modPartMaxTextBox
            // 
            this.modPartMaxTextBox.Location = new System.Drawing.Point(172, 195);
            this.modPartMaxTextBox.Name = "modPartMaxTextBox";
            this.modPartMaxTextBox.Size = new System.Drawing.Size(68, 20);
            this.modPartMaxTextBox.TabIndex = 34;
            // 
            // modPartCostTextBox
            // 
            this.modPartCostTextBox.Location = new System.Drawing.Point(172, 161);
            this.modPartCostTextBox.Name = "modPartCostTextBox";
            this.modPartCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartCostTextBox.TabIndex = 33;
            // 
            // modPartInventoryTextBox
            // 
            this.modPartInventoryTextBox.Location = new System.Drawing.Point(172, 131);
            this.modPartInventoryTextBox.Name = "modPartInventoryTextBox";
            this.modPartInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartInventoryTextBox.TabIndex = 32;
            // 
            // modPartNameTextBox
            // 
            this.modPartNameTextBox.Location = new System.Drawing.Point(172, 100);
            this.modPartNameTextBox.Name = "modPartNameTextBox";
            this.modPartNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartNameTextBox.TabIndex = 31;
            // 
            // modPartIDTextBox
            // 
            this.modPartIDTextBox.Location = new System.Drawing.Point(172, 67);
            this.modPartIDTextBox.Name = "modPartIDTextBox";
            this.modPartIDTextBox.ReadOnly = true;
            this.modPartIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartIDTextBox.TabIndex = 30;
            // 
            // partMacComID
            // 
            this.partMacComID.AutoSize = true;
            this.partMacComID.Location = new System.Drawing.Point(90, 236);
            this.partMacComID.Name = "partMacComID";
            this.partMacComID.Size = new System.Drawing.Size(62, 13);
            this.partMacComID.TabIndex = 29;
            this.partMacComID.Text = "Machine ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID";
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.Location = new System.Drawing.Point(282, 12);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadioButton.TabIndex = 22;
            this.outsourcedRadioButton.TabStop = true;
            this.outsourcedRadioButton.Text = "Outsourced";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            this.outsourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // inhouseRadioButton
            // 
            this.inhouseRadioButton.AutoSize = true;
            this.inhouseRadioButton.Location = new System.Drawing.Point(172, 11);
            this.inhouseRadioButton.Name = "inhouseRadioButton";
            this.inhouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.inhouseRadioButton.TabIndex = 21;
            this.inhouseRadioButton.TabStop = true;
            this.inhouseRadioButton.Text = "In-House";
            this.inhouseRadioButton.UseVisualStyleBackColor = true;
            this.inhouseRadioButton.CheckedChanged += new System.EventHandler(this.InhouseRadioButton_CheckedChanged);
            // 
            // Modify_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 344);
            this.Controls.Add(this.cancelPartCreationButton);
            this.Controls.Add(this.savePartButton);
            this.Controls.Add(this.modPartMacComTextBox);
            this.Controls.Add(this.modPartMinTextBox);
            this.Controls.Add(this.modPartMaxTextBox);
            this.Controls.Add(this.modPartCostTextBox);
            this.Controls.Add(this.modPartInventoryTextBox);
            this.Controls.Add(this.modPartNameTextBox);
            this.Controls.Add(this.modPartIDTextBox);
            this.Controls.Add(this.partMacComID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outsourcedRadioButton);
            this.Controls.Add(this.inhouseRadioButton);
            this.Name = "Modify_Part";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelPartCreationButton;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.TextBox modPartMacComTextBox;
        private System.Windows.Forms.TextBox modPartMinTextBox;
        private System.Windows.Forms.TextBox modPartMaxTextBox;
        private System.Windows.Forms.TextBox modPartCostTextBox;
        private System.Windows.Forms.TextBox modPartInventoryTextBox;
        private System.Windows.Forms.TextBox modPartNameTextBox;
        private System.Windows.Forms.TextBox modPartIDTextBox;
        private System.Windows.Forms.Label partMacComID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.RadioButton inhouseRadioButton;
    }
}