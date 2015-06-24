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
using Pharmacy_Management_System.DAL;
using Pharmacy_Management_System.MODEL;

namespace Pharmacy_Management_System.UI
{
    public partial class PurchaseUI : Form
    {
        //PurchaseGateway myPurchaseGateway = new PurchaseGateway();
        PurchaseManager myPurchaseManager = new PurchaseManager();
        public PurchaseUI()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();



            purchase.PurchaseDate = purchasedateTimePicker.Text; 

            purchase.Quantity = int.Parse(quantityTextBox.Text);

            purchase.MedicineName = medicineNameTextBox.Text; 

            MessageBox.Show("Saved successfully");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuUI mainMenu = new MainMenuUI();
            mainMenu.Show();
        }

        private void PurchaseUI_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll()
        {
            List<Purchase> purchases = myPurchaseManager.ShowAll();
            purchaseListView.Items.Clear();

            foreach (Purchase purchase in purchases)
            {
                var listViewItem = new ListViewItem(purchase.PurchaseId.ToString());
                listViewItem.SubItems.Add(purchase.PurchaseDate); 
                listViewItem.SubItems.Add(purchase.MedicineName);
                listViewItem.SubItems.Add(purchase.Quantity.ToString());
                listViewItem.SubItems.Add(purchase.price.ToString());
                purchaseListView.Items.Add(listViewItem);

            }
        }
    }
}
