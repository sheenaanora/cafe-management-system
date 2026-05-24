using CafeManagementSystem.AdminModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class LoginForm : Form
    {
        private const string AdminUsername = "admin";
        private const string AdminPassword = "admin123";

        public LoginForm()
        {
            InitializeComponent();

            this.AcceptButton = loginButton;
            passwordTextarea.UseSystemPasswordChar = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextarea.Text.Trim();
            string password = passwordTextarea.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                ShowErrorMessage("Username cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowErrorMessage("Password cannot be empty.");
                return;
            }

            if (username == AdminUsername && password == AdminPassword)
            {
                MessageBox.Show("Login successful.");

                AdminPanel dashboard = new AdminPanel();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                ShowErrorMessage("Invalid username or password.");
            }
        }
        private void ShowErrorMessage(string message)
        {
            messageLabel.Text = message;
            messageLabel.ForeColor = Color.Red;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
