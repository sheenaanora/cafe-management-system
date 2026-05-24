namespace CafeManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginPanel = new Panel();
            pictureBox2 = new PictureBox();
            loginButton = new Button();
            passwordTextarea = new TextBox();
            passwordLabel = new Label();
            usernameTextarea = new TextBox();
            usernameLabel = new Label();
            messageLabel = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.WhiteSmoke;
            loginPanel.Controls.Add(pictureBox2);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(passwordTextarea);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(usernameTextarea);
            loginPanel.Controls.Add(usernameLabel);
            loginPanel.Controls.Add(messageLabel);
            loginPanel.Location = new Point(204, 23);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(362, 486);
            loginPanel.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(143, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.SaddleBrown;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.Chocolate;
            loginButton.FlatAppearance.MouseOverBackColor = Color.Peru;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(88, 380);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(160, 40);
            loginButton.TabIndex = 15;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextarea
            // 
            passwordTextarea.BorderStyle = BorderStyle.FixedSingle;
            passwordTextarea.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextarea.Location = new Point(66, 271);
            passwordTextarea.Name = "passwordTextarea";
            passwordTextarea.Size = new Size(223, 27);
            passwordTextarea.TabIndex = 14;
            passwordTextarea.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.SaddleBrown;
            passwordLabel.Location = new Point(66, 250);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(88, 18);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password: ";
            // 
            // usernameTextarea
            // 
            usernameTextarea.BorderStyle = BorderStyle.FixedSingle;
            usernameTextarea.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextarea.Location = new Point(55, 194);
            usernameTextarea.Name = "usernameTextarea";
            usernameTextarea.Size = new Size(250, 27);
            usernameTextarea.TabIndex = 12;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.SaddleBrown;
            usernameLabel.Location = new Point(55, 173);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(88, 18);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username: ";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageLabel.ForeColor = Color.SaddleBrown;
            messageLabel.Location = new Point(41, 100);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(286, 24);
            messageLabel.TabIndex = 10;
            messageLabel.Text = "Coffee Shop Admin Login";
            messageLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(797, 531);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SaddleBrown;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Chocolate;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Peru;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(758, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(27, 24);
            btnExit.TabIndex = 17;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 531);
            Controls.Add(btnExit);
            Controls.Add(loginPanel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Panel loginPanel;
        private Button loginButton;
        private TextBox passwordTextarea;
        private Label passwordLabel;
        private TextBox usernameTextarea;
        private Label usernameLabel;
        private Label messageLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnExit;
    }
}