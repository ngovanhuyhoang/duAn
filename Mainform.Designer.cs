namespace DA1_formLogin
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            panel1 = new Panel();
            btn_nhanvien = new Button();
            btn_hanghoa = new Button();
            btn_sell = new Button();
            pictureBox1 = new PictureBox();
            panel_body = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 168, 242);
            panel1.Controls.Add(btn_nhanvien);
            panel1.Controls.Add(btn_hanghoa);
            panel1.Controls.Add(btn_sell);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 670);
            panel1.TabIndex = 0;
            // 
            // btn_nhanvien
            // 
            btn_nhanvien.Cursor = Cursors.Hand;
            btn_nhanvien.FlatAppearance.BorderSize = 0;
            btn_nhanvien.FlatStyle = FlatStyle.Flat;
            btn_nhanvien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nhanvien.ForeColor = Color.White;
            btn_nhanvien.Image = Properties.Resources.employee_man_alt__1_;
            btn_nhanvien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nhanvien.Location = new Point(0, 291);
            btn_nhanvien.Name = "btn_nhanvien";
            btn_nhanvien.Size = new Size(250, 76);
            btn_nhanvien.TabIndex = 3;
            btn_nhanvien.Text = "Nhân Viên";
            btn_nhanvien.UseVisualStyleBackColor = true;
            btn_nhanvien.Click += btn_nhanvien_Click;
            // 
            // btn_hanghoa
            // 
            btn_hanghoa.Cursor = Cursors.Hand;
            btn_hanghoa.FlatAppearance.BorderSize = 0;
            btn_hanghoa.FlatStyle = FlatStyle.Flat;
            btn_hanghoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_hanghoa.ForeColor = Color.White;
            btn_hanghoa.Image = (Image)resources.GetObject("btn_hanghoa.Image");
            btn_hanghoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_hanghoa.Location = new Point(0, 209);
            btn_hanghoa.Name = "btn_hanghoa";
            btn_hanghoa.Size = new Size(250, 76);
            btn_hanghoa.TabIndex = 2;
            btn_hanghoa.Text = "Hàng Hóa";
            btn_hanghoa.UseVisualStyleBackColor = true;
            btn_hanghoa.Click += btn_hanghoa_Click;
            // 
            // btn_sell
            // 
            btn_sell.Cursor = Cursors.Hand;
            btn_sell.FlatAppearance.BorderSize = 0;
            btn_sell.FlatStyle = FlatStyle.Flat;
            btn_sell.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sell.ForeColor = Color.White;
            btn_sell.Image = (Image)resources.GetObject("btn_sell.Image");
            btn_sell.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sell.Location = new Point(0, 127);
            btn_sell.Name = "btn_sell";
            btn_sell.Size = new Size(250, 76);
            btn_sell.TabIndex = 1;
            btn_sell.Text = "Bán Hàng";
            btn_sell.UseVisualStyleBackColor = true;
            btn_sell.Click += btn_sell_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.shop;
            pictureBox1.Location = new Point(0, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel_body
            // 
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(250, 0);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1149, 670);
            panel_body.TabIndex = 1;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1399, 670);
            Controls.Add(panel_body);
            Controls.Add(panel1);
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mainform";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_sell;
        private Button btn_nhanvien;
        private Button btn_hanghoa;
        private Panel panel_body;
    }
}