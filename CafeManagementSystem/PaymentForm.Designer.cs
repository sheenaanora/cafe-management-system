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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            btnBack = new Button();
            addItemBtn = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            MenuPanel.SuspendLayout();
            scrollableMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            scrollableMenu.Controls.Add(label10);
            scrollableMenu.Controls.Add(label9);
            scrollableMenu.Controls.Add(label7);
            scrollableMenu.Controls.Add(label6);
            scrollableMenu.Controls.Add(label8);
            scrollableMenu.Controls.Add(btnBack);
            scrollableMenu.Controls.Add(addItemBtn);
            scrollableMenu.Controls.Add(label2);
            scrollableMenu.Controls.Add(dataGridView1);
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
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(17, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 180);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Chocolate;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 26);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 36;
            label3.Text = "Total Orders: 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Chocolate;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 81);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 37;
            label4.Text = "Total Revenue: ₱0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Chocolate;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 135);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 38;
            label5.Text = "Best Seller: None";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(609, 120);
            label10.Name = "label10";
            label10.Size = new Size(45, 19);
            label10.TabIndex = 43;
            label10.Text = "Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(523, 120);
            label9.Name = "label9";
            label9.Size = new Size(70, 19);
            label9.TabIndex = 42;
            label9.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(421, 120);
            label7.Name = "label7";
            label7.Size = new Size(64, 19);
            label7.TabIndex = 41;
            label7.Text = "Product";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(323, 120);
            label6.Name = "label6";
            label6.Size = new Size(77, 19);
            label6.TabIndex = 40;
            label6.Text = "Customer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(245, 120);
            label8.Name = "label8";
            label8.Size = new Size(42, 19);
            label8.TabIndex = 39;
            label8.Text = "Date";
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
            // addItemBtn
            // 
            addItemBtn.BackColor = Color.Chocolate;
            addItemBtn.FlatAppearance.BorderSize = 0;
            addItemBtn.FlatAppearance.MouseOverBackColor = Color.Peru;
            addItemBtn.FlatStyle = FlatStyle.Flat;
            addItemBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addItemBtn.ForeColor = Color.White;
            addItemBtn.Location = new Point(48, 364);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(140, 40);
            addItemBtn.TabIndex = 34;
            addItemBtn.Text = "Refresh Report";
            addItemBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(421, 78);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 12;
            label2.Text = "Sales Transactions";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SaddleBrown;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Peru;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.BlanchedAlmond;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(238, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(459, 382);
            dataGridView1.TabIndex = 11;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Panel pnlNav;
        private Panel scrollableMenu;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnBack;
        private Button addItemBtn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private Label label11;
    }
}