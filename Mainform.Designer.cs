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
            btn_NhapHang = new Button();
            btn_NhaCungCap = new Button();
            btn_KhachHang = new Button();
            btn_BaoCao = new Button();
            btn_dangxuat = new Button();
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
            panel1.Controls.Add(btn_NhapHang);
            panel1.Controls.Add(btn_NhaCungCap);
            panel1.Controls.Add(btn_KhachHang);
            panel1.Controls.Add(btn_BaoCao);
            panel1.Controls.Add(btn_dangxuat);
            panel1.Controls.Add(btn_nhanvien);
            panel1.Controls.Add(btn_hanghoa);
            panel1.Controls.Add(btn_sell);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 782);
            panel1.TabIndex = 0;
            // 
            // btn_NhapHang
            // 
            btn_NhapHang.Cursor = Cursors.Hand;
            btn_NhapHang.FlatAppearance.BorderSize = 0;
            btn_NhapHang.FlatStyle = FlatStyle.Flat;
            btn_NhapHang.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_NhapHang.ForeColor = Color.White;
            btn_NhapHang.Image = (Image)resources.GetObject("btn_NhapHang.Image");
            btn_NhapHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NhapHang.Location = new Point(0, 619);
            btn_NhapHang.Name = "btn_NhapHang";
            btn_NhapHang.Size = new Size(250, 76);
            btn_NhapHang.TabIndex = 8;
            btn_NhapHang.Text = "Nhập Hàng";
            btn_NhapHang.UseVisualStyleBackColor = true;
            btn_NhapHang.Click += btn_NhapHang_Click;
            // 
            // btn_NhaCungCap
            // 
            btn_NhaCungCap.Cursor = Cursors.Hand;
            btn_NhaCungCap.FlatAppearance.BorderSize = 0;
            btn_NhaCungCap.FlatStyle = FlatStyle.Flat;
            btn_NhaCungCap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_NhaCungCap.ForeColor = Color.White;
            btn_NhaCungCap.Image = (Image)resources.GetObject("btn_NhaCungCap.Image");
            btn_NhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NhaCungCap.Location = new Point(0, 537);
            btn_NhaCungCap.Name = "btn_NhaCungCap";
            btn_NhaCungCap.Size = new Size(250, 76);
            btn_NhaCungCap.TabIndex = 7;
            btn_NhaCungCap.Text = "Nhà Cung Cấp";
            btn_NhaCungCap.UseVisualStyleBackColor = true;
            btn_NhaCungCap.Click += btn_NhaCungCap_Click;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.Cursor = Cursors.Hand;
            btn_KhachHang.FlatAppearance.BorderSize = 0;
            btn_KhachHang.FlatStyle = FlatStyle.Flat;
            btn_KhachHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_KhachHang.ForeColor = Color.White;
            btn_KhachHang.Image = (Image)resources.GetObject("btn_KhachHang.Image");
            btn_KhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KhachHang.Location = new Point(0, 455);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Size = new Size(250, 76);
            btn_KhachHang.TabIndex = 6;
            btn_KhachHang.Text = "Khách Hàng";
            btn_KhachHang.UseVisualStyleBackColor = true;
            btn_KhachHang.Click += btn_KhachHang_Click;
            // 
            // btn_BaoCao
            // 
            btn_BaoCao.Cursor = Cursors.Hand;
            btn_BaoCao.FlatAppearance.BorderSize = 0;
            btn_BaoCao.FlatStyle = FlatStyle.Flat;
            btn_BaoCao.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_BaoCao.ForeColor = Color.White;
            btn_BaoCao.Image = (Image)resources.GetObject("btn_BaoCao.Image");
            btn_BaoCao.ImageAlign = ContentAlignment.MiddleLeft;
            btn_BaoCao.Location = new Point(0, 373);
            btn_BaoCao.Name = "btn_BaoCao";
            btn_BaoCao.Size = new Size(250, 76);
            btn_BaoCao.TabIndex = 5;
            btn_BaoCao.Text = "Báo Cáo";
            btn_BaoCao.UseVisualStyleBackColor = true;
            btn_BaoCao.Click += btn_BaoCao_Click;
            // 
            // btn_dangxuat
            // 
            btn_dangxuat.Cursor = Cursors.Hand;
            btn_dangxuat.FlatAppearance.BorderSize = 0;
            btn_dangxuat.FlatStyle = FlatStyle.Flat;
            btn_dangxuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangxuat.ForeColor = Color.White;
            btn_dangxuat.Image = (Image)resources.GetObject("btn_dangxuat.Image");
            btn_dangxuat.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dangxuat.Location = new Point(0, 706);
            btn_dangxuat.Name = "btn_dangxuat";
            btn_dangxuat.Size = new Size(250, 76);
            btn_dangxuat.TabIndex = 4;
            btn_dangxuat.Text = "Đăng Xuất";
            btn_dangxuat.UseVisualStyleBackColor = true;
            btn_dangxuat.Click += btn_dangxuat_Click;
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
            panel_body.Size = new Size(1161, 782);
            panel_body.TabIndex = 1;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1411, 782);
            Controls.Add(panel_body);
            Controls.Add(panel1);
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mainform";
            FormClosing += Mainform_FormClosing;
            FormClosed += Mainform_FormClosed;
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
        private Button btn_dangxuat;
        private Button btn_NhapHang;
        private Button btn_NhaCungCap;
        private Button btn_KhachHang;
        private Button btn_BaoCao;
    }
}