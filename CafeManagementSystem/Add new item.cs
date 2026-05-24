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
        }

        private void panelContainingAddNewItem_Paint(object sender, PaintEventArgs e)
        {

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
            txtPrice.Text,
        );

            MessageBox.Show("Product Added Successfully!");

            txtCoffeeName.Clear();
            txtPrice.Clear();
        }
    }
}
