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
using System.IO;

namespace CafeManagementSystem
{
    public partial class Add_new_item : Form
    {
        private string selectedImagePath = "";

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

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCoffeeName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            string savedImagePath = "";

            if (!string.IsNullOrWhiteSpace(selectedImagePath))
            {
                string fileName = Path.GetFileName(selectedImagePath);
                string uploadFolder = @"C:\xampp\htdocs\coffee-api\uploads";

                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }

                string destinationPath = Path.Combine(uploadFolder, fileName);
                File.Copy(selectedImagePath, destinationPath, true);

                savedImagePath = "http://127.0.0.1:8001/uploads/" + fileName;
            }

            using (HttpClient client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "name", txtCoffeeName.Text },
                    { "description", txtDescription.Text },
                    { "price", txtPrice.Text },
                    { "category", cmbCategory.Text },
                    { "product_image", savedImagePath }
                };

                var content = new FormUrlEncodedContent(values);

                HttpResponseMessage response = await client.PostAsync(
                    "http://127.0.0.1:8001/add_product.php",
                    content
                );

                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show(result);
            }

            dgvProducts.Rows.Add(
                txtCoffeeName.Text,
                txtDescription.Text,
                txtPrice.Text,
                cmbCategory.Text
            );

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

        private void picProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = open.FileName;
                picProduct.ImageLocation = open.FileName;
                picProduct.Image = Image.FromFile(open.FileName);
                picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
