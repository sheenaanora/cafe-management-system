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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();

            dgvSales.DefaultCellStyle.ForeColor = Color.Black;
            dgvSales.DefaultCellStyle.BackColor = Color.White;

            dgvSales.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvSales.RowsDefaultCellStyle.BackColor = Color.White;

            dgvSales.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgvSales.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            dgvSales.DefaultCellStyle.SelectionBackColor = Color.Peru;
            dgvSales.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvSales.ReadOnly = true;
            dgvSales.AllowUserToAddRows = false;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel dashboard = new AdminPanel();
            dashboard.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sales report refreshed successfully!");
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
