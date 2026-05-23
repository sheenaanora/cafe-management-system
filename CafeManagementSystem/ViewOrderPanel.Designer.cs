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
            BtnSales = new Button();
            BtnOrders = new Button();
            btnBack = new Button();
            pnlNav = new Panel();
            btnPayment = new Button();
            BtnProducts = new Button();
            BtnDashboard = new Button();
            panel = new Panel();
            BtnRemove = new Button();
            label1 = new Label();
            comboBoxOrderStatus = new ComboBox();
            BtnUpdate = new Button();
            scrollablePanel = new Panel();
            panel3 = new Panel();
            itemStatus = new Label();
            itemCustomer = new Label();
            itemID = new Label();
            itemPrice = new Label();
            itemName = new Label();
            selectFilterComboBox = new ComboBox();
            itemIDLabel = new Label();
            itemCustomerNameLabel = new Label();
            itemNameLabel = new Label();
            itemPicBoxLabel = new Label();
            itemPriceLabel = new Label();
            itemStatusLabel = new Label();
            manageOrdersLabel = new Label();
            filterLabel = new Label();
            progressLabel = new Label();
            searchBarLabel = new TextBox();
            upperNavBar = new Panel();
            label2 = new Label();
            MenuPanel.SuspendLayout();
            panel.SuspendLayout();
            scrollablePanel.SuspendLayout();
            panel3.SuspendLayout();
            upperNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.SaddleBrown;
            MenuPanel.BorderStyle = BorderStyle.Fixed3D;
            MenuPanel.Controls.Add(BtnSales);
            MenuPanel.Controls.Add(BtnOrders);
            MenuPanel.Controls.Add(btnBack);
            MenuPanel.Controls.Add(pnlNav);
            MenuPanel.Controls.Add(btnPayment);
            MenuPanel.Controls.Add(BtnProducts);
            MenuPanel.Controls.Add(BtnDashboard);
            MenuPanel.Location = new Point(1, 54);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(120, 484);
            MenuPanel.TabIndex = 0;
            // 
            // BtnSales
            // 
            BtnSales.BackColor = Color.SaddleBrown;
            BtnSales.Dock = DockStyle.Top;
            BtnSales.FlatAppearance.BorderSize = 0;
            BtnSales.FlatStyle = FlatStyle.Flat;
            BtnSales.Font = new Font("Segoe UI", 11.25F);
            BtnSales.ForeColor = Color.White;
            BtnSales.Location = new Point(0, 126);
            BtnSales.Name = "BtnSales";
            BtnSales.Size = new Size(116, 42);
            BtnSales.TabIndex = 6;
            BtnSales.Text = "SALES";
            BtnSales.UseVisualStyleBackColor = false;
            // 
            // BtnOrders
            // 
            BtnOrders.BackColor = Color.Peru;
            BtnOrders.Dock = DockStyle.Top;
            BtnOrders.FlatAppearance.BorderSize = 0;
            BtnOrders.FlatStyle = FlatStyle.Flat;
            BtnOrders.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnOrders.ForeColor = Color.White;
            BtnOrders.Location = new Point(0, 84);
            BtnOrders.Name = "BtnOrders";
            BtnOrders.Size = new Size(116, 42);
            BtnOrders.TabIndex = 5;
            BtnOrders.Text = "ORDERS";
            BtnOrders.UseVisualStyleBackColor = false;
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
            // BtnProducts
            // 
            BtnProducts.BackColor = Color.SaddleBrown;
            BtnProducts.Dock = DockStyle.Top;
            BtnProducts.FlatAppearance.BorderSize = 0;
            BtnProducts.FlatStyle = FlatStyle.Flat;
            BtnProducts.Font = new Font("Segoe UI", 11.25F);
            BtnProducts.ForeColor = Color.White;
            BtnProducts.Location = new Point(0, 42);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(116, 42);
            BtnProducts.TabIndex = 2;
            BtnProducts.Text = "PRODUCTS";
            BtnProducts.UseVisualStyleBackColor = false;
            // 
            // BtnDashboard
            // 
            BtnDashboard.BackColor = Color.SaddleBrown;
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Segoe UI", 11.25F);
            BtnDashboard.ForeColor = Color.White;
            BtnDashboard.Location = new Point(0, 0);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(116, 42);
            BtnDashboard.TabIndex = 1;
            BtnDashboard.Text = "DASHBOARD";
            BtnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = Color.WhiteSmoke;
            panel.Controls.Add(BtnRemove);
            panel.Controls.Add(label1);
            panel.Controls.Add(comboBoxOrderStatus);
            panel.Controls.Add(BtnUpdate);
            panel.Controls.Add(scrollablePanel);
            panel.Controls.Add(selectFilterComboBox);
            panel.Controls.Add(itemIDLabel);
            panel.Controls.Add(itemCustomerNameLabel);
            panel.Controls.Add(itemNameLabel);
            panel.Controls.Add(itemPicBoxLabel);
            panel.Controls.Add(itemPriceLabel);
            panel.Controls.Add(itemStatusLabel);
            panel.Controls.Add(manageOrdersLabel);
            panel.Controls.Add(filterLabel);
            panel.Controls.Add(progressLabel);
            panel.Controls.Add(searchBarLabel);
            panel.Location = new Point(117, 54);
            panel.Name = "panel";
            panel.Size = new Size(712, 498);
            panel.TabIndex = 6;
            // 
            // BtnRemove
            // 
            BtnRemove.BackColor = Color.Firebrick;
            BtnRemove.FlatAppearance.BorderSize = 0;
            BtnRemove.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            BtnRemove.FlatStyle = FlatStyle.Flat;
            BtnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnRemove.ForeColor = Color.White;
            BtnRemove.Location = new Point(541, 419);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(140, 40);
            BtnRemove.TabIndex = 30;
            BtnRemove.Text = "Remove Order";
            BtnRemove.UseVisualStyleBackColor = false;
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
            // comboBoxOrderStatus
            // 
            comboBoxOrderStatus.FlatStyle = FlatStyle.Flat;
            comboBoxOrderStatus.FormattingEnabled = true;
            comboBoxOrderStatus.Location = new Point(477, 66);
            comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            comboBoxOrderStatus.Size = new Size(220, 23);
            comboBoxOrderStatus.TabIndex = 28;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.Chocolate;
            BtnUpdate.FlatAppearance.BorderSize = 0;
            BtnUpdate.FlatAppearance.MouseOverBackColor = Color.Peru;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(381, 419);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(140, 40);
            BtnUpdate.TabIndex = 27;
            BtnUpdate.Text = "Update Status";
            BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
            scrollablePanel.BackColor = Color.White;
            scrollablePanel.BorderStyle = BorderStyle.FixedSingle;
            scrollablePanel.Controls.Add(panel3);
            scrollablePanel.Location = new Point(36, 165);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(661, 237);
            scrollablePanel.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(itemStatus);
            panel3.Controls.Add(itemCustomer);
            panel3.Controls.Add(itemID);
            panel3.Controls.Add(itemPrice);
            panel3.Controls.Add(itemName);
            panel3.Location = new Point(6, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(638, 65);
            panel3.TabIndex = 23;
            // 
            // itemStatus
            // 
            itemStatus.AutoSize = true;
            itemStatus.BackColor = Color.White;
            itemStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemStatus.ForeColor = Color.DarkOrange;
            itemStatus.Location = new Point(467, 18);
            itemStatus.Name = "itemStatus";
            itemStatus.Size = new Size(52, 15);
            itemStatus.TabIndex = 21;
            itemStatus.Text = "Pending";
            // 
            // itemCustomer
            // 
            itemCustomer.AutoSize = true;
            itemCustomer.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemCustomer.ForeColor = Color.Black;
            itemCustomer.Location = new Point(573, 14);
            itemCustomer.Name = "itemCustomer";
            itemCustomer.Size = new Size(51, 19);
            itemCustomer.TabIndex = 22;
            itemCustomer.Text = "Name";
            // 
            // itemID
            // 
            itemID.AutoSize = true;
            itemID.BackColor = Color.DimGray;
            itemID.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemID.ForeColor = Color.Black;
            itemID.Location = new Point(18, 14);
            itemID.Name = "itemID";
            itemID.Size = new Size(18, 19);
            itemID.TabIndex = 19;
            itemID.Text = "1";
            // 
            // itemPrice
            // 
            itemPrice.AutoSize = true;
            itemPrice.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemPrice.ForeColor = Color.Black;
            itemPrice.Location = new Point(355, 14);
            itemPrice.Name = "itemPrice";
            itemPrice.Size = new Size(51, 19);
            itemPrice.TabIndex = 20;
            itemPrice.Text = "Name";
            // 
            // itemName
            // 
            itemName.AutoSize = true;
            itemName.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemName.ForeColor = Color.Black;
            itemName.Location = new Point(215, 14);
            itemName.Name = "itemName";
            itemName.Size = new Size(51, 19);
            itemName.TabIndex = 19;
            itemName.Text = "Name";
            // 
            // selectFilterComboBox
            // 
            selectFilterComboBox.FlatStyle = FlatStyle.Flat;
            selectFilterComboBox.FormattingEnabled = true;
            selectFilterComboBox.Location = new Point(477, 37);
            selectFilterComboBox.Name = "selectFilterComboBox";
            selectFilterComboBox.Size = new Size(220, 23);
            selectFilterComboBox.TabIndex = 7;
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemIDLabel.ForeColor = Color.Black;
            itemIDLabel.Location = new Point(39, 143);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new Size(69, 19);
            itemIDLabel.TabIndex = 13;
            itemIDLabel.Text = "Order ID";
            // 
            // itemCustomerNameLabel
            // 
            itemCustomerNameLabel.AutoSize = true;
            itemCustomerNameLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemCustomerNameLabel.ForeColor = Color.Black;
            itemCustomerNameLabel.Location = new Point(600, 141);
            itemCustomerNameLabel.Name = "itemCustomerNameLabel";
            itemCustomerNameLabel.Size = new Size(81, 19);
            itemCustomerNameLabel.TabIndex = 18;
            itemCustomerNameLabel.Text = "Customer ";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemNameLabel.ForeColor = Color.Black;
            itemNameLabel.Location = new Point(230, 143);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(110, 19);
            itemNameLabel.TabIndex = 14;
            itemNameLabel.Text = "Product Name";
            // 
            // itemPicBoxLabel
            // 
            itemPicBoxLabel.AutoSize = true;
            itemPicBoxLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemPicBoxLabel.ForeColor = Color.Black;
            itemPicBoxLabel.Location = new Point(157, 143);
            itemPicBoxLabel.Name = "itemPicBoxLabel";
            itemPicBoxLabel.Size = new Size(42, 19);
            itemPicBoxLabel.TabIndex = 17;
            itemPicBoxLabel.Text = "Item";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemPriceLabel.ForeColor = Color.Black;
            itemPriceLabel.Location = new Point(382, 143);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(83, 19);
            itemPriceLabel.TabIndex = 16;
            itemPriceLabel.Text = "Total Price";
            // 
            // itemStatusLabel
            // 
            itemStatusLabel.AutoSize = true;
            itemStatusLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemStatusLabel.ForeColor = Color.Black;
            itemStatusLabel.Location = new Point(509, 141);
            itemStatusLabel.Name = "itemStatusLabel";
            itemStatusLabel.Size = new Size(53, 19);
            itemStatusLabel.TabIndex = 15;
            itemStatusLabel.Text = "Status";
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
            scrollablePanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            upperNavBar.ResumeLayout(false);
            upperNavBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;

        private Button BtnDashboard;
        private Button btnPayment;
        private Button BtnProducts;
        private Panel pnlNav;
        private Button btnBack;
        private Panel panel;
        private Panel upperNavBar;
        private Button BtnOrders;
        private Button BtnSales;
        private Label progressLabel;
        private ComboBox selectFilterComboBox;
        private TextBox searchBarLabel;
        private Label filterLabel;
        private Label manageOrdersLabel;
        private Label itemCustomerNameLabel;
        private Label itemNameLabel;
        private Label itemPicBoxLabel;
        private Label itemPriceLabel;
        private Label itemStatusLabel;
        private Label itemIDLabel;
        private Panel scrollablePanel;
        private Panel panel3;
        private Label itemStatus;
        private Label itemCustomer;
        private Label itemID;
        private Label itemPrice;
        private Label itemName;
        private Button BtnUpdate;
        private Label label1;
        private ComboBox comboBoxOrderStatus;
        private Label label2;
        private Button BtnRemove;
    }
}