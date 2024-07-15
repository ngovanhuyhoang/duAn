namespace DA1_formLogin
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txt_password_login = new TextBox();
            pictureBox_password_Login = new PictureBox();
            label8 = new Label();
            btn_registerhere = new Button();
            lbl_donthaveacc = new Label();
            Login_btnclose = new Button();
            btn_forgotpass = new Button();
            btn_login = new Button();
            pictureBox_Username_Login = new PictureBox();
            txt_Login_Username = new TextBox();
            label5 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_password_Login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Username_Login).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 530);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(216, 476);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 3;
            label3.Text = "xxxxx ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(189, 459);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 2;
            label2.Text = "Develop By ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(83, 205);
            label4.Name = "label4";
            label4.Size = new Size(149, 34);
            label4.TabIndex = 1;
            label4.Text = "wellcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_password_login);
            panel2.Controls.Add(pictureBox_password_Login);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btn_registerhere);
            panel2.Controls.Add(lbl_donthaveacc);
            panel2.Controls.Add(Login_btnclose);
            panel2.Controls.Add(btn_forgotpass);
            panel2.Controls.Add(btn_login);
            panel2.Controls.Add(pictureBox_Username_Login);
            panel2.Controls.Add(txt_Login_Username);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 530);
            panel2.TabIndex = 3;
            // 
            // txt_password_login
            // 
            txt_password_login.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password_login.ForeColor = Color.FromArgb(41, 128, 185);
            txt_password_login.Location = new Point(60, 289);
            txt_password_login.Name = "txt_password_login";
            txt_password_login.Size = new Size(368, 28);
            txt_password_login.TabIndex = 17;
            txt_password_login.UseSystemPasswordChar = true;
            // 
            // pictureBox_password_Login
            // 
            pictureBox_password_Login.BackColor = Color.White;
            pictureBox_password_Login.Cursor = Cursors.Hand;
            pictureBox_password_Login.Image = (Image)resources.GetObject("pictureBox_password_Login.Image");
            pictureBox_password_Login.Location = new Point(28, 290);
            pictureBox_password_Login.Name = "pictureBox_password_Login";
            pictureBox_password_Login.Size = new Size(35, 27);
            pictureBox_password_Login.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_password_Login.TabIndex = 16;
            pictureBox_password_Login.TabStop = false;
            pictureBox_password_Login.MouseDown += pictureBox_password_Login_MouseDown;
            pictureBox_password_Login.MouseUp += pictureBox_password_Login_MouseUp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(28, 266);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 15;
            label8.Text = "Password";
            // 
            // btn_registerhere
            // 
            btn_registerhere.BackColor = SystemColors.Control;
            btn_registerhere.Cursor = Cursors.Hand;
            btn_registerhere.FlatAppearance.BorderSize = 0;
            btn_registerhere.FlatStyle = FlatStyle.Flat;
            btn_registerhere.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_registerhere.ForeColor = Color.FromArgb(41, 128, 185);
            btn_registerhere.Location = new Point(247, 472);
            btn_registerhere.Name = "btn_registerhere";
            btn_registerhere.Size = new Size(137, 25);
            btn_registerhere.TabIndex = 14;
            btn_registerhere.Text = "Register here";
            btn_registerhere.UseVisualStyleBackColor = false;
            btn_registerhere.Click += btn_registerhere_Click;
            // 
            // lbl_donthaveacc
            // 
            lbl_donthaveacc.AutoSize = true;
            lbl_donthaveacc.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_donthaveacc.ForeColor = Color.Silver;
            lbl_donthaveacc.Location = new Point(60, 476);
            lbl_donthaveacc.Name = "lbl_donthaveacc";
            lbl_donthaveacc.Size = new Size(168, 17);
            lbl_donthaveacc.TabIndex = 4;
            lbl_donthaveacc.Text = "Don't have an account?";
            // 
            // Login_btnclose
            // 
            Login_btnclose.FlatAppearance.BorderSize = 0;
            Login_btnclose.FlatStyle = FlatStyle.Flat;
            Login_btnclose.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_btnclose.ForeColor = Color.FromArgb(41, 128, 185);
            Login_btnclose.Location = new Point(405, 0);
            Login_btnclose.Name = "Login_btnclose";
            Login_btnclose.Size = new Size(35, 35);
            Login_btnclose.TabIndex = 12;
            Login_btnclose.Text = "X";
            Login_btnclose.UseVisualStyleBackColor = true;
            Login_btnclose.Click += Login_btnclose_Click;
            // 
            // btn_forgotpass
            // 
            btn_forgotpass.BackColor = SystemColors.Control;
            btn_forgotpass.Cursor = Cursors.Hand;
            btn_forgotpass.FlatAppearance.BorderSize = 0;
            btn_forgotpass.FlatStyle = FlatStyle.Flat;
            btn_forgotpass.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_forgotpass.ForeColor = Color.FromArgb(41, 128, 185);
            btn_forgotpass.Location = new Point(189, 352);
            btn_forgotpass.Name = "btn_forgotpass";
            btn_forgotpass.Size = new Size(137, 25);
            btn_forgotpass.TabIndex = 11;
            btn_forgotpass.Text = "Forgot Password ?";
            btn_forgotpass.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(41, 128, 185);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(21, 345);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(148, 35);
            btn_login.TabIndex = 10;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox_Username_Login
            // 
            pictureBox_Username_Login.BackColor = Color.White;
            pictureBox_Username_Login.Image = (Image)resources.GetObject("pictureBox_Username_Login.Image");
            pictureBox_Username_Login.Location = new Point(28, 214);
            pictureBox_Username_Login.Name = "pictureBox_Username_Login";
            pictureBox_Username_Login.Size = new Size(35, 27);
            pictureBox_Username_Login.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Username_Login.TabIndex = 4;
            pictureBox_Username_Login.TabStop = false;
            // 
            // txt_Login_Username
            // 
            txt_Login_Username.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Login_Username.ForeColor = Color.FromArgb(41, 128, 185);
            txt_Login_Username.Location = new Point(60, 213);
            txt_Login_Username.Name = "txt_Login_Username";
            txt_Login_Username.Size = new Size(368, 28);
            txt_Login_Username.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(28, 188);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 5;
            label5.Text = "User name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(41, 128, 185);
            label9.Location = new Point(21, 65);
            label9.Name = "label9";
            label9.Size = new Size(198, 23);
            label9.TabIndex = 4;
            label9.Text = "Login your account";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 530);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_password_Login).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Username_Login).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txt_password_login;
        private PictureBox pictureBox_password_Login;
        private Label label8;
        private Button btn_registerhere;
        private Label lbl_donthaveacc;
        private Button Login_btnclose;
        private Button btn_forgotpass;
        private Button btn_login;
        private PictureBox pictureBox_Username_Login;
        private TextBox txt_Login_Username;
        private Label label5;
        private Label label9;
    }
}