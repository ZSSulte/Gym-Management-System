namespace Gym
{
    partial class Payment
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            AmountTb = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            Period = new DateTimePicker();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label11 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            NameCb = new ComboBox();
            PaymentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label7 = new Label();
            SearchName = new Guna.UI2.WinForms.Guna2TextBox();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(891, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 32);
            label3.TabIndex = 7;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(370, 43);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 33);
            label2.TabIndex = 6;
            label2.Text = "PAYMENTS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(348, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 5;
            label1.Text = "LARRA GAINS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(44, 279);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 22);
            label5.TabIndex = 34;
            label5.Text = "Amount";
            // 
            // AmountTb
            // 
            AmountTb.CustomizableEdges = customizableEdges1;
            AmountTb.DefaultText = "";
            AmountTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            AmountTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            AmountTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            AmountTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            AmountTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            AmountTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTb.ForeColor = Color.Crimson;
            AmountTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            AmountTb.Location = new Point(44, 305);
            AmountTb.Margin = new Padding(4, 4, 4, 4);
            AmountTb.Name = "AmountTb";
            AmountTb.PasswordChar = '\0';
            AmountTb.PlaceholderText = "";
            AmountTb.SelectedText = "";
            AmountTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AmountTb.Size = new Size(235, 37);
            AmountTb.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(44, 196);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 22);
            label4.TabIndex = 32;
            label4.Text = "Member Name";
            // 
            // Period
            // 
            Period.CalendarForeColor = Color.Crimson;
            Period.CalendarMonthBackground = Color.Crimson;
            Period.CalendarTitleBackColor = Color.Crimson;
            Period.CalendarTitleForeColor = Color.Crimson;
            Period.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Period.Format = DateTimePickerFormat.Custom;
            Period.Location = new Point(44, 163);
            Period.Margin = new Padding(2);
            Period.Name = "Period";
            Period.Size = new Size(149, 31);
            Period.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(44, 120);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 22);
            label6.TabIndex = 36;
            label6.Text = "Payment Month";
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(106, 401);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(114, 45);
            button3.TabIndex = 43;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(166, 349);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(100, 45);
            button2.TabIndex = 42;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(58, 349);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(100, 45);
            button1.TabIndex = 44;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(370, 542);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(237, 21);
            label11.TabIndex = 48;
            label11.Text = "Contact:fafajela@gmail.com";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(383, 521);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(208, 21);
            label10.TabIndex = 47;
            label10.Text = "DeveloppedByLarraGains";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(408, 77);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // NameCb
            // 
            NameCb.BackColor = Color.WhiteSmoke;
            NameCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameCb.ForeColor = Color.Crimson;
            NameCb.FormattingEnabled = true;
            NameCb.Items.AddRange(new object[] { "6am-8am", "8am-10am", "6pm-8pm", "8pm-10pm" });
            NameCb.Location = new Point(44, 238);
            NameCb.Margin = new Padding(2);
            NameCb.Name = "NameCb";
            NameCb.Size = new Size(235, 29);
            NameCb.TabIndex = 50;
            // 
            // PaymentDGV
            // 
            PaymentDGV.AllowUserToAddRows = false;
            PaymentDGV.AllowUserToResizeColumns = false;
            PaymentDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            PaymentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PaymentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PaymentDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            PaymentDGV.DefaultCellStyle = dataGridViewCellStyle3;
            PaymentDGV.GridColor = Color.FromArgb(231, 229, 255);
            PaymentDGV.Location = new Point(316, 221);
            PaymentDGV.Margin = new Padding(2);
            PaymentDGV.Name = "PaymentDGV";
            PaymentDGV.ReadOnly = true;
            PaymentDGV.RowHeadersVisible = false;
            PaymentDGV.RowTemplate.Height = 25;
            PaymentDGV.ShowEditingIcon = false;
            PaymentDGV.Size = new Size(545, 298);
            PaymentDGV.TabIndex = 51;
            PaymentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.Crimson;
            PaymentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            PaymentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            PaymentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            PaymentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            PaymentDGV.ThemeStyle.BackColor = Color.White;
            PaymentDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            PaymentDGV.ThemeStyle.HeaderStyle.BackColor = Color.Crimson;
            PaymentDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            PaymentDGV.ThemeStyle.HeaderStyle.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentDGV.ThemeStyle.HeaderStyle.ForeColor = Color.Crimson;
            PaymentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PaymentDGV.ThemeStyle.HeaderStyle.Height = 30;
            PaymentDGV.ThemeStyle.ReadOnly = true;
            PaymentDGV.ThemeStyle.RowsStyle.BackColor = Color.Crimson;
            PaymentDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PaymentDGV.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentDGV.ThemeStyle.RowsStyle.ForeColor = Color.Crimson;
            PaymentDGV.ThemeStyle.RowsStyle.Height = 25;
            PaymentDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.Crimson;
            PaymentDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.Crimson;
            PaymentDGV.CellContentClick += PaymentDGV_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(513, 139);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(149, 33);
            label7.TabIndex = 52;
            label7.Text = "PAYMENTS";
            // 
            // SearchName
            // 
            SearchName.CustomizableEdges = customizableEdges3;
            SearchName.DefaultText = "";
            SearchName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchName.ForeColor = Color.Crimson;
            SearchName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchName.Location = new Point(363, 176);
            SearchName.Margin = new Padding(4, 4, 4, 4);
            SearchName.Name = "SearchName";
            SearchName.PasswordChar = '\0';
            SearchName.PlaceholderText = "";
            SearchName.SelectedText = "";
            SearchName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SearchName.Size = new Size(235, 37);
            SearchName.TabIndex = 53;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(604, 173);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(100, 41);
            button4.TabIndex = 54;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(712, 173);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(100, 41);
            button5.TabIndex = 55;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 572);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(SearchName);
            Controls.Add(label7);
            Controls.Add(PaymentDGV);
            Controls.Add(NameCb);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(Period);
            Controls.Add(label5);
            Controls.Add(AmountTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox AmountTb;
        private Label label4;
        private DateTimePicker Period;
        private Label label6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox1;
        private ComboBox NameCb;
        private Guna.UI2.WinForms.Guna2DataGridView PaymentDGV;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox SearchName;
        private Button button4;
        private Button button5;
    }
}