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
using Newtonsoft.Json;

namespace CafeManagementSystem
{
    public partial class Add_new_item : Form
    {

        public class Product
        {
            public string id { get; set; }
            public string coffee_name { get; set; }
            public string description { get; set; }
            public string price { get; set; }
            public string category { get; set; }
            public string product_image { get; set; }
        }

        private List<Product> productList = new List<Product>();
        private string selectedImagePath = "";
        private string selectedProductId = "";
        private string currentImageUrl = "";

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

            LoadProducts();
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

            LoadProducts();

            ClearFields();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvProducts.Rows[e.RowIndex].IsNewRow)
            {
                Product selectedProduct = productList[e.RowIndex];

                selectedProductId = selectedProduct.id;
                currentImageUrl = selectedProduct.product_image;

                txtCoffeeName.Text = selectedProduct.coffee_name;
                txtDescription.Text = selectedProduct.description;
                txtPrice.Text = selectedProduct.price;
                cmbCategory.Text = selectedProduct.category;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedProductId))
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            string savedImagePath = currentImageUrl;

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
            { "id", selectedProductId },
            { "name", txtCoffeeName.Text },
            { "description", txtDescription.Text },
            { "price", txtPrice.Text },
            { "category", cmbCategory.Text },
            { "product_image", savedImagePath }
        };

                var content = new FormUrlEncodedContent(values);

                HttpResponseMessage response = await client.PostAsync(
                    "http://127.0.0.1:8001/update_product.php",
                    content
                );

                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show(result);
            }

            ClearFields();
            LoadProducts();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedProductId))
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                var values = new Dictionary<string, string>
        {
            { "id", selectedProductId }
        };

                var content = new FormUrlEncodedContent(values);

                HttpResponseMessage response = await client.PostAsync(
                    "http://127.0.0.1:8001/delete_product.php",
                    content
                );

                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show(result);
            }

            LoadProducts();
            ClearFields();
        }

        private void ClearFields()
        {
            txtCoffeeName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1;
            selectedProductId = "";
            selectedImagePath = "";
            currentImageUrl = "";
            picProduct.Image = null;
        }

        private async void LoadProducts()
        {
            dgvProducts.Rows.Clear();

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(
                    "http://127.0.0.1:8001/products.php"
                );

                List<Product> products =
                    JsonConvert.DeserializeObject<List<Product>>(json);

                productList = products;

                foreach (Product product in products)
                {
                    dgvProducts.Rows.Add(
                        product.coffee_name,
                        product.description,
                        product.price,
                        product.category
                    );
                }
            }
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
