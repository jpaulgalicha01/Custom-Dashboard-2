namespace Custom_Dashboard_2.FldFile
{
    partial class frmLoanSubtitle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            customButton4 = new LIS.FldrCustomToolkit.CustomButton();
            customButton2 = new LIS.FldrCustomToolkit.CustomButton();
            comboBox1 = new ComboBox();
            customTextbox2 = new LIS.FldrCustomToolkit.CustomTextbox();
            customTextbox1 = new LIS.FldrCustomToolkit.CustomTextbox();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            customButton5 = new LIS.FldrCustomToolkit.CustomButton();
            customButton3 = new LIS.FldrCustomToolkit.CustomButton();
            customButton1 = new LIS.FldrCustomToolkit.CustomButton();
            panel2 = new Panel();
            dgv1 = new DataGridView();
            CODE = new DataGridViewTextBoxColumn();
            SUBTITLE = new DataGridViewTextBoxColumn();
            VOUCHER = new DataGridViewTextBoxColumn();
            EDIT = new DataGridViewComboBoxColumn();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(29, 72);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1099, 548);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(customButton4);
            tabPage1.Controls.Add(customButton2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(customTextbox2);
            tabPage1.Controls.Add(customTextbox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1091, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // customButton4
            // 
            customButton4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customButton4.BackColor = Color.FromArgb(44, 182, 125);
            customButton4.BackgroundColor = Color.FromArgb(44, 182, 125);
            customButton4.BorderColor = Color.PaleVioletRed;
            customButton4.BorderRadius = 20;
            customButton4.BorderSize = 0;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(654, 344);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(107, 40);
            customButton4.TabIndex = 23;
            customButton4.Text = "SAVE";
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            customButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customButton2.BackColor = Color.FromArgb(44, 182, 125);
            customButton2.BackgroundColor = Color.FromArgb(44, 182, 125);
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 20;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(1235, 707);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(107, 40);
            customButton2.TabIndex = 22;
            customButton2.Text = "SAVE";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 255, 254);
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.FromArgb(22, 22, 26);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "", "SAMPLE1", "SAMPLE2", "SAMPLE3", "SAMPLE4", "SAMPLE5", "SAMPLE6", "SAMPLE7" });
            comboBox1.Location = new Point(321, 154);
            comboBox1.MaxDropDownItems = 5;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(440, 27);
            comboBox1.TabIndex = 21;
            // 
            // customTextbox2
            // 
            customTextbox2.BackColor = Color.FromArgb(255, 255, 254);
            customTextbox2.BorderColor = Color.FromArgb(22, 22, 26);
            customTextbox2.BorderFocusColor = Color.FromArgb(127, 90, 240);
            customTextbox2.BorderSize = 1;
            customTextbox2.Enabled = false;
            customTextbox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customTextbox2.ForeColor = Color.FromArgb(22, 22, 26);
            customTextbox2.Location = new Point(654, 51);
            customTextbox2.Multiline = true;
            customTextbox2.Name = "customTextbox2";
            customTextbox2.Padding = new Padding(7);
            customTextbox2.PasswordChar = true;
            customTextbox2.Size = new Size(107, 30);
            customTextbox2.TabIndex = 20;
            customTextbox2.Texts = "";
            customTextbox2.UnderlinedStyle = true;
            // 
            // customTextbox1
            // 
            customTextbox1.BackColor = Color.FromArgb(255, 255, 254);
            customTextbox1.BorderColor = Color.FromArgb(22, 22, 26);
            customTextbox1.BorderFocusColor = Color.FromArgb(127, 90, 240);
            customTextbox1.BorderSize = 1;
            customTextbox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customTextbox1.ForeColor = Color.FromArgb(22, 22, 26);
            customTextbox1.Location = new Point(321, 224);
            customTextbox1.Multiline = true;
            customTextbox1.Name = "customTextbox1";
            customTextbox1.Padding = new Padding(7);
            customTextbox1.PasswordChar = true;
            customTextbox1.Size = new Size(440, 30);
            customTextbox1.TabIndex = 18;
            customTextbox1.Texts = "";
            customTextbox1.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(22, 22, 26);
            label3.Location = new Point(324, 204);
            label3.Name = "label3";
            label3.Size = new Size(113, 19);
            label3.TabIndex = 16;
            label3.Text = "Loan Description";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(22, 22, 26);
            label2.Location = new Point(324, 124);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 15;
            label2.Text = "Loan Type";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customButton5);
            tabPage2.Controls.Add(customButton3);
            tabPage2.Controls.Add(customButton1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1091, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Edit";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customButton5
            // 
            customButton5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customButton5.BackColor = Color.FromArgb(44, 182, 125);
            customButton5.BackgroundColor = Color.FromArgb(44, 182, 125);
            customButton5.BorderColor = Color.PaleVioletRed;
            customButton5.BorderRadius = 20;
            customButton5.BorderSize = 0;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButton5.ForeColor = Color.White;
            customButton5.Location = new Point(978, 459);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(107, 40);
            customButton5.TabIndex = 23;
            customButton5.Text = "UPDATE";
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            customButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customButton3.BackColor = Color.FromArgb(114, 117, 126);
            customButton3.BackgroundColor = Color.FromArgb(114, 117, 126);
            customButton3.BorderColor = Color.PaleVioletRed;
            customButton3.BorderRadius = 20;
            customButton3.BorderSize = 0;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(509, 539);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(107, 38);
            customButton3.TabIndex = 21;
            customButton3.Text = "CANCEL";
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
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
            customButton1.Location = new Point(622, 539);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(107, 38);
            customButton1.TabIndex = 20;
            customButton1.Text = "UPDATE";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(127, 90, 240);
            panel2.Controls.Add(dgv1);
            panel2.Location = new Point(6, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 401);
            panel2.TabIndex = 0;
            // 
            // dgv1
            // 
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AllowUserToResizeColumns = false;
            dgv1.AllowUserToResizeRows = false;
            dgv1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv1.BackgroundColor = SystemColors.Control;
            dgv1.BorderStyle = BorderStyle.None;
            dgv1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(22, 22, 26);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(127, 90, 240);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { CODE, SUBTITLE, VOUCHER, EDIT });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(22, 22, 26);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(127, 90, 240);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv1.DefaultCellStyle = dataGridViewCellStyle5;
            dgv1.EnableHeadersVisualStyles = false;
            dgv1.GridColor = Color.FromArgb(148, 161, 178);
            dgv1.Location = new Point(0, 28);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 254);
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(22, 22, 26);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(127, 90, 240);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(255, 255, 254);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv1.RowTemplate.Height = 25;
            dgv1.ScrollBars = ScrollBars.Vertical;
            dgv1.Size = new Size(1079, 360);
            dgv1.TabIndex = 7;
            // 
            // CODE
            // 
            CODE.HeaderText = "CODE";
            CODE.Name = "CODE";
            CODE.ReadOnly = true;
            CODE.Visible = false;
            // 
            // SUBTITLE
            // 
            SUBTITLE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SUBTITLE.HeaderText = "SUBTITLE";
            SUBTITLE.Name = "SUBTITLE";
            SUBTITLE.ReadOnly = true;
            // 
            // VOUCHER
            // 
            VOUCHER.HeaderText = "VOUCHER";
            VOUCHER.Name = "VOUCHER";
            VOUCHER.ReadOnly = true;
            VOUCHER.Width = 250;
            // 
            // EDIT
            // 
            EDIT.HeaderText = "Column1";
            EDIT.Name = "EDIT";
            EDIT.ReadOnly = true;
            EDIT.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 22, 26);
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(173, 31);
            label1.TabIndex = 6;
            label1.Text = "Loan Subtitle";
            // 
            // frmLoanSubtitle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "frmLoanSubtitle";
            Size = new Size(1180, 753);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LIS.FldrCustomToolkit.CustomButton customButton2;
        private ComboBox comboBox1;
        private LIS.FldrCustomToolkit.CustomTextbox customTextbox2;
        private LIS.FldrCustomToolkit.CustomTextbox customTextbox1;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private LIS.FldrCustomToolkit.CustomButton customButton3;
        private LIS.FldrCustomToolkit.CustomButton customButton1;
        private Panel panel2;
        private DataGridView dgv1;
        private Label label1;
        private DataGridViewTextBoxColumn CODE;
        private DataGridViewTextBoxColumn SUBTITLE;
        private DataGridViewTextBoxColumn VOUCHER;
        private DataGridViewComboBoxColumn EDIT;
        private LIS.FldrCustomToolkit.CustomButton customButton4;
        private LIS.FldrCustomToolkit.CustomButton customButton5;
    }
}
