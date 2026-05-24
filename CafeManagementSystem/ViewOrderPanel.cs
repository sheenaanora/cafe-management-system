using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class ViewOrderPanel : Form
    {
        public ViewOrderPanel()
        {
            InitializeComponent();

            dgvOrders.DefaultCellStyle.ForeColor = Color.Black;
            dgvOrders.DefaultCellStyle.BackColor = Color.White;

            dgvOrders.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvOrders.RowsDefaultCellStyle.BackColor = Color.White;

            dgvOrders.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel dashboard = new AdminPanel();
            dashboard.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null && !dgvOrders.CurrentRow.IsNewRow)
            {
                dgvOrders.CurrentRow.Cells[3].Value = cmbStatus.Text;

                MessageBox.Show("Order status updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select an order.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null && !dgvOrders.CurrentRow.IsNewRow)
            {
                dgvOrders.Rows.Remove(dgvOrders.CurrentRow);

                MessageBox.Show("Order removed successfully!");
            }
            else
            {
                MessageBox.Show("Please select an order.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = row.Cells[1].Value.ToString()
                    .ToLower()
                    .Contains(txtSearch.Text.ToLower());

                row.Visible = visible;
            }
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

        private void btnSales_Click(object sender, EventArgs e)
        {
            PaymentForm sales = new PaymentForm();
            sales.Show();
            this.Hide();
        }
    }
}
