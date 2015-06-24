using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text =="user" && passwordTextBox.Text=="12345")
            {
                
                MainMenuUI main = new MainMenuUI();
                //this.Hide();
                main.Show();
                
                
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please input user name");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please input password");
            }
            else
            {
                MessageBox.Show("Invalid Credintial");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
