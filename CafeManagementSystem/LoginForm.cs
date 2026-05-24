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
        private const string connectionString = "Data Source=CODING-0\\SQLEXPRESS;Initial Catalog=database_project;Integrated Security=True";
        SignupPanel signup;
        Color color;
        public LoginForm()
        {
            InitializeComponent();
            color = Color.CadetBlue;
            signup = new SignupPanel();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginMouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Aqua;
        }

        private void loginMouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = color;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = usernameTextarea.Text;
            string password = passwordTextarea.Text;

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

            MessageBox.Show("Login successful.");

            AdminPanel dashboard = new AdminPanel();
            dashboard.Show();
            this.Hide();
        }
        private void ShowErrorMessage(string message)
        {
            // Change messageLabel text and color
            messageLabel.Text = message;
            messageLabel.ForeColor = Color.Red; // Change color to red
        }


        private void signupButton_Click(object sender, EventArgs e)
        {
            signup.signupPanel.Show();
            Controls.Add(signup.signupPanel);
            signup.signupPanel.BringToFront();



        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
