namespace DA1_formLogin
{
    partial class Form_ChiTietSanPham
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
            grb_thongtinsp = new GroupBox();
            cbb_km1 = new ComboBox();
            cbb_nhacungcap = new ComboBox();
            cbb_thuonghieu = new ComboBox();
            cbb_danhmuc = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            grB_chucnag = new GroupBox();
            btn_sua = new Button();
            btn_them = new Button();
            label2 = new Label();
            txt_soluong = new TextBox();
            txt_dongia = new TextBox();
            c = new Label();
            txt = new Label();
            txt_masp = new TextBox();
            txt_maspct = new TextBox();
            lbl_tensp = new Label();
            lbl_masp = new Label();
            grb_thongtinsp.SuspendLayout();
            grB_chucnag.SuspendLayout();
            SuspendLayout();
            // 
            // grb_thongtinsp
            // 
            grb_thongtinsp.Controls.Add(cbb_km1);
            grb_thongtinsp.Controls.Add(cbb_nhacungcap);
            grb_thongtinsp.Controls.Add(cbb_thuonghieu);
            grb_thongtinsp.Controls.Add(cbb_danhmuc);
            grb_thongtinsp.Controls.Add(label4);
            grb_thongtinsp.Controls.Add(label3);
            grb_thongtinsp.Controls.Add(label1);
            grb_thongtinsp.Controls.Add(grB_chucnag);
            grb_thongtinsp.Controls.Add(label2);
            grb_thongtinsp.Controls.Add(txt_soluong);
            grb_thongtinsp.Controls.Add(txt_dongia);
            grb_thongtinsp.Controls.Add(c);
            grb_thongtinsp.Controls.Add(txt);
            grb_thongtinsp.Controls.Add(txt_masp);
            grb_thongtinsp.Controls.Add(txt_maspct);
            grb_thongtinsp.Controls.Add(lbl_tensp);
            grb_thongtinsp.Controls.Add(lbl_masp);
            grb_thongtinsp.Location = new Point(0, 12);
            grb_thongtinsp.Name = "grb_thongtinsp";
            grb_thongtinsp.Size = new Size(788, 450);
            grb_thongtinsp.TabIndex = 3;
            grb_thongtinsp.TabStop = false;
            grb_thongtinsp.Text = "Thông tin sản phẩm";
            // 
            // cbb_km1
            // 
            cbb_km1.FormattingEnabled = true;
            cbb_km1.Location = new Point(527, 190);
            cbb_km1.Name = "cbb_km1";
            cbb_km1.Size = new Size(235, 28);
            cbb_km1.TabIndex = 48;
            // 
            // cbb_nhacungcap
            // 
            cbb_nhacungcap.FormattingEnabled = true;
            cbb_nhacungcap.Location = new Point(532, 395);
            cbb_nhacungcap.Name = "cbb_nhacungcap";
            cbb_nhacungcap.Size = new Size(235, 28);
            cbb_nhacungcap.TabIndex = 47;
            // 
            // cbb_thuonghieu
            // 
            cbb_thuonghieu.FormattingEnabled = true;
            cbb_thuonghieu.Location = new Point(527, 323);
            cbb_thuonghieu.Name = "cbb_thuonghieu";
            cbb_thuonghieu.Size = new Size(235, 28);
            cbb_thuonghieu.TabIndex = 46;
            // 
            // cbb_danhmuc
            // 
            cbb_danhmuc.FormattingEnabled = true;
            cbb_danhmuc.Location = new Point(527, 258);
            cbb_danhmuc.Name = "cbb_danhmuc";
            cbb_danhmuc.Size = new Size(235, 28);
            cbb_danhmuc.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 403);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 43;
            label4.Text = "Mã nhà cung cấp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 331);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 41;
            label3.Text = "Mã thương hiệu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 261);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 39;
            label1.Text = "Mã danh mục:";
            // 
            // grB_chucnag
            // 
            grB_chucnag.Controls.Add(btn_sua);
            grB_chucnag.Controls.Add(btn_them);
            grB_chucnag.Location = new Point(6, 125);
            grB_chucnag.Name = "grB_chucnag";
            grB_chucnag.Size = new Size(373, 142);
            grB_chucnag.TabIndex = 30;
            grB_chucnag.TabStop = false;
            grB_chucnag.Text = "Chức năng";
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.FromArgb(0, 164, 232);
            btn_sua.Cursor = Cursors.Hand;
            btn_sua.FlatAppearance.BorderSize = 0;
            btn_sua.FlatStyle = FlatStyle.Flat;
            btn_sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua.ForeColor = Color.White;
            btn_sua.Image = Properties.Resources.wrench;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(217, 54);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(120, 48);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.FromArgb(10, 154, 86);
            btn_them.Cursor = Cursors.Hand;
            btn_them.FlatAppearance.BorderSize = 0;
            btn_them.FlatStyle = FlatStyle.Flat;
            btn_them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_them.ForeColor = Color.White;
            btn_them.Image = Properties.Resources.add;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(34, 54);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(120, 48);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 198);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 20;
            label2.Text = "Mã khuyến mãi:";
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(527, 116);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(235, 27);
            txt_soluong.TabIndex = 19;
            // 
            // txt_dongia
            // 
            txt_dongia.Location = new Point(527, 37);
            txt_dongia.Name = "txt_dongia";
            txt_dongia.Size = new Size(235, 27);
            txt_dongia.TabIndex = 18;
            // 
            // c
            // 
            c.AutoSize = true;
            c.Location = new Point(401, 119);
            c.Name = "c";
            c.Size = new Size(72, 20);
            c.TabIndex = 17;
            c.Text = "Số lượng:";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(401, 40);
            txt.Name = "txt";
            txt.Size = new Size(65, 20);
            txt.TabIndex = 16;
            txt.Text = "Đơn giá:";
            // 
            // txt_masp
            // 
            txt_masp.Location = new Point(166, 92);
            txt_masp.Name = "txt_masp";
            txt_masp.Size = new Size(213, 27);
            txt_masp.TabIndex = 3;
            // 
            // txt_maspct
            // 
            txt_maspct.Location = new Point(166, 34);
            txt_maspct.Name = "txt_maspct";
            txt_maspct.Size = new Size(213, 27);
            txt_maspct.TabIndex = 2;
            // 
            // lbl_tensp
            // 
            lbl_tensp.AutoSize = true;
            lbl_tensp.Location = new Point(19, 96);
            lbl_tensp.Name = "lbl_tensp";
            lbl_tensp.Size = new Size(101, 20);
            lbl_tensp.TabIndex = 1;
            lbl_tensp.Text = "Mã sản phẩm:";
            // 
            // lbl_masp
            // 
            lbl_masp.AutoSize = true;
            lbl_masp.Location = new Point(19, 37);
            lbl_masp.Name = "lbl_masp";
            lbl_masp.Size = new Size(150, 20);
            lbl_masp.TabIndex = 0;
            lbl_masp.Text = "Mã sản phẩm chi tiết:";
            // 
            // Form_ChiTietSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(795, 467);
            Controls.Add(grb_thongtinsp);
            Name = "Form_ChiTietSanPham";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_ChiTietSanPham";
            Load += Form_ChiTietSanPham_Load;
            grb_thongtinsp.ResumeLayout(false);
            grb_thongtinsp.PerformLayout();
            grB_chucnag.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_thongtinsp;
        private TextBox txt_masp;
        private TextBox txt_maspct;
        private Label lbl_tensp;
        private Label lbl_masp;
        private Label label2;
        private TextBox txt_soluong;
        private TextBox txt_dongia;
        private Label c;
        private Label txt;
        private GroupBox grB_chucnag;
        private Button btn_sua;
        private Button btn_them;
        private ComboBox cbb_km;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox cbb_nhacungcap;
        private ComboBox cbb_thuonghieu;
        private ComboBox cbb_danhmuc;
        private ComboBox cbb_km1;
    }
}