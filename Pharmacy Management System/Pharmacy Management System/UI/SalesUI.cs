using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Management_System.BLL;
using Pharmacy_Management_System.MODEL;

namespace Pharmacy_Management_System.UI
{
    public partial class SalesUI : Form
    {
        Sale sale = new Sale();
        SaleManager myManager = new SaleManager();
        public SalesUI()
        {
            InitializeComponent();
        }

        private void salesCloseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenuUI main = new MainMenuUI();
            main.Show();
        }

        private void saveSalesButton_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.MedicineName = medicineNameTextBox.Text;

            sale.Quantity = int.Parse(quantityTextBox.Text);

            sale.Date = saledateTimePicker1.Text;

            sale.Description = descriptionTextBox.Text;

            MessageBox.Show("Saved Successfully!");
        }

        private void salesSearchButton_Click(object sender, EventArgs e)
        {
            string sales_id = salesSearchTextBox.Text;

            if (sales_id != "")
            {
                SearchAll(sales_id);
                salesSearchTextBox.Clear();
            }
            else if (sales_id == "")
            {
                //ShowAll();
                salesSearchTextBox.Focus();
            }
            
        }

        private void SearchAll(string sales_id)
        {
           
            medicineNameTextBox.Text = sale.MedicineName;
            quantityTextBox.Text = sale.Quantity.ToString();
            saledateTimePicker1.Text = sale.Date;
            descriptionTextBox.Text = sale.Description;

            myManager.SearchAll(sales_id);

        }
    }
}
