﻿namespace DA1_formLogin
{
    partial class Form_QL_Nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QL_Nhanvien));
            panel1 = new Panel();
            grB_chucnag = new GroupBox();
            btn_sua = new Button();
            btn_them = new Button();
            grb_thongtinsp = new GroupBox();
            cmb_role = new ComboBox();
            chkDaThoiViec = new CheckBox();
            txt_ngaythue = new TextBox();
            label7 = new Label();
            txt_diachi = new TextBox();
            label5 = new Label();
            txt_ngaysinh = new Label();
            label1 = new Label();
            txt_sdt = new TextBox();
            label2 = new Label();
            txt_mk = new TextBox();
            txt_username = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_tennv = new TextBox();
            txt_manv = new TextBox();
            lbl_tensp = new Label();
            lbl_masp = new Label();
            panel2 = new Panel();
            chkDaThoiViec2 = new CheckBox();
            label6 = new Label();
            cmbChucVu = new ComboBox();
            btn_search = new Button();
            lbl_hienthisoluongnv = new Label();
            lbl_soluongnv = new Label();
            dtg_nhanvien = new DataGridView();
            txt_timkiemnv = new TextBox();
            lbl_timkiemnv = new Label();
            panel1.SuspendLayout();
            grB_chucnag.SuspendLayout();
            grb_thongtinsp.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_nhanvien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(grB_chucnag);
            panel1.Controls.Add(grb_thongtinsp);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 900);
            panel1.TabIndex = 2;
            // 
            // grB_chucnag
            // 
            grB_chucnag.Controls.Add(btn_sua);
            grB_chucnag.Controls.Add(btn_them);
            grB_chucnag.Location = new Point(3, 608);
            grB_chucnag.Name = "grB_chucnag";
            grB_chucnag.Size = new Size(403, 132);
            grB_chucnag.TabIndex = 18;
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
            btn_sua.Location = new Point(232, 45);
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
            btn_them.Location = new Point(42, 45);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(120, 48);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // grb_thongtinsp
            // 
            grb_thongtinsp.Controls.Add(cmb_role);
            grb_thongtinsp.Controls.Add(chkDaThoiViec);
            grb_thongtinsp.Controls.Add(txt_ngaythue);
            grb_thongtinsp.Controls.Add(label7);
            grb_thongtinsp.Controls.Add(txt_diachi);
            grb_thongtinsp.Controls.Add(label5);
            grb_thongtinsp.Controls.Add(txt_ngaysinh);
            grb_thongtinsp.Controls.Add(label1);
            grb_thongtinsp.Controls.Add(txt_sdt);
            grb_thongtinsp.Controls.Add(label2);
            grb_thongtinsp.Controls.Add(txt_mk);
            grb_thongtinsp.Controls.Add(txt_username);
            grb_thongtinsp.Controls.Add(label3);
            grb_thongtinsp.Controls.Add(label4);
            grb_thongtinsp.Controls.Add(txt_tennv);
            grb_thongtinsp.Controls.Add(txt_manv);
            grb_thongtinsp.Controls.Add(lbl_tensp);
            grb_thongtinsp.Controls.Add(lbl_masp);
            grb_thongtinsp.Location = new Point(3, 12);
            grb_thongtinsp.Name = "grb_thongtinsp";
            grb_thongtinsp.Size = new Size(403, 594);
            grb_thongtinsp.TabIndex = 2;
            grb_thongtinsp.TabStop = false;
            grb_thongtinsp.Text = "Thông tin nhân viên";
            // 
            // cmb_role
            // 
            cmb_role.FormattingEnabled = true;
            cmb_role.Location = new Point(144, 364);
            cmb_role.Name = "cmb_role";
            cmb_role.Size = new Size(235, 28);
            cmb_role.TabIndex = 20;
            cmb_role.SelectedIndexChanged += cmb_role_SelectedIndexChanged;
            // 
            // chkDaThoiViec
            // 
            chkDaThoiViec.AutoSize = true;
            chkDaThoiViec.Location = new Point(19, 553);
            chkDaThoiViec.Name = "chkDaThoiViec";
            chkDaThoiViec.Size = new Size(110, 24);
            chkDaThoiViec.TabIndex = 18;
            chkDaThoiViec.Text = "Đã thôi việc";
            chkDaThoiViec.UseVisualStyleBackColor = true;
            // 
            // txt_ngaythue
            // 
            txt_ngaythue.Location = new Point(144, 503);
            txt_ngaythue.Name = "txt_ngaythue";
            txt_ngaythue.ReadOnly = true;
            txt_ngaythue.Size = new Size(235, 27);
            txt_ngaythue.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 499);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 16;
            label7.Text = "Ngày thuê:";
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(144, 436);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(235, 27);
            txt_diachi.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 433);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 14;
            label5.Text = "Địa chỉ:";
            // 
            // txt_ngaysinh
            // 
            txt_ngaysinh.AutoSize = true;
            txt_ngaysinh.Location = new Point(19, 367);
            txt_ngaysinh.Name = "txt_ngaysinh";
            txt_ngaysinh.Size = new Size(64, 20);
            txt_ngaysinh.TabIndex = 12;
            txt_ngaysinh.Text = "Chức vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 553);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(144, 302);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(235, 27);
            txt_sdt.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 301);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 10;
            label2.Text = "Số điện thoại:";
            // 
            // txt_mk
            // 
            txt_mk.Location = new Point(144, 235);
            txt_mk.Name = "txt_mk";
            txt_mk.Size = new Size(235, 27);
            txt_mk.TabIndex = 9;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(144, 168);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(235, 27);
            txt_username.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 235);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 169);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 6;
            label4.Text = "Tên đăng nhập:";
            // 
            // txt_tennv
            // 
            txt_tennv.Location = new Point(144, 101);
            txt_tennv.Name = "txt_tennv";
            txt_tennv.Size = new Size(235, 27);
            txt_tennv.TabIndex = 3;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(144, 34);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(235, 27);
            txt_manv.TabIndex = 2;
            // 
            // lbl_tensp
            // 
            lbl_tensp.AutoSize = true;
            lbl_tensp.Location = new Point(19, 103);
            lbl_tensp.Name = "lbl_tensp";
            lbl_tensp.Size = new Size(102, 20);
            lbl_tensp.TabIndex = 1;
            lbl_tensp.Text = "Tên nhân viên:";
            // 
            // lbl_masp
            // 
            lbl_masp.AutoSize = true;
            lbl_masp.Location = new Point(19, 37);
            lbl_masp.Name = "lbl_masp";
            lbl_masp.Size = new Size(100, 20);
            lbl_masp.TabIndex = 0;
            lbl_masp.Text = "Mã nhân viên:";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(chkDaThoiViec2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cmbChucVu);
            panel2.Controls.Add(btn_search);
            panel2.Controls.Add(lbl_hienthisoluongnv);
            panel2.Controls.Add(lbl_soluongnv);
            panel2.Controls.Add(dtg_nhanvien);
            panel2.Controls.Add(txt_timkiemnv);
            panel2.Controls.Add(lbl_timkiemnv);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(419, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(871, 900);
            panel2.TabIndex = 3;
            // 
            // chkDaThoiViec2
            // 
            chkDaThoiViec2.AutoSize = true;
            chkDaThoiViec2.Location = new Point(552, 554);
            chkDaThoiViec2.Name = "chkDaThoiViec2";
            chkDaThoiViec2.Size = new Size(110, 24);
            chkDaThoiViec2.TabIndex = 19;
            chkDaThoiViec2.Text = "Đã thôi việc";
            chkDaThoiViec2.UseVisualStyleBackColor = true;
            chkDaThoiViec2.CheckedChanged += chkDaThoiViec2_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(273, 554);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 19;
            label6.Text = "Chức vụ:";
            // 
            // cmbChucVu
            // 
            cmbChucVu.FormattingEnabled = true;
            cmbChucVu.Location = new Point(359, 551);
            cmbChucVu.Name = "cmbChucVu";
            cmbChucVu.Size = new Size(151, 28);
            cmbChucVu.TabIndex = 18;
            cmbChucVu.SelectedIndexChanged += cmbChucVu_SelectedIndexChanged;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(7, 167, 233);
            btn_search.Cursor = Cursors.Hand;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_search.Location = new Point(528, 12);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(111, 27);
            btn_search.TabIndex = 17;
            btn_search.Text = "Load";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // lbl_hienthisoluongnv
            // 
            lbl_hienthisoluongnv.AutoSize = true;
            lbl_hienthisoluongnv.Location = new Point(152, 551);
            lbl_hienthisoluongnv.Name = "lbl_hienthisoluongnv";
            lbl_hienthisoluongnv.Size = new Size(45, 20);
            lbl_hienthisoluongnv.TabIndex = 15;
            lbl_hienthisoluongnv.Text = "............";
            // 
            // lbl_soluongnv
            // 
            lbl_soluongnv.AutoSize = true;
            lbl_soluongnv.Location = new Point(6, 551);
            lbl_soluongnv.Name = "lbl_soluongnv";
            lbl_soluongnv.Size = new Size(139, 20);
            lbl_soluongnv.TabIndex = 14;
            lbl_soluongnv.Text = "Số lượng nhân viên:";
            // 
            // dtg_nhanvien
            // 
            dtg_nhanvien.BackgroundColor = Color.WhiteSmoke;
            dtg_nhanvien.BorderStyle = BorderStyle.Fixed3D;
            dtg_nhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_nhanvien.EditMode = DataGridViewEditMode.EditOnF2;
            dtg_nhanvien.Location = new Point(6, 62);
            dtg_nhanvien.Name = "dtg_nhanvien";
            dtg_nhanvien.ReadOnly = true;
            dtg_nhanvien.RowHeadersWidth = 51;
            dtg_nhanvien.Size = new Size(694, 466);
            dtg_nhanvien.TabIndex = 13;
            dtg_nhanvien.CellClick += dtg_nhanvien_CellClick;
            // 
            // txt_timkiemnv
            // 
            txt_timkiemnv.Location = new Point(214, 12);
            txt_timkiemnv.Name = "txt_timkiemnv";
            txt_timkiemnv.Size = new Size(296, 27);
            txt_timkiemnv.TabIndex = 12;
            txt_timkiemnv.TextChanged += txt_timkiemnv_TextChanged;
            // 
            // lbl_timkiemnv
            // 
            lbl_timkiemnv.AutoSize = true;
            lbl_timkiemnv.Location = new Point(3, 15);
            lbl_timkiemnv.Name = "lbl_timkiemnv";
            lbl_timkiemnv.Size = new Size(204, 20);
            lbl_timkiemnv.TabIndex = 11;
            lbl_timkiemnv.Text = "Nhập nhân viên cần tìm kiếm:";
            // 
            // Form_QL_Nhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1290, 900);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_QL_Nhanvien";
            Text = "Form_QL_Nhanvien";
            Load += Form_QL_Nhanvien_Load;
            panel1.ResumeLayout(false);
            grB_chucnag.ResumeLayout(false);
            grb_thongtinsp.ResumeLayout(false);
            grb_thongtinsp.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_nhanvien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grb_thongtinsp;
        private TextBox txt_diachi;
        private Label label5;
        private Label txt_ngaysinh;
        private TextBox txt_sdt;
        private Label label2;
        private TextBox txt_mk;
        private TextBox txt_username;
        private Label label3;
        private Label label4;
        private TextBox txt_tennv;
        private TextBox txt_manv;
        private Label lbl_tensp;
        private Label lbl_masp;
        private Panel panel2;
        private Label lbl_hienthisoluongnv;
        private Label lbl_soluongnv;
        private DataGridView dtg_nhanvien;
        private TextBox txt_timkiemnv;
        private Label lbl_timkiemnv;
        private TextBox txt_ngaythue;
        private Label label7;
        private GroupBox grB_chucnag;
        private Button btn_sua;
        private Button btn_them;
        private Label label1;
        private Button btn_search;
        private CheckBox chkDaThoiViec;
        private Label label6;
        private ComboBox cmbChucVu;
        private CheckBox chkDaThoiViec2;
        private ComboBox cmb_role;
    }
}