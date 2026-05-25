using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace CafeManagementSystem
{
    public partial class AdminPanel : Form
    {
        private bool apiWarningShown = false;
        public AdminPanel()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Add_new_item products = new Add_new_item();
            products.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ViewOrderPanel orders = new ViewOrderPanel();
            orders.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            PaymentForm sales = new PaymentForm();
            sales.Show();
            this.Hide();
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminPanel dashboard = new AdminPanel();
            dashboard.Show();
            this.Hide();
        }

        private async void LoadDashboard()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync(
                        "http://127.0.0.1:8001/dashboard.php"
                    );

                    JObject data = JObject.Parse(response);

                    lblProducts.Text = data["total_products"].ToString();
                    lblOrders.Text = data["total_orders"].ToString();

                    decimal sales = Convert.ToDecimal(data["total_sales"]);
                    lblSales.Text = "₱" + sales.ToString("N2");
                }
            }
            catch
            {
                lblProducts.Text = "0";
                lblOrders.Text = "0";
                lblSales.Text = "₱0.00";

                if (!apiWarningShown)
                {
                    apiWarningShown = true;

                    MessageBox.Show(
                        "API Server is Offline.\nNo dashboard data loaded.",
                        "Connection Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }
    }
}
