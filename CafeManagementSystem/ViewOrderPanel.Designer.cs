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
            MenuPanel = new Panel();
            btnSales = new Button();
            btnOrders = new Button();
            btnBack = new Button();
            pnlNav = new Panel();
            btnPayment = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            panel = new Panel();
            btnRemove = new Button();
            label1 = new Label();
            cmbStatus = new ComboBox();
            btnUpdate = new Button();
            cmbFilter = new ComboBox();
            manageOrdersLabel = new Label();
            filterLabel = new Label();
            progressLabel = new Label();
            searchBarLabel = new TextBox();
            upperNavBar = new Panel();
            label2 = new Label();
            dgvOrders = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colTotalPrice = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            MenuPanel.SuspendLayout();
            panel.SuspendLayout();
            upperNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.SaddleBrown;
            MenuPanel.BorderStyle = BorderStyle.Fixed3D;
            MenuPanel.Controls.Add(btnSales);
            MenuPanel.Controls.Add(btnOrders);
            MenuPanel.Controls.Add(btnBack);
            MenuPanel.Controls.Add(pnlNav);
            MenuPanel.Controls.Add(btnPayment);
            MenuPanel.Controls.Add(btnProducts);
            MenuPanel.Controls.Add(btnDashboard);
            MenuPanel.Location = new Point(1, 54);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(120, 484);
            MenuPanel.TabIndex = 0;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.SaddleBrown;
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 11.25F);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(0, 126);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(116, 42);
            btnSales.TabIndex = 6;
            btnSales.Text = "SALES";
            btnSales.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Peru;
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = Color.White;
            btnOrders.Location = new Point(0, 84);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(116, 42);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "ORDERS";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SaddleBrown;
            btnBack.Dock = DockStyle.Bottom;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 438);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(116, 42);
            btnBack.TabIndex = 4;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.System;
            btnPayment.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnPayment.ForeColor = Color.Black;
            btnPayment.Location = new Point(0, 84);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(116, 46);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "CUSTOMERS";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.SaddleBrown;
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 11.25F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 42);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(116, 42);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.SaddleBrown;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11.25F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(116, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = Color.WhiteSmoke;
            panel.Controls.Add(dgvOrders);
            panel.Controls.Add(btnRemove);
            panel.Controls.Add(label1);
            panel.Controls.Add(cmbStatus);
            panel.Controls.Add(btnUpdate);
            panel.Controls.Add(cmbFilter);
            panel.Controls.Add(manageOrdersLabel);
            panel.Controls.Add(filterLabel);
            panel.Controls.Add(progressLabel);
            panel.Controls.Add(searchBarLabel);
            panel.Location = new Point(117, 54);
            panel.Name = "panel";
            panel.Size = new Size(712, 498);
            panel.TabIndex = 6;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Firebrick;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(541, 419);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(140, 40);
            btnRemove.TabIndex = 30;
            btnRemove.Text = "Remove Order";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(381, 69);
            label1.Name = "label1";
            label1.Size = new Size(84, 16);
            label1.TabIndex = 29;
            label1.Text = "Order Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "", "Preparing", "", "Ready", "", "Completed" });
            cmbStatus.Location = new Point(477, 66);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(220, 23);
            cmbStatus.TabIndex = 28;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Chocolate;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Peru;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(381, 419);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 40);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update Status";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.FlatStyle = FlatStyle.Flat;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(477, 37);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(220, 23);
            cmbFilter.TabIndex = 7;
            // 
            // manageOrdersLabel
            // 
            manageOrdersLabel.AutoSize = true;
            manageOrdersLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageOrdersLabel.ForeColor = Color.Black;
            manageOrdersLabel.Location = new Point(39, 9);
            manageOrdersLabel.Name = "manageOrdersLabel";
            manageOrdersLabel.Size = new Size(178, 30);
            manageOrdersLabel.TabIndex = 12;
            manageOrdersLabel.Text = "Customer Orders";
            manageOrdersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterLabel.ForeColor = Color.Black;
            filterLabel.Location = new Point(426, 40);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(39, 16);
            filterLabel.TabIndex = 9;
            filterLabel.Text = "Filter";
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
            // searchBarLabel
            // 
            searchBarLabel.BackColor = Color.White;
            searchBarLabel.BorderStyle = BorderStyle.FixedSingle;
            searchBarLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBarLabel.ForeColor = Color.Black;
            searchBarLabel.Location = new Point(477, 6);
            searchBarLabel.Name = "searchBarLabel";
            searchBarLabel.PlaceholderText = "Search orders";
            searchBarLabel.Size = new Size(220, 25);
            searchBarLabel.TabIndex = 6;
            // 
            // upperNavBar
            // 
            upperNavBar.BackColor = Color.WhiteSmoke;
            upperNavBar.BorderStyle = BorderStyle.Fixed3D;
            upperNavBar.Controls.Add(label2);
            upperNavBar.Location = new Point(1, 0);
            upperNavBar.Name = "upperNavBar";
            upperNavBar.Size = new Size(828, 57);
            upperNavBar.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(9, 7);
            label2.Name = "label2";
            label2.Size = new Size(224, 30);
            label2.TabIndex = 23;
            label2.Text = "Coffee Admin System";
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colProductName, colTotalPrice, colStatus, colCustomer });
            dgvOrders.Location = new Point(39, 142);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(658, 230);
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
            upperNavBar.ResumeLayout(false);
            upperNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;

        private Button btnDashboard;
        private Button btnPayment;
        private Button btnProducts;
        private Panel pnlNav;
        private Button btnBack;
        private Panel panel;
        private Panel upperNavBar;
        private Button btnOrders;
        private Button btnSales;
        private Label progressLabel;
        private ComboBox cmbFilter;
        private TextBox searchBarLabel;
        private Label filterLabel;
        private Label manageOrdersLabel;
        private Button btnUpdate;
        private Label label1;
        private ComboBox cmbStatus;
        private Label label2;
        private Button btnRemove;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colTotalPrice;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colCustomer;
    }
}