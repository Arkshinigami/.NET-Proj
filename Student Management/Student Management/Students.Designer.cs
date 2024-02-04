namespace Student_Management
{
    partial class Students
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            panel1 = new Panel();
            StudentList = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            Deletebtn = new Button();
            Updatebtn = new Button();
            Addbtn = new Button();
            DepCb = new ComboBox();
            label7 = new Label();
            staddtb = new TextBox();
            label6 = new Label();
            stparenttb = new TextBox();
            label5 = new Label();
            stphonetb = new TextBox();
            label4 = new Label();
            gencb = new ComboBox();
            label3 = new Label();
            stnametb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label8 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            panel4 = new Panel();
            DashboardLb1 = new Label();
            DeptLb = new Label();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            panel6 = new Panel();
            logoutlb1 = new Label();
            pictureBox7 = new PictureBox();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(StudentList);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(254, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 742);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // StudentList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            StudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            StudentList.BackgroundColor = Color.Moccasin;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            StudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            StudentList.ColumnHeadersHeight = 30;
            StudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            StudentList.DefaultCellStyle = dataGridViewCellStyle3;
            StudentList.GridColor = Color.Navy;
            StudentList.Location = new Point(362, 47);
            StudentList.Name = "StudentList";
            StudentList.RowHeadersVisible = false;
            StudentList.RowTemplate.Height = 29;
            StudentList.Size = new Size(388, 663);
            StudentList.TabIndex = 4;
            StudentList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            StudentList.ThemeStyle.AlternatingRowsStyle.Font = null;
            StudentList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            StudentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            StudentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            StudentList.ThemeStyle.BackColor = Color.Moccasin;
            StudentList.ThemeStyle.GridColor = Color.Navy;
            StudentList.ThemeStyle.HeaderStyle.BackColor = Color.Orange;
            StudentList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            StudentList.ThemeStyle.HeaderStyle.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            StudentList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            StudentList.ThemeStyle.HeaderStyle.Height = 30;
            StudentList.ThemeStyle.ReadOnly = false;
            StudentList.ThemeStyle.RowsStyle.BackColor = Color.White;
            StudentList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            StudentList.ThemeStyle.RowsStyle.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            StudentList.ThemeStyle.RowsStyle.Height = 29;
            StudentList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            StudentList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            StudentList.CellContentClick += StudentList_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(746, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(Deletebtn);
            panel2.Controls.Add(Updatebtn);
            panel2.Controls.Add(Addbtn);
            panel2.Controls.Add(DepCb);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(staddtb);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(stparenttb);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(stphonetb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(gencb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(stnametb);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(20, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 662);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(108, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.DarkOrchid;
            Deletebtn.FlatStyle = FlatStyle.Flat;
            Deletebtn.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebtn.ForeColor = SystemColors.ActiveCaptionText;
            Deletebtn.Location = new Point(89, 596);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(133, 35);
            Deletebtn.TabIndex = 20;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.MediumTurquoise;
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Updatebtn.ForeColor = SystemColors.ActiveCaptionText;
            Updatebtn.Location = new Point(166, 555);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(133, 35);
            Updatebtn.TabIndex = 19;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.Orange;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Addbtn.ForeColor = SystemColors.ActiveCaptionText;
            Addbtn.Location = new Point(15, 555);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(133, 35);
            Addbtn.TabIndex = 18;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // DepCb
            // 
            DepCb.FormattingEnabled = true;
            DepCb.Items.AddRange(new object[] { "Male", "Female" });
            DepCb.Location = new Point(15, 497);
            DepCb.Name = "DepCb";
            DepCb.Size = new Size(207, 26);
            DepCb.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Orange;
            label7.Location = new Point(15, 471);
            label7.Name = "label7";
            label7.Size = new Size(185, 23);
            label7.TabIndex = 16;
            label7.Text = "Student Department";
            // 
            // staddtb
            // 
            staddtb.Location = new Point(15, 371);
            staddtb.Multiline = true;
            staddtb.Name = "staddtb";
            staddtb.Size = new Size(207, 72);
            staddtb.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(15, 345);
            label6.Name = "label6";
            label6.Size = new Size(150, 23);
            label6.TabIndex = 14;
            label6.Text = "Student Address";
            // 
            // stparenttb
            // 
            stparenttb.Location = new Point(15, 297);
            stparenttb.Name = "stparenttb";
            stparenttb.Size = new Size(207, 26);
            stparenttb.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(15, 274);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 12;
            label5.Text = " Parent's Name";
            // 
            // stphonetb
            // 
            stphonetb.Location = new Point(15, 240);
            stphonetb.Name = "stphonetb";
            stphonetb.Size = new Size(207, 26);
            stphonetb.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(15, 217);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 10;
            label4.Text = "Student Phone";
            // 
            // gencb
            // 
            gencb.FormattingEnabled = true;
            gencb.Items.AddRange(new object[] { "Male", "Female" });
            gencb.Location = new Point(15, 182);
            gencb.Name = "gencb";
            gencb.Size = new Size(207, 26);
            gencb.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(15, 159);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 8;
            label3.Text = "Student Gender";
            // 
            // stnametb
            // 
            stnametb.Location = new Point(15, 119);
            stnametb.Name = "stnametb";
            stnametb.Size = new Size(207, 26);
            stnametb.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(15, 93);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 6;
            label2.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 29);
            label1.TabIndex = 0;
            label1.Text = "Manage Students";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = Addbtn;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            guna2Elipse2.TargetControl = Updatebtn;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = Deletebtn;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Orange;
            label8.Location = new Point(62, 94);
            label8.Name = "label8";
            label8.Size = new Size(111, 23);
            label8.TabIndex = 21;
            label8.Text = "Student MS";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(62, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(103, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Moccasin;
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(-2, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 42);
            panel3.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(14, -2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(69, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DodgerBlue;
            label9.Location = new Point(151, 10);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 22;
            label9.Text = "Student ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOrange;
            panel4.Location = new Point(239, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(18, 43);
            panel4.TabIndex = 21;
            // 
            // DashboardLb1
            // 
            DashboardLb1.AutoSize = true;
            DashboardLb1.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DashboardLb1.ForeColor = Color.DodgerBlue;
            DashboardLb1.Location = new Point(135, 409);
            DashboardLb1.Name = "DashboardLb1";
            DashboardLb1.Size = new Size(103, 23);
            DashboardLb1.TabIndex = 23;
            DashboardLb1.Text = "Dashboard";
            DashboardLb1.Click += DashboardLb1_Click;
            // 
            // DeptLb
            // 
            DeptLb.AutoSize = true;
            DeptLb.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeptLb.ForeColor = Color.DodgerBlue;
            DeptLb.Location = new Point(135, 300);
            DeptLb.Name = "DeptLb";
            DeptLb.Size = new Size(113, 23);
            DeptLb.TabIndex = 24;
            DeptLb.Text = "Department";
            DeptLb.Click += Deptbtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 397);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 288);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(69, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Moccasin;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(logoutlb1);
            panel5.Controls.Add(pictureBox7);
            panel5.Location = new Point(-2, 658);
            panel5.Name = "panel5";
            panel5.Size = new Size(257, 42);
            panel5.TabIndex = 27;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkOrange;
            panel6.Location = new Point(239, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(18, 43);
            panel6.TabIndex = 21;
            // 
            // logoutlb1
            // 
            logoutlb1.AutoSize = true;
            logoutlb1.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            logoutlb1.ForeColor = Color.DodgerBlue;
            logoutlb1.Location = new Point(141, 11);
            logoutlb1.Name = "logoutlb1";
            logoutlb1.Size = new Size(69, 23);
            logoutlb1.TabIndex = 22;
            logoutlb1.Text = "Logout";
            logoutlb1.Click += logoutlb1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, -3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(69, 45);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 15;
            guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 15;
            guna2Elipse5.TargetControl = StudentList;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 742);
            Controls.Add(panel5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox6);
            Controls.Add(DashboardLb1);
            Controls.Add(DeptLb);
            Controls.Add(panel3);
            Controls.Add(pictureBox3);
            Controls.Add(label8);
            Controls.Add(panel1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Students_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox gencb;
        private Label label3;
        private TextBox stnametb;
        private Label label2;
        private ComboBox DepCb;
        private Label label7;
        private TextBox staddtb;
        private Label label6;
        private TextBox stparenttb;
        private Label label5;
        private TextBox stphonetb;
        private Label label4;
        private Button Addbtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Button Deletebtn;
        private Button Updatebtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label8;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Panel panel4;
        private Label label9;
        private Label DashboardLb1;
        private Label DeptLb;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Panel panel5;
        private Panel panel6;
        private Label logoutlb1;
        private PictureBox pictureBox7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2DataGridView StudentList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
    }
}