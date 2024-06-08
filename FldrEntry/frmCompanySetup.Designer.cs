namespace Custom_Dashboard_2.FldrEntry
{
    partial class frmCompanySetup
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
            panel1 = new Panel();
            label1 = new Label();
            iconButton44 = new FontAwesome.Sharp.IconButton();
            iconButton45 = new FontAwesome.Sharp.IconButton();
            customButton1 = new LIS.FldrCustomToolkit.CustomButton();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new LIS.FldrCustomToolkit.CustomTextbox();
            customTextbox1 = new LIS.FldrCustomToolkit.CustomTextbox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(127, 90, 240);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconButton44);
            panel1.Controls.Add(iconButton45);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 36);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 254);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 1;
            label1.Text = "Company Setup";
            // 
            // iconButton44
            // 
            iconButton44.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton44.FlatAppearance.BorderSize = 0;
            iconButton44.FlatStyle = FlatStyle.Flat;
            iconButton44.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconButton44.IconColor = Color.FromArgb(255, 255, 254);
            iconButton44.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton44.IconSize = 30;
            iconButton44.Location = new Point(385, 3);
            iconButton44.Name = "iconButton44";
            iconButton44.Size = new Size(40, 31);
            iconButton44.TabIndex = 7;
            iconButton44.UseVisualStyleBackColor = true;
            iconButton44.Click += iconButton44_Click;
            // 
            // iconButton45
            // 
            iconButton45.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton45.FlatAppearance.BorderSize = 0;
            iconButton45.FlatStyle = FlatStyle.Flat;
            iconButton45.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton45.IconColor = Color.FromArgb(255, 255, 254);
            iconButton45.IconFont = FontAwesome.Sharp.IconFont.Brands;
            iconButton45.IconSize = 30;
            iconButton45.Location = new Point(431, 3);
            iconButton45.Name = "iconButton45";
            iconButton45.Size = new Size(40, 31);
            iconButton45.TabIndex = 6;
            iconButton45.UseVisualStyleBackColor = true;
            iconButton45.Click += iconButton45_Click;
            // 
            // customButton1
            // 
            customButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customButton1.BackColor = Color.FromArgb(44, 182, 125);
            customButton1.BackgroundColor = Color.FromArgb(44, 182, 125);
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(306, 290);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 40);
            customButton1.TabIndex = 1;
            customButton1.Text = "UPDATE";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(22, 22, 26);
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 4;
            label2.Text = "Company Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(22, 22, 26);
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 6;
            label3.Text = "Address";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(255, 255, 254);
            txtUsername.BorderColor = Color.FromArgb(22, 22, 26);
            txtUsername.BorderFocusColor = Color.FromArgb(127, 90, 240);
            txtUsername.BorderSize = 1;
            txtUsername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(22, 22, 26);
            txtUsername.Location = new Point(12, 127);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(7);
            txtUsername.PasswordChar = true;
            txtUsername.Size = new Size(440, 30);
            txtUsername.TabIndex = 7;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = true;
            // 
            // customTextbox1
            // 
            customTextbox1.BackColor = Color.FromArgb(255, 255, 254);
            customTextbox1.BorderColor = Color.FromArgb(22, 22, 26);
            customTextbox1.BorderFocusColor = Color.FromArgb(127, 90, 240);
            customTextbox1.BorderSize = 1;
            customTextbox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customTextbox1.ForeColor = Color.FromArgb(22, 22, 26);
            customTextbox1.Location = new Point(16, 210);
            customTextbox1.Multiline = true;
            customTextbox1.Name = "customTextbox1";
            customTextbox1.Padding = new Padding(7);
            customTextbox1.PasswordChar = true;
            customTextbox1.Size = new Size(440, 30);
            customTextbox1.TabIndex = 8;
            customTextbox1.Texts = "";
            customTextbox1.UnderlinedStyle = true;
            // 
            // frmCompanySetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 254);
            ClientSize = new Size(473, 377);
            Controls.Add(customTextbox1);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(customButton1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCompanySetup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Setup";
            Load += frmCompanySetup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton44;
        private FontAwesome.Sharp.IconButton iconButton45;
        private Label label1;
        private LIS.FldrCustomToolkit.CustomButton customButton1;
        private Label label2;
        private Label label3;
        private LIS.FldrCustomToolkit.CustomTextbox txtUsername;
        private LIS.FldrCustomToolkit.CustomTextbox customTextbox1;
    }
}