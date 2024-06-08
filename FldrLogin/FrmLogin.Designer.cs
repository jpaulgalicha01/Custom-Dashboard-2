namespace Custom_Dashboard_2
{
    partial class FrmLogin
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            txtPassword = new LIS.FldrCustomToolkit.CustomTextbox();
            label1 = new Label();
            txtUsername = new LIS.FldrCustomToolkit.CustomTextbox();
            btnLogin = new LIS.FldrCustomToolkit.CustomButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(22, 22, 26);
            iconPictureBox1.ForeColor = Color.FromArgb(127, 90, 240);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Circle;
            iconPictureBox1.IconColor = Color.FromArgb(127, 90, 240);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.IconSize = 759;
            iconPictureBox1.Location = new Point(-361, -116);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(912, 759);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(393, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 354);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 255, 254);
            label4.Location = new Point(102, 26);
            label4.Name = "label4";
            label4.Size = new Size(161, 22);
            label4.TabIndex = 7;
            label4.Text = "WELCOME USER";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(255, 255, 254);
            checkBox1.Location = new Point(23, 236);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(111, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 255, 254);
            label2.Location = new Point(23, 165);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(22, 22, 26);
            txtPassword.BorderColor = Color.FromArgb(255, 255, 254);
            txtPassword.BorderFocusColor = Color.FromArgb(127, 90, 240);
            txtPassword.BorderSize = 0;
            txtPassword.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(255, 255, 254);
            txtPassword.Location = new Point(23, 185);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(7);
            txtPassword.PasswordChar = false;
            txtPassword.Size = new Size(318, 30);
            txtPassword.TabIndex = 4;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 254);
            label1.Location = new Point(23, 81);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(22, 22, 26);
            txtUsername.BorderColor = Color.FromArgb(255, 255, 254);
            txtUsername.BorderFocusColor = Color.FromArgb(127, 90, 240);
            txtUsername.BorderSize = 0;
            txtUsername.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(255, 255, 254);
            txtUsername.Location = new Point(23, 101);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(7);
            txtUsername.PasswordChar = true;
            txtUsername.Size = new Size(318, 30);
            txtUsername.TabIndex = 1;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSlateBlue;
            btnLogin.BackgroundColor = Color.MediumSlateBlue;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(23, 272);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(318, 48);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.FromArgb(127, 90, 240);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Brands;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(724, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 31);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconButton2.IconColor = Color.FromArgb(127, 90, 240);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(678, 12);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(40, 31);
            iconButton2.TabIndex = 3;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 255, 254);
            label3.Location = new Point(731, 424);
            label3.Name = "label3";
            label3.Size = new Size(33, 17);
            label3.TabIndex = 7;
            label3.Text = "v1.0";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 26);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(panel1);
            Controls.Add(iconPictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel1;
        private LIS.FldrCustomToolkit.CustomTextbox txtUsername;
        private LIS.FldrCustomToolkit.CustomButton btnLogin;
        private Label label1;
        private Label label2;
        private LIS.FldrCustomToolkit.CustomTextbox txtPassword;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private CheckBox checkBox1;
        private Label label3;
        private Label label4;
    }
}