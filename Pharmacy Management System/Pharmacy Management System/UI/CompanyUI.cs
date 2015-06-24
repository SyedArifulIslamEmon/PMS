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
    public partial class CompanyUI : Form
    {
        CompanyManager myCompanyManager = new CompanyManager();
        Company company = new Company();
        
        private int companyID = 0;

        private bool isUpdateMode = false;
        public void Reset()
        {
            companyNameTextBox.Clear();
            companyAddressTextBox.Clear();
            deleteButton.Enabled = false;
            updateButton.Enabled = false;
            //saveButton.Text = "Save";
        }
        public CompanyUI()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenuUI main = new MainMenuUI();
            main.Show();
        }

        private void CompanyUI_Load(object sender, EventArgs e)
        {
            ShowAll();
            
        }

        private void ShowAll()
        {
            List<Company> companies = myCompanyManager.ShowAll();
            companyListView.Items.Clear();

            foreach (Company company in companies)
            {
                var listViewItem = new ListViewItem(company.CompanyId.ToString());
                listViewItem.SubItems.Add(company.Name);
                listViewItem.SubItems.Add(company.Address);
                companyListView.Items.Add(listViewItem);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
              company.Name = companyNameTextBox.Text;

            company.Address = companyAddressTextBox.Text;

           // myCompanyManager.Save(company);

            bool isSuccess = false;
            if (isUpdateMode)
            {
               // isSuccess = myCompanyManager.Update(company);
            }
            else
            {
                isSuccess = myCompanyManager.Save(company);
            }


            if (isSuccess)
            {
                if (isUpdateMode)
                {
                    MessageBox.Show("Updated Successfully!");
                    saveButton.Text = "Save";
                    isUpdateMode = false;
                }
                else
                {
                    MessageBox.Show("Inserted Successfully!");
                }
                Reset();
                ShowAll();
            }
            else
            {
                if (isUpdateMode)
                {
                    MessageBox.Show("Update failed!");
                }
                else
                {
                    MessageBox.Show("Insertion Failed!");
                }
            }

            

        }

        private void companyListView_DoubleClick(object sender, EventArgs e)
        {
            // get selected item 

            if (companyListView.SelectedItems.Count > 0)
            {
                ListViewItem firstSelectedItem = companyListView.SelectedItems[0];

                int companyID = int.Parse(firstSelectedItem.Text);

                Company company = myCompanyManager.GetStudentById(companyID);

                companyNameTextBox.Text = company.Name;
                companyAddressTextBox.Text = company.Address;
                

                isUpdateMode = true;

                this.companyID = company.CompanyId;
                deleteButton.Enabled = true;
                updateButton.Enabled = true;
                //saveButton.Text = "Update";

            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            

            company.Name = companyNameTextBox.Text;
            company.CompanyId = companyID;
            company.Address = companyAddressTextBox.Text;
            myCompanyManager.Update(company);
            ShowAll();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            company.Name = companyNameTextBox.Text;
            company.CompanyId = companyID;
            company.Address = companyAddressTextBox.Text;
            if (company.Name=="" && company.Address=="")
            {
                MessageBox.Show("Field can't be blank");
            }
            myCompanyManager.Delete(company);
            ShowAll();
        }

       
    }
}
