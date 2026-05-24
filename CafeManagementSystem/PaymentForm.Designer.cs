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
            MenuPanel = new Panel();
            pnlNav = new Panel();
            scrollableMenu = new Panel();
            label11 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblTotalOrders = new Label();
            lblTotalRevenue = new Label();
            lblBestSeller = new Label();
            btnBack = new Button();
            btnRefresh = new Button();
            label2 = new Label();
            dgvSales = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            colProduct = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            MenuPanel.SuspendLayout();
            scrollableMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.SaddleBrown;
            MenuPanel.Controls.Add(pnlNav);
            MenuPanel.Location = new Point(33, 48);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(85, 489);
            MenuPanel.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Chocolate;
            pnlNav.Location = new Point(0, 160);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 3;
            // 
            // scrollableMenu
            // 
            scrollableMenu.AutoScroll = true;
            scrollableMenu.BackColor = Color.WhiteSmoke;
            scrollableMenu.Controls.Add(label11);
            scrollableMenu.Controls.Add(panel1);
            scrollableMenu.Controls.Add(btnBack);
            scrollableMenu.Controls.Add(btnRefresh);
            scrollableMenu.Controls.Add(label2);
            scrollableMenu.Controls.Add(dgvSales);
            scrollableMenu.Controls.Add(label1);
            scrollableMenu.Font = new Font("Microsoft Sans Serif", 8.25F);
            scrollableMenu.Location = new Point(119, 48);
            scrollableMenu.Name = "scrollableMenu";
            scrollableMenu.Size = new Size(708, 486);
            scrollableMenu.TabIndex = 6;
            scrollableMenu.Paint += scrollableMenu_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.System;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Peru;
            label11.Location = new Point(385, 46);
            label11.Name = "label11";
            label11.Size = new Size(191, 15);
            label11.TabIndex = 44;
            label11.Text = "Daily Coffee Shop Sales Monitoring";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblTotalOrders);
            panel1.Controls.Add(lblTotalRevenue);
            panel1.Controls.Add(lblBestSeller);
            panel1.Location = new Point(17, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 210);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chocolate;
            panel2.Location = new Point(0, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 100);
            panel2.TabIndex = 3;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.BackColor = Color.Chocolate;
            lblTotalOrders.FlatStyle = FlatStyle.System;
            lblTotalOrders.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOrders.ForeColor = Color.White;
            lblTotalOrders.Location = new Point(30, 38);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(112, 20);
            lblTotalOrders.TabIndex = 36;
            lblTotalOrders.Text = "Total Orders: 0";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.BackColor = Color.Chocolate;
            lblTotalRevenue.FlatStyle = FlatStyle.System;
            lblTotalRevenue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenue.ForeColor = Color.White;
            lblTotalRevenue.Location = new Point(13, 107);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(157, 20);
            lblTotalRevenue.TabIndex = 37;
            lblTotalRevenue.Text = "Total Revenue: ₱0.00";
            // 
            // lblBestSeller
            // 
            lblBestSeller.AutoSize = true;
            lblBestSeller.BackColor = Color.Chocolate;
            lblBestSeller.FlatStyle = FlatStyle.System;
            lblBestSeller.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBestSeller.ForeColor = Color.White;
            lblBestSeller.Location = new Point(30, 169);
            lblBestSeller.Name = "lblBestSeller";
            lblBestSeller.Size = new Size(129, 20);
            lblBestSeller.TabIndex = 38;
            lblBestSeller.Text = "Best Seller: None";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SaddleBrown;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(48, 420);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Chocolate;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.Peru;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(48, 364);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 40);
            btnRefresh.TabIndex = 34;
            btnRefresh.Text = "Refresh Report";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(411, 73);
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
            dgvSales.BorderStyle = BorderStyle.None;
            dgvSales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SaddleBrown;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { colDate, colCustomer, colProduct, colQuantity, colTotal });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Peru;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.BlanchedAlmond;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSales.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSales.EnableHeadersVisualStyles = false;
            dgvSales.GridColor = Color.Gainsboro;
            dgvSales.Location = new Point(207, 96);
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
            label1.Location = new Point(392, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 40);
            label1.TabIndex = 9;
            label1.Text = "Sales Report";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(828, 535);
            Controls.Add(scrollableMenu);
            Controls.Add(MenuPanel);
            ForeColor = Color.BlanchedAlmond;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MenuPanel.ResumeLayout(false);
            scrollableMenu.ResumeLayout(false);
            scrollableMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Panel pnlNav;
        private Panel scrollableMenu;
        private Label label1;
        private Label label2;
        private DataGridView dgvSales;
        private Button btnBack;
        private Button btnRefresh;
        private Label lblBestSeller;
        private Label lblTotalRevenue;
        private Label lblTotalOrders;
        private Panel panel1;
        private Panel panel2;
        private Label label11;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colTotal;
    }
}