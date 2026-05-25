using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Linq;

namespace CafeManagementSystem
{
    public partial class ViewOrderPanel : Form
    {
        private bool apiWarningShown = false;
        private List<Order> allOrders = new List<Order>();
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

            cmbOrderFilter.Items.Clear();
            cmbOrderFilter.Items.Add("All");
            cmbOrderFilter.Items.Add("Pending");
            cmbOrderFilter.Items.Add("Preparing");
            cmbOrderFilter.Items.Add("Ready");
            cmbOrderFilter.Items.Add("Completed");
            cmbOrderFilter.SelectedIndex = 0;

            txtOrderSearch.TextChanged += txtOrderSearch_TextChanged;
            cmbOrderFilter.SelectedIndexChanged += cmbOrderFilter_SelectedIndexChanged;

            LoadOrders();

            refreshTimer.Interval = 30000;
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

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = await client.GetStringAsync("http://127.0.0.1:8001/orders.php");

                    allOrders = JsonConvert.DeserializeObject<List<Order>>(json);

                    ApplyOrderSearchAndFilter();
                }
            }
            catch
            {
                allOrders = new List<Order>();
                dgvOrders.Rows.Clear();
                lblTotalOrders.Text = "Total Orders: 0";

                if (!apiWarningShown)
                {
                    apiWarningShown = true;

                    MessageBox.Show(
                        "API Server is Offline.\nNo order data loaded.",
                        "Connection Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void ApplyOrderSearchAndFilter()
        {
            dgvOrders.Rows.Clear();

            string search = txtOrderSearch.Text.Trim().ToLower();
            string filter = cmbOrderFilter.Text;

            var filteredOrders = allOrders.Where(order =>
                (
                    string.IsNullOrWhiteSpace(search) ||
                    order.id.ToLower().Contains(search) ||
                    order.product_name.ToLower().Contains(search) ||
                    order.customer_name.ToLower().Contains(search) ||
                    order.status.ToLower().Contains(search)
                )
                &&
                (
                    filter == "All" ||
                    string.IsNullOrWhiteSpace(filter) ||
                    order.status == filter
                )
            ).ToList();

            foreach (Order order in filteredOrders)
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

            lblTotalOrders.Text = "Total Orders: " + filteredOrders.Count;
        }

        private void txtOrderSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyOrderSearchAndFilter();
        }

        private void cmbOrderFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyOrderSearchAndFilter();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel dashboard = new AdminPanel();
            dashboard.Show();
            this.Hide();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            refreshTimer.Stop();

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
                    "http://127.0.0.1:8001/update_order_status.php",
                    content
                );

                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show(result);
            }

            LoadOrders();
            refreshTimer.Start();
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            refreshTimer.Stop();

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
                    "http://127.0.0.1:8001/delete_order.php",
                    content
                );

                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show(result);
            }

            LoadOrders();
            refreshTimer.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminPanel dashboard = new AdminPanel();
            dashboard.Show();
            this.Hide();
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
    }
}