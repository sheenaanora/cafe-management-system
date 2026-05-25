using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CafeManagementSystem
{
    public partial class ViewOrderPanel : Form
    {

        private System.Windows.Forms.Timer refreshTimer = new System.Windows.Forms.Timer();
        public class Order
        {
            public string id { get; set; }
            public string product_name { get; set; }
            public string quantity { get; set; }
            public string total_price { get; set; }
            public string status { get; set; }
            public string customer_name { get; set; }
        }

        public ViewOrderPanel()
        {
            InitializeComponent();

            dgvOrders.DefaultCellStyle.ForeColor = Color.Black;
            dgvOrders.DefaultCellStyle.BackColor = Color.White;
            dgvOrders.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvOrders.RowsDefaultCellStyle.BackColor = Color.White;
            dgvOrders.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvOrders.DefaultCellStyle.SelectionBackColor = Color.Peru;
            dgvOrders.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvOrders.ReadOnly = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Preparing");
            cmbStatus.Items.Add("Ready");
            cmbStatus.Items.Add("Completed");

            LoadOrders();

            refreshTimer.Interval = 5000;
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private async void LoadOrders()
        {
            dgvOrders.Rows.Clear();

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync("http://localhost/coffee-api/orders.php");
                List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(json);

                foreach (Order order in orders)
                {
                    dgvOrders.Rows.Add(
                        order.id,
                        order.product_name,
                         order.quantity,
                        "₱" + order.total_price,
                        order.status,
                        order.customer_name
                    );
                }

                lblTotalOrders.Text = "Total Orders: " + orders.Count;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel dashboard = new AdminPanel();
            dashboard.Show();
            this.Hide();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null || dgvOrders.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            string orderId = dgvOrders.CurrentRow.Cells[0].Value.ToString();

            using (HttpClient client = new HttpClient())
            {
                var values = new Dictionary<string, string>
        {
            { "id", orderId },
            { "status", cmbStatus.Text }
        };

                var content = new FormUrlEncodedContent(values);

                HttpResponseMessage response = await client.PostAsync(
                    "http://localhost/coffee-api/update_order_status.php",
                    content
                );

                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show(result);
            }

            dgvOrders.CurrentRow.Cells[4].Value = cmbStatus.Text;
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null || dgvOrders.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to remove this order?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            string orderId = dgvOrders.CurrentRow.Cells[0].Value.ToString();

            using (HttpClient client = new HttpClient())
            {
                var values = new Dictionary<string, string>
        {
            { "id", orderId }
        };

                var content = new FormUrlEncodedContent(values);

                HttpResponseMessage response = await client.PostAsync(
                    "http://localhost/coffee-api/delete_order.php",
                    content
                );

                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show(result);
            }

            dgvOrders.Rows.Remove(dgvOrders.CurrentRow);
            lblTotalOrders.Text = "Total Orders: " + dgvOrders.Rows.Count;
        }
    }
}