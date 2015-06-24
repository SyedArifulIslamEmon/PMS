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
    public partial class MedicinUI : Form
    {
        MedicineManager myMedicineManager = new MedicineManager();
        CompanyManager myCompanyManager = new CompanyManager();
        public MedicinUI()
        {
            InitializeComponent();
        }

        private void MedicinUI_Load(object sender, EventArgs e)
        {
            ShowAll();
            LoadAllCompanyInComboBox();
        }

        private void ShowAll()
        {
            List<Medicine> medicinelList = myMedicineManager.ShowAll();
            medicineListView.Items.Clear();

            foreach (Medicine medicine in medicinelList)
            {
                var listViewItem = new ListViewItem(medicine.medicineID.ToString());
                listViewItem.SubItems.Add(medicine.MedicineName);
                listViewItem.SubItems.Add(medicine.companyName);
                listViewItem.SubItems.Add(medicine.Quantity.ToString());
                listViewItem.SubItems.Add(medicine.unit);
                listViewItem.SubItems.Add(medicine.price.ToString());
                medicineListView.Items.Add(listViewItem);
                
            }
        }

        private void LoadAllCompanyInComboBox()
        {
            List<Company> companies = myCompanyManager.GetAllCompany();

            companyComboBox.DisplayMember = "company_id";
            companyComboBox.ValueMember = "company_name";
            companyComboBox.DataSource = null;
            companyComboBox.DataSource = companies;
        }

        private void medicineSaveButton_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.MedicineName = medicineNameTextBox.Text;

            medicine.companyName = companyComboBox.Text;
            medicine.unit = unitTextBox.Text;
            medicine.price = Convert.ToInt32(priceTextBox.Text);

            medicine.Quantity = int.Parse(quantityTextBox.Text.ToString());

            myMedicineManager.Save(medicine);

            ShowAll();
        }

        private void medicineCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuUI main = new MainMenuUI();
            main.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
