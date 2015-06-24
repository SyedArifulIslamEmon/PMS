namespace Pharmacy_Management_System.UI
{
    partial class SalesUI
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
            this.salesSearchButton = new System.Windows.Forms.Button();
            this.salesSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salesCloseButton = new System.Windows.Forms.Button();
            this.saledateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.salesDeleteButton = new System.Windows.Forms.Button();
            this.salesResetButton = new System.Windows.Forms.Button();
            this.saveSalesButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.medicineNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salesSearchButton);
            this.groupBox1.Controls.Add(this.salesSearchTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Information";
            // 
            // salesSearchButton
            // 
            this.salesSearchButton.Location = new System.Drawing.Point(439, 21);
            this.salesSearchButton.Name = "salesSearchButton";
            this.salesSearchButton.Size = new System.Drawing.Size(75, 23);
            this.salesSearchButton.TabIndex = 2;
            this.salesSearchButton.Text = "Search";
            this.salesSearchButton.UseVisualStyleBackColor = true;
            this.salesSearchButton.Click += new System.EventHandler(this.salesSearchButton_Click);
            // 
            // salesSearchTextBox
            // 
            this.salesSearchTextBox.Location = new System.Drawing.Point(101, 26);
            this.salesSearchTextBox.Name = "salesSearchTextBox";
            this.salesSearchTextBox.Size = new System.Drawing.Size(280, 20);
            this.salesSearchTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.salesCloseButton);
            this.groupBox2.Controls.Add(this.saledateTimePicker1);
            this.groupBox2.Controls.Add(this.salesDeleteButton);
            this.groupBox2.Controls.Add(this.salesResetButton);
            this.groupBox2.Controls.Add(this.saveSalesButton);
            this.groupBox2.Controls.Add(this.descriptionTextBox);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.medicineNameTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales Information";
            // 
            // salesCloseButton
            // 
            this.salesCloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salesCloseButton.Location = new System.Drawing.Point(364, 161);
            this.salesCloseButton.Name = "salesCloseButton";
            this.salesCloseButton.Size = new System.Drawing.Size(75, 28);
            this.salesCloseButton.TabIndex = 12;
            this.salesCloseButton.Text = "Close";
            this.salesCloseButton.UseVisualStyleBackColor = true;
            this.salesCloseButton.Click += new System.EventHandler(this.salesCloseButton_Click);
            // 
            // saledateTimePicker1
            // 
            this.saledateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.saledateTimePicker1.Location = new System.Drawing.Point(284, 63);
            this.saledateTimePicker1.Name = "saledateTimePicker1";
            this.saledateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.saledateTimePicker1.TabIndex = 11;
            // 
            // salesDeleteButton
            // 
            this.salesDeleteButton.Location = new System.Drawing.Point(271, 161);
            this.salesDeleteButton.Name = "salesDeleteButton";
            this.salesDeleteButton.Size = new System.Drawing.Size(87, 28);
            this.salesDeleteButton.TabIndex = 10;
            this.salesDeleteButton.Text = "Delete";
            this.salesDeleteButton.UseVisualStyleBackColor = true;
            // 
            // salesResetButton
            // 
            this.salesResetButton.Location = new System.Drawing.Point(167, 161);
            this.salesResetButton.Name = "salesResetButton";
            this.salesResetButton.Size = new System.Drawing.Size(87, 28);
            this.salesResetButton.TabIndex = 9;
            this.salesResetButton.Text = "Reset";
            this.salesResetButton.UseVisualStyleBackColor = true;
            // 
            // saveSalesButton
            // 
            this.saveSalesButton.Location = new System.Drawing.Point(59, 161);
            this.saveSalesButton.Name = "saveSalesButton";
            this.saveSalesButton.Size = new System.Drawing.Size(87, 28);
            this.saveSalesButton.TabIndex = 8;
            this.saveSalesButton.Text = "Save";
            this.saveSalesButton.UseVisualStyleBackColor = true;
            this.saveSalesButton.Click += new System.EventHandler(this.saveSalesButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(114, 92);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(299, 47);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(114, 63);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(107, 20);
            this.quantityTextBox.TabIndex = 5;
            // 
            // medicineNameTextBox
            // 
            this.medicineNameTextBox.Location = new System.Drawing.Point(114, 30);
            this.medicineNameTextBox.Name = "medicineNameTextBox";
            this.medicineNameTextBox.Size = new System.Drawing.Size(299, 20);
            this.medicineNameTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Medicine Name";
            // 
            // SalesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.salesCloseButton;
            this.ClientSize = new System.Drawing.Size(571, 378);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesUI";
            this.Text = "SalesUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button salesSearchButton;
        private System.Windows.Forms.TextBox salesSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button salesDeleteButton;
        private System.Windows.Forms.Button salesResetButton;
        private System.Windows.Forms.Button saveSalesButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox medicineNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker saledateTimePicker1;
        private System.Windows.Forms.Button salesCloseButton;
    }
}