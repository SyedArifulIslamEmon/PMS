namespace Pharmacy_Management_System
{
    partial class MainMenuUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyButton = new System.Windows.Forms.Button();
            this.medicineButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Pharmacy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CompanyButton
            // 
            this.CompanyButton.Location = new System.Drawing.Point(85, 134);
            this.CompanyButton.Name = "CompanyButton";
            this.CompanyButton.Size = new System.Drawing.Size(144, 52);
            this.CompanyButton.TabIndex = 1;
            this.CompanyButton.Text = "Company";
            this.CompanyButton.UseVisualStyleBackColor = true;
            this.CompanyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // medicineButton
            // 
            this.medicineButton.Location = new System.Drawing.Point(259, 134);
            this.medicineButton.Name = "medicineButton";
            this.medicineButton.Size = new System.Drawing.Size(144, 52);
            this.medicineButton.TabIndex = 2;
            this.medicineButton.Text = "Medicine";
            this.medicineButton.UseVisualStyleBackColor = true;
            this.medicineButton.Click += new System.EventHandler(this.medicineButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(85, 212);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(144, 52);
            this.purchaseButton.TabIndex = 3;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Location = new System.Drawing.Point(259, 212);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(144, 52);
            this.salesButton.TabIndex = 4;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // MainMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 360);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.medicineButton);
            this.Controls.Add(this.CompanyButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainMenuUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CompanyButton;
        private System.Windows.Forms.Button medicineButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button salesButton;
    }
}

