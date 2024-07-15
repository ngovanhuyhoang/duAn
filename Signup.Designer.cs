namespace DA1_formLogin
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txt_password_signup = new TextBox();
            pictureBox_password_signup = new PictureBox();
            lbl_password_signup = new Label();
            btn_loginhere = new Button();
            txtUsername_Signup = new TextBox();
            lbl_alreadyhave = new Label();
            signup_btnclose = new Button();
            btn_forgotpass = new Button();
            btn_signup = new Button();
            picture_signup_username = new PictureBox();
            pictureBox_email = new PictureBox();
            lbl_username_signup = new Label();
            txt_signup_email = new TextBox();
            lbl_email = new Label();
            lbl_getstarted = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_password_signup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_signup_username).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_email).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 74);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
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
            panel1.TabIndex = 1;
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
            panel2.Controls.Add(txt_password_signup);
            panel2.Controls.Add(pictureBox_password_signup);
            panel2.Controls.Add(lbl_password_signup);
            panel2.Controls.Add(btn_loginhere);
            panel2.Controls.Add(txtUsername_Signup);
            panel2.Controls.Add(lbl_alreadyhave);
            panel2.Controls.Add(signup_btnclose);
            panel2.Controls.Add(btn_forgotpass);
            panel2.Controls.Add(btn_signup);
            panel2.Controls.Add(picture_signup_username);
            panel2.Controls.Add(pictureBox_email);
            panel2.Controls.Add(lbl_username_signup);
            panel2.Controls.Add(txt_signup_email);
            panel2.Controls.Add(lbl_email);
            panel2.Controls.Add(lbl_getstarted);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 530);
            panel2.TabIndex = 2;
            // 
            // txt_password_signup
            // 
            txt_password_signup.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password_signup.ForeColor = Color.FromArgb(41, 128, 185);
            txt_password_signup.Location = new Point(60, 289);
            txt_password_signup.Name = "txt_password_signup";
            txt_password_signup.Size = new Size(368, 28);
            txt_password_signup.TabIndex = 17;
            txt_password_signup.UseSystemPasswordChar = true;
            // 
            // pictureBox_password_signup
            // 
            pictureBox_password_signup.BackColor = Color.White;
            pictureBox_password_signup.Image = (Image)resources.GetObject("pictureBox_password_signup.Image");
            pictureBox_password_signup.Location = new Point(28, 290);
            pictureBox_password_signup.Name = "pictureBox_password_signup";
            pictureBox_password_signup.Size = new Size(35, 27);
            pictureBox_password_signup.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_password_signup.TabIndex = 16;
            pictureBox_password_signup.TabStop = false;
            pictureBox_password_signup.MouseDown += pictureBox_password_signup_MouseDown;
            pictureBox_password_signup.MouseUp += pictureBox_password_signup_MouseUp;
            // 
            // lbl_password_signup
            // 
            lbl_password_signup.AutoSize = true;
            lbl_password_signup.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password_signup.ForeColor = Color.DimGray;
            lbl_password_signup.Location = new Point(28, 266);
            lbl_password_signup.Name = "lbl_password_signup";
            lbl_password_signup.Size = new Size(79, 20);
            lbl_password_signup.TabIndex = 15;
            lbl_password_signup.Text = "Password";
            // 
            // btn_loginhere
            // 
            btn_loginhere.BackColor = SystemColors.Control;
            btn_loginhere.FlatAppearance.BorderSize = 0;
            btn_loginhere.FlatStyle = FlatStyle.Flat;
            btn_loginhere.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_loginhere.ForeColor = Color.FromArgb(41, 128, 185);
            btn_loginhere.Location = new Point(247, 472);
            btn_loginhere.Name = "btn_loginhere";
            btn_loginhere.Size = new Size(137, 25);
            btn_loginhere.TabIndex = 14;
            btn_loginhere.Text = "Login here";
            btn_loginhere.UseVisualStyleBackColor = false;
            btn_loginhere.Click += btn_loginhere_Click;
            // 
            // txtUsername_Signup
            // 
            txtUsername_Signup.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername_Signup.ForeColor = Color.FromArgb(41, 128, 185);
            txtUsername_Signup.Location = new Point(60, 208);
            txtUsername_Signup.Name = "txtUsername_Signup";
            txtUsername_Signup.Size = new Size(368, 28);
            txtUsername_Signup.TabIndex = 13;
            // 
            // lbl_alreadyhave
            // 
            lbl_alreadyhave.AutoSize = true;
            lbl_alreadyhave.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_alreadyhave.ForeColor = Color.Silver;
            lbl_alreadyhave.Location = new Point(60, 476);
            lbl_alreadyhave.Name = "lbl_alreadyhave";
            lbl_alreadyhave.Size = new Size(181, 17);
            lbl_alreadyhave.TabIndex = 4;
            lbl_alreadyhave.Text = "Already have an account?";
            // 
            // signup_btnclose
            // 
            signup_btnclose.FlatAppearance.BorderSize = 0;
            signup_btnclose.FlatStyle = FlatStyle.Flat;
            signup_btnclose.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btnclose.ForeColor = Color.FromArgb(41, 128, 185);
            signup_btnclose.Location = new Point(405, 0);
            signup_btnclose.Name = "signup_btnclose";
            signup_btnclose.Size = new Size(35, 35);
            signup_btnclose.TabIndex = 12;
            signup_btnclose.Text = "X";
            signup_btnclose.UseVisualStyleBackColor = true;
            signup_btnclose.Click += signup_btnclose_Click;
            // 
            // btn_forgotpass
            // 
            btn_forgotpass.BackColor = SystemColors.Control;
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
            // btn_signup
            // 
            btn_signup.BackColor = Color.FromArgb(41, 128, 185);
            btn_signup.FlatStyle = FlatStyle.Flat;
            btn_signup.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signup.ForeColor = Color.White;
            btn_signup.Location = new Point(21, 345);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(148, 35);
            btn_signup.TabIndex = 10;
            btn_signup.Text = "SIGNUP";
            btn_signup.UseVisualStyleBackColor = false;
            // 
            // picture_signup_username
            // 
            picture_signup_username.BackColor = Color.White;
            picture_signup_username.Image = (Image)resources.GetObject("picture_signup_username.Image");
            picture_signup_username.Location = new Point(28, 133);
            picture_signup_username.Name = "picture_signup_username";
            picture_signup_username.Size = new Size(35, 27);
            picture_signup_username.SizeMode = PictureBoxSizeMode.Zoom;
            picture_signup_username.TabIndex = 9;
            picture_signup_username.TabStop = false;
            // 
            // pictureBox_email
            // 
            pictureBox_email.BackColor = Color.White;
            pictureBox_email.Image = (Image)resources.GetObject("pictureBox_email.Image");
            pictureBox_email.Location = new Point(28, 209);
            pictureBox_email.Name = "pictureBox_email";
            pictureBox_email.Size = new Size(35, 27);
            pictureBox_email.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_email.TabIndex = 4;
            pictureBox_email.TabStop = false;
            // 
            // lbl_username_signup
            // 
            lbl_username_signup.AutoSize = true;
            lbl_username_signup.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username_signup.ForeColor = Color.DimGray;
            lbl_username_signup.Location = new Point(28, 185);
            lbl_username_signup.Name = "lbl_username_signup";
            lbl_username_signup.Size = new Size(83, 20);
            lbl_username_signup.TabIndex = 7;
            lbl_username_signup.Text = "Username";
            // 
            // txt_signup_email
            // 
            txt_signup_email.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_signup_email.ForeColor = Color.FromArgb(41, 128, 185);
            txt_signup_email.Location = new Point(60, 132);
            txt_signup_email.Name = "txt_signup_email";
            txt_signup_email.Size = new Size(368, 28);
            txt_signup_email.TabIndex = 6;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.ForeColor = Color.DimGray;
            lbl_email.Location = new Point(28, 107);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(46, 20);
            lbl_email.TabIndex = 5;
            lbl_email.Text = "Email";
            // 
            // lbl_getstarted
            // 
            lbl_getstarted.AutoSize = true;
            lbl_getstarted.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_getstarted.ForeColor = Color.FromArgb(41, 128, 185);
            lbl_getstarted.Location = new Point(21, 65);
            lbl_getstarted.Name = "lbl_getstarted";
            lbl_getstarted.Size = new Size(122, 23);
            lbl_getstarted.TabIndex = 4;
            lbl_getstarted.Text = "Get started";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_password_signup).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_signup_username).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_email).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txt_password_signup;
        private PictureBox pictureBox_password_signup;
        private Label lbl_password_signup;
        private Button btn_loginhere;
        private TextBox txtUsername_Signup;
        private Label lbl_alreadyhave;
        private Button signup_btnclose;
        private Button btn_signup;
        private PictureBox picture_signup_username;
        private PictureBox pictureBox_email;
        private Label lbl_username_signup;
        private TextBox txt_signup_email;
        private Label lbl_email;
        private Label lbl_getstarted;
        private Button btn_forgotpass;
    }
}