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
    public partial class Add_new_item : Form
    {
        public Add_new_item()
        {
            InitializeComponent();

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Hot Drinks");
            cmbCategory.Items.Add("Cold Drinks");
            cmbCategory.Items.Add("Frappe");
            cmbCategory.Items.Add("Non-Coffee");

            dgvProducts.DefaultCellStyle.ForeColor = Color.Black;
            dgvProducts.DefaultCellStyle.BackColor = Color.White;
            dgvProducts.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvProducts.RowsDefaultCellStyle.BackColor = Color.White;
            dgvProducts.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.Peru;
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel dashboard = new AdminPanel();
            dashboard.Show();
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.Add(
                txtCoffeeName.Text,
                txtDescription.Text,
                txtPrice.Text,
                cmbCategory.Text
            );

            MessageBox.Show("Product added successfully!");
            ClearFields();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvProducts.Rows[e.RowIndex].IsNewRow)
            {
                txtCoffeeName.Text = dgvProducts.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtDescription.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtPrice.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value?.ToString();
                cmbCategory.Text = dgvProducts.Rows[e.RowIndex].Cells[3].Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null && !dgvProducts.CurrentRow.IsNewRow)
            {
                dgvProducts.CurrentRow.Cells[0].Value = txtCoffeeName.Text;
                dgvProducts.CurrentRow.Cells[1].Value = txtDescription.Text;
                dgvProducts.CurrentRow.Cells[2].Value = txtPrice.Text;
                dgvProducts.CurrentRow.Cells[3].Value = cmbCategory.Text;

                MessageBox.Show("Product updated successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null && !dgvProducts.CurrentRow.IsNewRow)
            {
                dgvProducts.Rows.Remove(dgvProducts.CurrentRow);

                MessageBox.Show("Product deleted successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void ClearFields()
        {
            txtCoffeeName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1;
        }
    }
}
