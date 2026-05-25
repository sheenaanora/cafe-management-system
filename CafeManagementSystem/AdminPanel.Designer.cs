namespace CafeManagementSystem
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            MenuPanel = new Panel();
            btnLogout = new Button();
            btnOrders = new Button();
            pnlNav = new Panel();
            btnPayment = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            scrollableMenu = new Panel();
            label9 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            label14 = new Label();
            label3 = new Label();
            btnSales = new Button();
            MenuPanel.SuspendLayout();
            scrollableMenu.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(43, 26, 18);
            MenuPanel.BorderStyle = BorderStyle.Fixed3D;
            MenuPanel.Controls.Add(btnLogout);
            MenuPanel.Controls.Add(btnSales);
            MenuPanel.Controls.Add(btnOrders);
            MenuPanel.Controls.Add(pnlNav);
            MenuPanel.Controls.Add(btnPayment);
            MenuPanel.Controls.Add(btnProducts);
            MenuPanel.Controls.Add(btnDashboard);
            MenuPanel.Location = new Point(1, 57);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(120, 480);
            MenuPanel.TabIndex = 0;
            MenuPanel.Paint += MenuPanel_Paint;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Peru;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.SandyBrown;
            btnLogout.FlatStyle = FlatStyle.System;
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 430);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(116, 45);
            btnLogout.TabIndex = 39;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
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
            btnOrders.Size = new Size(116, 42);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "ORDERS";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
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
            btnPayment.Size = new Size(116, 42);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "CUSTOMERS";
            btnPayment.UseVisualStyleBackColor = true;
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
            btnProducts.Size = new Size(116, 42);
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
            btnDashboard.Size = new Size(116, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // scrollableMenu
            // 
            scrollableMenu.AutoScroll = true;
            scrollableMenu.BackColor = Color.FromArgb(243, 233, 220);
            scrollableMenu.BorderStyle = BorderStyle.Fixed3D;
            scrollableMenu.Controls.Add(label9);
            scrollableMenu.Controls.Add(label1);
            scrollableMenu.Controls.Add(panel4);
            scrollableMenu.Controls.Add(panel3);
            scrollableMenu.Controls.Add(panel2);
            scrollableMenu.Location = new Point(119, 54);
            scrollableMenu.Name = "scrollableMenu";
            scrollableMenu.Size = new Size(710, 498);
            scrollableMenu.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(176, 45);
            label9.Name = "label9";
            label9.Size = new Size(328, 15);
            label9.TabIndex = 2;
            label9.Text = "Manage products, orders, and sales in one admin dashboard.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(220, 20);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 3;
            label1.Text = "Dashboard Overview";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(487, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 130);
            panel4.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(65, 55);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 2;
            label7.Text = "₱0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 10);
            label6.Name = "label6";
            label6.Size = new Size(169, 25);
            label6.TabIndex = 2;
            label6.Text = "💰  Sales Revenue";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(254, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 130);
            panel3.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(80, 55);
            label8.Name = "label8";
            label8.Size = new Size(23, 25);
            label8.TabIndex = 3;
            label8.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(-5, 11);
            label5.Name = "label5";
            label5.Size = new Size(190, 25);
            label5.TabIndex = 1;
            label5.Text = "\U0001f6d2 Customer Orders";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(39, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 130);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(84, 55);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(27, 11);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 0;
            label4.Text = "☕  Products";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 26, 23);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 63);
            panel1.TabIndex = 7;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 8);
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
            label14.Location = new Point(58, 13);
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
            label3.Location = new Point(657, 23);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 6;
            label3.Text = "Coffee Shop Administrator";
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
            btnSales.Size = new Size(116, 42);
            btnSales.TabIndex = 6;
            btnSales.Text = "SALES";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Visible = false;
            btnSales.Click += btnSales_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Black;
            ClientSize = new Size(828, 535);
            Controls.Add(panel1);
            Controls.Add(scrollableMenu);
            Controls.Add(MenuPanel);
            ForeColor = Color.BlanchedAlmond;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MenuPanel.ResumeLayout(false);
            scrollableMenu.ResumeLayout(false);
            scrollableMenu.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Button btnPayment;
        private Button btnProducts;
        private Panel pnlNav;
        private Panel scrollableMenu;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label14;
        private PictureBox pictureBox5;
        private Button btnOrders;
        private Button btnDashboard;
        private Panel panel4;
        private Label label6;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label2;
        private Label label9;
        private Button btnLogout;
        private Button btnSales;
    }
}