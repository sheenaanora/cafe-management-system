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
            btnSales = new Button();
            btnOrders = new Button();
            pnlNav = new Panel();
            btnPayment = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            scrollableMenu = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            label14 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            MenuPanel.SuspendLayout();
            scrollableMenu.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
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
            MenuPanel.Location = new Point(1, 57);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(120, 480);
            MenuPanel.TabIndex = 0;
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
            // 
            // scrollableMenu
            // 
            scrollableMenu.AutoScroll = true;
            scrollableMenu.BackColor = Color.FromArgb(243, 233, 220);
            scrollableMenu.BorderStyle = BorderStyle.Fixed3D;
            scrollableMenu.Controls.Add(label1);
            scrollableMenu.Controls.Add(panel4);
            scrollableMenu.Controls.Add(panel3);
            scrollableMenu.Controls.Add(panel2);
            scrollableMenu.Location = new Point(119, 54);
            scrollableMenu.Name = "scrollableMenu";
            scrollableMenu.Size = new Size(710, 498);
            scrollableMenu.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
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
            panel4.Controls.Add(label6);
            panel4.Location = new Point(466, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(169, 111);
            panel4.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 2;
            label6.Text = "💰  Sales Revenue";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(44, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 111);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(27, 11);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(-4, 11);
            label5.Name = "label5";
            label5.Size = new Size(172, 23);
            label5.TabIndex = 1;
            label5.Text = "\U0001f6d2 Customer Orders";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(245, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(173, 111);
            panel3.TabIndex = 1;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Button btnSales;
        private Button btnOrders;
        private Button btnDashboard;
        private Panel panel4;
        private Label label6;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Label label5;
    }
}