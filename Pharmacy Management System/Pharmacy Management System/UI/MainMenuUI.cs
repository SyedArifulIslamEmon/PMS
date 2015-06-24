using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Management_System.UI;

namespace Pharmacy_Management_System
{
    public partial class MainMenuUI : Form
    {
        public MainMenuUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            CompanyUI company = new CompanyUI();
            company.Show();
            this.Visible = false;

        }

        private void medicineButton_Click(object sender, EventArgs e)
        {
            MedicinUI medicinUi = new MedicinUI();
            medicinUi.Show();
            this.Visible = false;
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            SalesUI sales = new SalesUI();
            sales.Show();
            this.Visible = false;
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseUI purchase = new PurchaseUI();
            purchase.Show();
            this.Visible = false;
        }
    }
}
