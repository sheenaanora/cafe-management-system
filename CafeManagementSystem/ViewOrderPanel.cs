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

            dgvOrders.Rows.Add("001", "Latte", "₱150", "Pending", "Sheena");
            dgvOrders.Rows.Add("002", "Espresso", "₱120", "Preparing", "John");
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void ViewOrderPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel dashboard = new AdminPanel();
            dashboard.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null)
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
            if (dgvOrders.CurrentRow != null)
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
    }
}
