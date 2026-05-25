namespace CafeManagementSystem
{
    partial class ViewOrderPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderPanel));
            MenuPanel = new Panel();
            btnSales = new Button();
            btnOrders = new Button();
            pnlNav = new Panel();
            btnPayment = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            panel = new Panel();
            lblTotalOrders = new Label();
            label4 = new Label();
            label3 = new Label();
            txtOrderSearch = new TextBox();
            dgvOrders = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colTotalPrice = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            btnRemove = new Button();
            label1 = new Label();
            cmbStatus = new ComboBox();
            btnUpdate = new Button();
            cmbOrderFilter = new ComboBox();
            manageOrdersLabel = new Label();
            filterLabel = new Label();
            progressLabel = new Label();
            upperNavBar = new Panel();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            MenuPanel.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            upperNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(43, 26, 18);
            MenuPanel.BorderStyle = BorderStyle.Fixed3D;
            MenuPanel.Controls.Add(btnSales);
            MenuPanel.Controls.Add(btnOrders);
            MenuPanel.Controls.Add(pnlNav);
            MenuPanel.Controls.Add(btnPayment);
            MenuPanel.Controls.Add(btnProducts);
            MenuPanel.Controls.Add(btnDashboard);
            MenuPanel.Location = new Point(1, 54);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(118, 484);
            MenuPanel.TabIndex = 0;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.FromArgb(43, 26, 18);
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.System;
            btnSales.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(0, 126);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(114, 42);
            btnSales.TabIndex = 6;
            btnSales.Text = "SALES";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Visible = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Peru;
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.System;
            btnOrders.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnOrders.ForeColor = Color.White;
            btnOrders.Location = new Point(0, 84);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(114, 42);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "ORDERS";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Black;
            pnlNav.Location = new Point(0, 160);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 3;
            // 
            // btnPayment
            // 
            btnPayment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPayment.BackColor = Color.FromArgb(43, 26, 18);
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.System;
            btnPayment.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnPayment.ForeColor = Color.Black;
            btnPayment.Location = new Point(0, 84);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(114, 46);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "CUSTOMERS";
            btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(43, 26, 18);
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.System;
            btnProducts.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 42);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(114, 42);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(43, 26, 18);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.System;
            btnDashboard.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(114, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = Color.FromArgb(243, 233, 220);
            panel.Controls.Add(lblTotalOrders);
            panel.Controls.Add(label4);
            panel.Controls.Add(label3);
            panel.Controls.Add(txtOrderSearch);
            panel.Controls.Add(dgvOrders);
            panel.Controls.Add(btnRemove);
            panel.Controls.Add(label1);
            panel.Controls.Add(cmbStatus);
            panel.Controls.Add(btnUpdate);
            panel.Controls.Add(cmbOrderFilter);
            panel.Controls.Add(manageOrdersLabel);
            panel.Controls.Add(filterLabel);
            panel.Controls.Add(progressLabel);
            panel.Location = new Point(117, 54);
            panel.Name = "panel";
            panel.Size = new Size(712, 498);
            panel.TabIndex = 6;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOrders.ForeColor = Color.Black;
            lblTotalOrders.Location = new Point(541, 107);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(119, 21);
            lblTotalOrders.TabIndex = 41;
            lblTotalOrders.Text = "Total Orders: 0";
            lblTotalOrders.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(125, 60);
            label4.Name = "label4";
            label4.Size = new Size(220, 15);
            label4.TabIndex = 40;
            label4.Text = "View and update customer coffee orders.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(381, 22);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 33;
            label3.Text = "Search:";
            // 
            // txtOrderSearch
            // 
            txtOrderSearch.BorderStyle = BorderStyle.FixedSingle;
            txtOrderSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderSearch.Location = new Point(477, 11);
            txtOrderSearch.Name = "txtOrderSearch";
            txtOrderSearch.Size = new Size(220, 27);
            txtOrderSearch.TabIndex = 32;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colProductName, colQuantity, colTotalPrice, colStatus, colCustomer });
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.GridColor = Color.Gainsboro;
            dgvOrders.Location = new Point(8, 142);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(689, 230);
            dgvOrders.TabIndex = 31;
            // 
            // colOrderId
            // 
            colOrderId.HeaderText = "Order ID";
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            // 
            // colProductName
            // 
            colProductName.HeaderText = " Product Name";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = " Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colTotalPrice
            // 
            colTotalPrice.HeaderText = "Total Price";
            colTotalPrice.Name = "colTotalPrice";
            colTotalPrice.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colCustomer
            // 
            colCustomer.HeaderText = "Customer";
            colCustomer.Name = "colCustomer";
            colCustomer.ReadOnly = true;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Firebrick;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(541, 419);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(140, 40);
            btnRemove.TabIndex = 30;
            btnRemove.Text = "Remove Order";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(381, 76);
            label1.Name = "label1";
            label1.Size = new Size(88, 16);
            label1.TabIndex = 29;
            label1.Text = "Order Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "", "Preparing", "", "Ready", "", "Completed" });
            cmbStatus.Location = new Point(477, 73);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(220, 23);
            cmbStatus.TabIndex = 28;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Peru;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Peru;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(381, 419);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 40);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update Status";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbOrderFilter
            // 
            cmbOrderFilter.FlatStyle = FlatStyle.Flat;
            cmbOrderFilter.FormattingEnabled = true;
            cmbOrderFilter.Location = new Point(477, 44);
            cmbOrderFilter.Name = "cmbOrderFilter";
            cmbOrderFilter.Size = new Size(220, 23);
            cmbOrderFilter.TabIndex = 7;
            // 
            // manageOrdersLabel
            // 
            manageOrdersLabel.AutoSize = true;
            manageOrdersLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageOrdersLabel.ForeColor = Color.Black;
            manageOrdersLabel.Location = new Point(130, 30);
            manageOrdersLabel.Name = "manageOrdersLabel";
            manageOrdersLabel.Size = new Size(205, 30);
            manageOrdersLabel.TabIndex = 12;
            manageOrdersLabel.Text = "Order Management";
            manageOrdersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterLabel.ForeColor = Color.Black;
            filterLabel.Location = new Point(381, 51);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(43, 16);
            filterLabel.TabIndex = 9;
            filterLabel.Text = "Filter:";
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            progressLabel.ForeColor = Color.Black;
            progressLabel.Location = new Point(361, 16);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(0, 21);
            progressLabel.TabIndex = 8;
            // 
            // upperNavBar
            // 
            upperNavBar.BackColor = Color.FromArgb(31, 26, 23);
            upperNavBar.BorderStyle = BorderStyle.Fixed3D;
            upperNavBar.Controls.Add(label5);
            upperNavBar.Controls.Add(pictureBox5);
            upperNavBar.Controls.Add(label2);
            upperNavBar.Location = new Point(1, 0);
            upperNavBar.Name = "upperNavBar";
            upperNavBar.Size = new Size(828, 63);
            upperNavBar.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(655, 23);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 25;
            label5.Text = "Coffee Shop Administrator";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 11);
            label2.Name = "label2";
            label2.Size = new Size(224, 30);
            label2.TabIndex = 23;
            label2.Text = "Coffee Admin System";
            // 
            // ViewOrderPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Black;
            ClientSize = new Size(828, 535);
            Controls.Add(upperNavBar);
            Controls.Add(panel);
            Controls.Add(MenuPanel);
            ForeColor = Color.BlanchedAlmond;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrderPanel";
            StartPosition = FormStartPosition.CenterScreen;
            MenuPanel.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            upperNavBar.ResumeLayout(false);
            upperNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;

        private Button btnDashboard;
        private Button btnPayment;
        private Button btnProducts;
        private Panel pnlNav;
        private Panel panel;
        private Panel upperNavBar;
        private Button btnOrders;
        private Button btnSales;
        private Label progressLabel;
        private ComboBox cmbOrderFilter;
        private Label filterLabel;
        private Label manageOrdersLabel;
        private Button btnUpdate;
        private Label label1;
        private ComboBox cmbStatus;
        private Label label2;
        private Button btnRemove;
        private DataGridView dgvOrders;
        private TextBox txtOrderSearch;
        private Label label3;
        private PictureBox pictureBox5;
        private Label label4;
        private Label label5;
        private Label lblTotalOrders;
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colTotalPrice;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colCustomer;
    }
}