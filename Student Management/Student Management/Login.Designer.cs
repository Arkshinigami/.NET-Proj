namespace Student_Management
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Closebtn = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            Uname = new TextBox();
            Password = new TextBox();
            label3 = new Label();
            Loginbtn = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Resetbtn = new Label();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Closebtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 442);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Snow;
            label9.Location = new Point(45, 279);
            label9.Name = "label9";
            label9.Size = new Size(92, 18);
            label9.TabIndex = 14;
            label9.Text = "Student MS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(45, 182);
            label7.Name = "label7";
            label7.Size = new Size(154, 18);
            label7.TabIndex = 12;
            label7.Text = "Manage Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(45, 133);
            label6.Name = "label6";
            label6.Size = new Size(131, 18);
            label6.TabIndex = 11;
            label6.Text = "Manage Students";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(45, 85);
            label5.Name = "label5";
            label5.Size = new Size(92, 18);
            label5.TabIndex = 10;
            label5.Text = "Student MS";
            // 
            // Closebtn
            // 
            Closebtn.Image = (Image)resources.GetObject("Closebtn.Image");
            Closebtn.Location = new Point(681, 3);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(37, 38);
            Closebtn.SizeMode = PictureBoxSizeMode.Zoom;
            Closebtn.TabIndex = 1;
            Closebtn.TabStop = false;
            Closebtn.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(259, 12);
            label1.Name = "label1";
            label1.Size = new Size(377, 29);
            label1.TabIndex = 2;
            label1.Text = "Student Management System";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(370, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(272, 171);
            label2.Name = "label2";
            label2.Size = new Size(149, 29);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // Uname
            // 
            Uname.Location = new Point(272, 203);
            Uname.Name = "Uname";
            Uname.Size = new Size(316, 26);
            Uname.TabIndex = 5;
            // 
            // Password
            // 
            Password.Location = new Point(272, 288);
            Password.Name = "Password";
            Password.Size = new Size(316, 26);
            Password.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(272, 256);
            label3.Name = "label3";
            label3.Size = new Size(132, 29);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.DarkGray;
            Loginbtn.FlatStyle = FlatStyle.Flat;
            Loginbtn.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Loginbtn.ForeColor = SystemColors.ControlLight;
            Loginbtn.Location = new Point(370, 334);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(130, 49);
            Loginbtn.TabIndex = 8;
            Loginbtn.Text = "login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = Loginbtn;
            // 
            // Resetbtn
            // 
            Resetbtn.AutoSize = true;
            Resetbtn.Font = new Font("Georgia", 12F, FontStyle.Underline, GraphicsUnit.Point);
            Resetbtn.ForeColor = Color.DeepSkyBlue;
            Resetbtn.Location = new Point(408, 386);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(48, 18);
            Resetbtn.TabIndex = 9;
            Resetbtn.Text = "Reset";
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            guna2Elipse2.TargetControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(45, 230);
            label4.Name = "label4";
            label4.Size = new Size(131, 18);
            label4.TabIndex = 15;
            label4.Text = "Manage Students";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(730, 442);
            Controls.Add(Resetbtn);
            Controls.Add(Loginbtn);
            Controls.Add(Password);
            Controls.Add(label3);
            Controls.Add(Uname);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(Closebtn);
            Controls.Add(panel1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Closebtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox Closebtn;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox Uname;
        private TextBox Password;
        private Label label3;
        private Button Loginbtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label Resetbtn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label label4;
    }
}