namespace CafeManagementSystem
{
    partial class PaymentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            scrollableMenu = new Panel();
            label11 = new Label();
            panel1 = new Panel();
            lblTotalOrders = new Label();
            lblTotalRevenue = new Label();
            lblBestSeller = new Label();
            btnRefresh = new Button();
            label2 = new Label();
            dgvSales = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            colProduct = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel3 = new Panel();
            btnSales = new Button();
            btnOrders = new Button();
            panel4 = new Panel();
            btnProducts = new Button();
            btnDashboard = new Button();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            label14 = new Label();
            label3 = new Label();
            scrollableMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // scrollableMenu
            // 
            scrollableMenu.AutoScroll = true;
            scrollableMenu.BackColor = Color.FromArgb(243, 233, 220);
            scrollableMenu.Controls.Add(label11);
            scrollableMenu.Controls.Add(panel1);
            scrollableMenu.Controls.Add(btnRefresh);
            scrollableMenu.Controls.Add(label2);
            scrollableMenu.Controls.Add(dgvSales);
            scrollableMenu.Controls.Add(label1);
            scrollableMenu.Font = new Font("Microsoft Sans Serif", 8.25F);
            scrollableMenu.Location = new Point(119, 48);
            scrollableMenu.Name = "scrollableMenu";
            scrollableMenu.Size = new Size(709, 490);
            scrollableMenu.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.System;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Peru;
            label11.Location = new Point(277, 57);
            label11.Name = "label11";
            label11.Size = new Size(191, 15);
            label11.TabIndex = 44;
            label11.Text = "Daily Coffee Shop Sales Monitoring";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTotalOrders);
            panel1.Controls.Add(lblTotalRevenue);
            panel1.Controls.Add(lblBestSeller);
            panel1.Location = new Point(17, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 210);
            panel1.TabIndex = 4;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.BackColor = Color.White;
            lblTotalOrders.FlatStyle = FlatStyle.System;
            lblTotalOrders.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOrders.ForeColor = Color.Black;
            lblTotalOrders.Location = new Point(30, 38);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(112, 20);
            lblTotalOrders.TabIndex = 36;
            lblTotalOrders.Text = "Total Orders: 0";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.BackColor = Color.White;
            lblTotalRevenue.FlatStyle = FlatStyle.System;
            lblTotalRevenue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenue.ForeColor = Color.Black;
            lblTotalRevenue.Location = new Point(13, 107);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(157, 20);
            lblTotalRevenue.TabIndex = 37;
            lblTotalRevenue.Text = "Total Revenue: ₱0.00";
            // 
            // lblBestSeller
            // 
            lblBestSeller.AutoSize = true;
            lblBestSeller.BackColor = Color.White;
            lblBestSeller.FlatStyle = FlatStyle.System;
            lblBestSeller.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBestSeller.ForeColor = Color.Black;
            lblBestSeller.Location = new Point(30, 169);
            lblBestSeller.Name = "lblBestSeller";
            lblBestSeller.Size = new Size(129, 20);
            lblBestSeller.TabIndex = 38;
            lblBestSeller.Text = "Best Seller: None";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Peru;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.Peru;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(37, 429);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 40);
            btnRefresh.TabIndex = 34;
            btnRefresh.Text = "Refresh Report";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(411, 89);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 12;
            label2.Text = "Sales Transactions";
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.BackgroundColor = Color.White;
            dgvSales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { colDate, colCustomer, colProduct, colQuantity, colTotal });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Peru;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = Color.BlanchedAlmond;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSales.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSales.EnableHeadersVisualStyles = false;
            dgvSales.GridColor = Color.Gainsboro;
            dgvSales.Location = new Point(207, 112);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(490, 357);
            dgvSales.TabIndex = 11;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colCustomer
            // 
            colCustomer.HeaderText = "Customer";
            colCustomer.Name = "colCustomer";
            colCustomer.ReadOnly = true;
            // 
            // colProduct
            // 
            colProduct.HeaderText = "Product";
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(280, 17);
            label1.Name = "label1";
            label1.Size = new Size(188, 40);
            label1.TabIndex = 9;
            label1.Text = "Sales Report";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 26, 18);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnSales);
            panel3.Controls.Add(btnOrders);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnProducts);
            panel3.Controls.Add(btnDashboard);
            panel3.Location = new Point(0, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 473);
            panel3.TabIndex = 45;
            // 
            // btnSales
            // 
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.System;
            btnSales.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(0, 126);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(126, 42);
            btnSales.TabIndex = 6;
            btnSales.Text = "SALES";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.System;
            btnOrders.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnOrders.ForeColor = Color.White;
            btnOrders.Location = new Point(0, 84);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(126, 42);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "ORDERS";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(0, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 100);
            panel4.TabIndex = 3;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.System;
            btnProducts.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 42);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(126, 42);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.Chocolate;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.Peru;
            btnDashboard.FlatStyle = FlatStyle.System;
            btnDashboard.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(126, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(31, 26, 23);
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(0, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(828, 68);
            panel5.TabIndex = 45;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 17);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(58, 19);
            label14.Name = "label14";
            label14.Size = new Size(258, 32);
            label14.TabIndex = 7;
            label14.Text = "Coffee Admin System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(649, 25);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 6;
            label3.Text = "Coffee Shop Administrator";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Yellow;
            ClientSize = new Size(828, 535);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(scrollableMenu);
            ForeColor = Color.BlanchedAlmond;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            scrollableMenu.ResumeLayout(false);
            scrollableMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel scrollableMenu;
        private Label label1;
        private Label label2;
        private DataGridView dgvSales;
        private Button btnRefresh;
        private Label lblBestSeller;
        private Label lblTotalRevenue;
        private Label lblTotalOrders;
        private Panel panel1;
        private Label label11;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colTotal;
        private Panel panel3;
        private Button btnSales;
        private Button btnOrders;
        private Panel panel4;
        private Button btnProducts;
        private Button btnDashboard;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label14;
        private Label label3;
    }
}