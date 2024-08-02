namespace DA1_formLogin
{
    partial class Form_Ql_Banhang
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
            groupBox1 = new GroupBox();
            txt_chucvu = new TextBox();
            txt_tennv = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btn_taohoadon = new Button();
            txt_tenkh = new TextBox();
            txt_sodt = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            lbl_tienthua = new Label();
            label13 = new Label();
            txt_tienkhachdua = new TextBox();
            lbl_tongtien = new Label();
            label10 = new Label();
            label4 = new Label();
            lbl_tonghd = new Label();
            label2 = new Label();
            btn_huy = new Button();
            btn_thanhtoan = new Button();
            dtgview_hoadon = new DataGridView();
            label1 = new Label();
            cmbx_chonhd = new ComboBox();
            groupBox4 = new GroupBox();
            label11 = new Label();
            txt_timkiem = new TextBox();
            dtgview_sanpham = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview_hoadon).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview_sanpham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_chucvu);
            groupBox1.Controls.Add(txt_tennv);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // txt_chucvu
            // 
            txt_chucvu.Location = new Point(110, 77);
            txt_chucvu.Name = "txt_chucvu";
            txt_chucvu.Size = new Size(177, 27);
            txt_chucvu.TabIndex = 3;
            txt_chucvu.TextChanged += txt_chucvu_TextChanged;
            // 
            // txt_tennv
            // 
            txt_tennv.Location = new Point(110, 33);
            txt_tennv.Name = "txt_tennv";
            txt_tennv.Size = new Size(177, 27);
            txt_tennv.TabIndex = 2;
            txt_tennv.TextChanged += txt_tennv_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 84);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 1;
            label6.Text = "Chức Vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 36);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 0;
            label5.Text = "Tên Nhân Viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(btn_taohoadon);
            groupBox2.Controls.Add(txt_tenkh);
            groupBox2.Controls.Add(txt_sodt);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(1, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 369);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Khách Hàng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(93, 208);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 8;
            label9.Text = "Ngày Mua";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(11, 231);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // btn_taohoadon
            // 
            btn_taohoadon.BackColor = Color.MediumTurquoise;
            btn_taohoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_taohoadon.ForeColor = Color.White;
            btn_taohoadon.Location = new Point(55, 301);
            btn_taohoadon.Name = "btn_taohoadon";
            btn_taohoadon.Size = new Size(159, 47);
            btn_taohoadon.TabIndex = 6;
            btn_taohoadon.Text = "Tạo Hóa Đơn";
            btn_taohoadon.UseVisualStyleBackColor = false;
            btn_taohoadon.Click += btn_taohoadon_Click;
            // 
            // txt_tenkh
            // 
            txt_tenkh.Location = new Point(11, 148);
            txt_tenkh.Name = "txt_tenkh";
            txt_tenkh.Size = new Size(265, 27);
            txt_tenkh.TabIndex = 3;
            txt_tenkh.TextChanged += txt_tenkh_TextChanged;
            // 
            // txt_sodt
            // 
            txt_sodt.Location = new Point(11, 65);
            txt_sodt.Name = "txt_sodt";
            txt_sodt.Size = new Size(265, 27);
            txt_sodt.TabIndex = 2;
            txt_sodt.TextChanged += txt_sodt_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 125);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 1;
            label8.Text = "Tên Khách Hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 42);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 0;
            label7.Text = "Số Điện Thoại";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_tienthua);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txt_tienkhachdua);
            groupBox3.Controls.Add(lbl_tongtien);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(lbl_tonghd);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btn_huy);
            groupBox3.Controls.Add(btn_thanhtoan);
            groupBox3.Controls.Add(dtgview_hoadon);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cmbx_chonhd);
            groupBox3.Location = new Point(300, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(747, 637);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa Đơn";
            // 
            // lbl_tienthua
            // 
            lbl_tienthua.AutoSize = true;
            lbl_tienthua.Location = new Point(84, 580);
            lbl_tienthua.Name = "lbl_tienthua";
            lbl_tienthua.Size = new Size(21, 20);
            lbl_tienthua.TabIndex = 12;
            lbl_tienthua.Text = "....";
            lbl_tienthua.Click += lbl_tienthua_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 580);
            label13.Name = "label13";
            label13.Size = new Size(85, 20);
            label13.TabIndex = 11;
            label13.Text = "Tiền Thừa : ";
            // 
            // txt_tienkhachdua
            // 
            txt_tienkhachdua.Location = new Point(135, 524);
            txt_tienkhachdua.Name = "txt_tienkhachdua";
            txt_tienkhachdua.Size = new Size(344, 27);
            txt_tienkhachdua.TabIndex = 10;
            txt_tienkhachdua.TextChanged += txt_tienkhachdua_TextChanged;
            // 
            // lbl_tongtien
            // 
            lbl_tongtien.AutoSize = true;
            lbl_tongtien.Location = new Point(381, 475);
            lbl_tongtien.Name = "lbl_tongtien";
            lbl_tongtien.Size = new Size(21, 20);
            lbl_tongtien.TabIndex = 9;
            lbl_tongtien.Text = "....";
            lbl_tongtien.Click += lbl_tongtien_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(300, 475);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 8;
            label10.Text = "Tổng Tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 527);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 7;
            label4.Text = "Tiền Khách Đưa";
            // 
            // lbl_tonghd
            // 
            lbl_tonghd.AutoSize = true;
            lbl_tonghd.Location = new Point(119, 475);
            lbl_tonghd.Name = "lbl_tonghd";
            lbl_tonghd.Size = new Size(21, 20);
            lbl_tonghd.TabIndex = 6;
            lbl_tonghd.Text = "....";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 475);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 5;
            label2.Text = "Tổng Hóa Đơn : ";
            // 
            // btn_huy
            // 
            btn_huy.BackColor = Color.Tomato;
            btn_huy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_huy.ForeColor = Color.White;
            btn_huy.Location = new Point(449, 576);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(119, 43);
            btn_huy.TabIndex = 4;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = false;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.BackColor = Color.OrangeRed;
            btn_thanhtoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_thanhtoan.ForeColor = Color.White;
            btn_thanhtoan.Location = new Point(300, 574);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(119, 46);
            btn_thanhtoan.TabIndex = 3;
            btn_thanhtoan.Text = "Thanh Toán";
            btn_thanhtoan.UseVisualStyleBackColor = false;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // dtgview_hoadon
            // 
            dtgview_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgview_hoadon.Location = new Point(0, 126);
            dtgview_hoadon.Name = "dtgview_hoadon";
            dtgview_hoadon.RowHeadersWidth = 51;
            dtgview_hoadon.Size = new Size(747, 328);
            dtgview_hoadon.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 47);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // cmbx_chonhd
            // 
            cmbx_chonhd.FormattingEnabled = true;
            cmbx_chonhd.Location = new Point(179, 44);
            cmbx_chonhd.Name = "cmbx_chonhd";
            cmbx_chonhd.Size = new Size(340, 28);
            cmbx_chonhd.TabIndex = 0;
            cmbx_chonhd.SelectedIndexChanged += cmbx_chonhd_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txt_timkiem);
            groupBox4.Controls.Add(dtgview_sanpham);
            groupBox4.Location = new Point(1053, 1);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(590, 637);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sản Phẩm";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(108, 23);
            label11.Name = "label11";
            label11.Size = new Size(210, 20);
            label11.TabIndex = 2;
            label11.Text = "Nhập Sản Phẩm Cần Tìm Kiếm";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(48, 47);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(340, 27);
            txt_timkiem.TabIndex = 1;
            txt_timkiem.TextChanged += txt_timsanpham_TextChanged;
            // 
            // dtgview_sanpham
            // 
            dtgview_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgview_sanpham.Location = new Point(0, 126);
            dtgview_sanpham.Name = "dtgview_sanpham";
            dtgview_sanpham.RowHeadersWidth = 51;
            dtgview_sanpham.Size = new Size(584, 328);
            dtgview_sanpham.TabIndex = 0;
            dtgview_sanpham.CellClick += dtgview_sanpham_CellClick;
            // 
            // Form_Ql_Banhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1655, 641);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_Ql_Banhang";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview_hoadon).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview_sanpham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox txt_chucvu;
        private TextBox txt_tennv;
        private Label label6;
        private Label label5;
        private Button btn_taohoadon;
        private TextBox txt_tenkh;
        private TextBox txt_sodt;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label4;
        private Label lbl_tonghd;
        private Label label2;
        private Button btn_huy;
        private Button btn_thanhtoan;
        private DataGridView dtgview_hoadon;
        private Label label1;
        private ComboBox cmbx_chonhd;
        private TextBox txt_timkiem;
        private DataGridView dtgview_sanpham;
        private Label lbl_tienthua;
        private Label label13;
        private TextBox txt_tienkhachdua;
        private Label lbl_tongtien;
        private Label label11;
        private Label label9;
        private DateTimePicker dateTimePicker1;
    }
}