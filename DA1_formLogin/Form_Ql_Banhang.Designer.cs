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
            panel1 = new Panel();
            grB_chucnag = new GroupBox();
            button3 = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            button1 = new Button();
            grb_thongtinsp = new GroupBox();
            lbl_donvi = new Label();
            lbl_tongtien = new Label();
            lbl_thanhtien = new Label();
            txt_chietkhau = new TextBox();
            label8 = new Label();
            txt_soluong = new TextBox();
            label7 = new Label();
            txt_mavach = new TextBox();
            label5 = new Label();
            txt_tonkho = new TextBox();
            label6 = new Label();
            txt_gia = new TextBox();
            label2 = new Label();
            txt_macungcap = new TextBox();
            txt_thuonghieu = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_danhmuc = new TextBox();
            label1 = new Label();
            txt_tensp = new TextBox();
            txt_masp = new TextBox();
            lbl_tensp = new Label();
            lbl_masp = new Label();
            panel2 = new Panel();
            txt_timkiemsp = new TextBox();
            lbl_timkiemsp = new Label();
            dateTimePicker1 = new DateTimePicker();
            dtg_thanhtoan = new DataGridView();
            dtg_sanpham = new DataGridView();
            panel1.SuspendLayout();
            grB_chucnag.SuspendLayout();
            grb_thongtinsp.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_thanhtoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).BeginInit();
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
            panel1.Size = new Size(419, 957);
            panel1.TabIndex = 0;
            // 
            // grB_chucnag
            // 
            grB_chucnag.Controls.Add(button3);
            grB_chucnag.Controls.Add(btn_xoa);
            grB_chucnag.Controls.Add(btn_sua);
            grB_chucnag.Controls.Add(button1);
            grB_chucnag.Location = new Point(3, 664);
            grB_chucnag.Name = "grB_chucnag";
            grB_chucnag.Size = new Size(403, 215);
            grB_chucnag.TabIndex = 3;
            grB_chucnag.TabStop = false;
            grB_chucnag.Text = "Chức năng";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(244, 152, 10);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.invoice;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(223, 127);
            button3.Name = "button3";
            button3.Size = new Size(146, 48);
            button3.TabIndex = 3;
            button3.Text = "In hóa đơn";
            button3.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.FromArgb(224, 55, 73);
            btn_xoa.Cursor = Cursors.Hand;
            btn_xoa.FlatAppearance.BorderSize = 0;
            btn_xoa.FlatStyle = FlatStyle.Flat;
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xoa.ForeColor = Color.White;
            btn_xoa.Image = Properties.Resources.delete;
            btn_xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoa.Location = new Point(28, 127);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(146, 48);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
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
            btn_sua.Location = new Point(223, 45);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(146, 48);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 154, 86);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.add;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(28, 45);
            button1.Name = "button1";
            button1.Size = new Size(146, 48);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // grb_thongtinsp
            // 
            grb_thongtinsp.Controls.Add(lbl_donvi);
            grb_thongtinsp.Controls.Add(lbl_tongtien);
            grb_thongtinsp.Controls.Add(lbl_thanhtien);
            grb_thongtinsp.Controls.Add(txt_chietkhau);
            grb_thongtinsp.Controls.Add(label8);
            grb_thongtinsp.Controls.Add(txt_soluong);
            grb_thongtinsp.Controls.Add(label7);
            grb_thongtinsp.Controls.Add(txt_mavach);
            grb_thongtinsp.Controls.Add(label5);
            grb_thongtinsp.Controls.Add(txt_tonkho);
            grb_thongtinsp.Controls.Add(label6);
            grb_thongtinsp.Controls.Add(txt_gia);
            grb_thongtinsp.Controls.Add(label2);
            grb_thongtinsp.Controls.Add(txt_macungcap);
            grb_thongtinsp.Controls.Add(txt_thuonghieu);
            grb_thongtinsp.Controls.Add(label3);
            grb_thongtinsp.Controls.Add(label4);
            grb_thongtinsp.Controls.Add(txt_danhmuc);
            grb_thongtinsp.Controls.Add(label1);
            grb_thongtinsp.Controls.Add(txt_tensp);
            grb_thongtinsp.Controls.Add(txt_masp);
            grb_thongtinsp.Controls.Add(lbl_tensp);
            grb_thongtinsp.Controls.Add(lbl_masp);
            grb_thongtinsp.Location = new Point(3, 12);
            grb_thongtinsp.Name = "grb_thongtinsp";
            grb_thongtinsp.Size = new Size(403, 646);
            grb_thongtinsp.TabIndex = 2;
            grb_thongtinsp.TabStop = false;
            grb_thongtinsp.Text = "Thông tin sản phẩm";
            // 
            // lbl_donvi
            // 
            lbl_donvi.AutoSize = true;
            lbl_donvi.Location = new Point(173, 600);
            lbl_donvi.Name = "lbl_donvi";
            lbl_donvi.Size = new Size(40, 20);
            lbl_donvi.TabIndex = 22;
            lbl_donvi.Text = "VNĐ";
            // 
            // lbl_tongtien
            // 
            lbl_tongtien.AutoSize = true;
            lbl_tongtien.Location = new Point(99, 600);
            lbl_tongtien.Name = "lbl_tongtien";
            lbl_tongtien.Size = new Size(75, 20);
            lbl_tongtien.TabIndex = 21;
            lbl_tongtien.Text = "......................";
            // 
            // lbl_thanhtien
            // 
            lbl_thanhtien.AutoSize = true;
            lbl_thanhtien.Location = new Point(19, 600);
            lbl_thanhtien.Name = "lbl_thanhtien";
            lbl_thanhtien.Size = new Size(81, 20);
            lbl_thanhtien.TabIndex = 20;
            lbl_thanhtien.Text = "Thành tiền:";
            // 
            // txt_chietkhau
            // 
            txt_chietkhau.Location = new Point(144, 551);
            txt_chietkhau.Name = "txt_chietkhau";
            txt_chietkhau.Size = new Size(134, 27);
            txt_chietkhau.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 558);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 18;
            label8.Text = "Chiết khấu:";
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(144, 502);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(134, 27);
            txt_soluong.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 509);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 16;
            label7.Text = "Số lượng:";
            // 
            // txt_mavach
            // 
            txt_mavach.Location = new Point(144, 445);
            txt_mavach.Name = "txt_mavach";
            txt_mavach.Size = new Size(235, 27);
            txt_mavach.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 452);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 14;
            label5.Text = "Mã vạch:";
            // 
            // txt_tonkho
            // 
            txt_tonkho.Location = new Point(144, 387);
            txt_tonkho.Name = "txt_tonkho";
            txt_tonkho.Size = new Size(235, 27);
            txt_tonkho.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 394);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 12;
            label6.Text = "Tồn kho:";
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(144, 329);
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(235, 27);
            txt_gia.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 336);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 10;
            label2.Text = "Giá:";
            // 
            // txt_macungcap
            // 
            txt_macungcap.Location = new Point(144, 271);
            txt_macungcap.Name = "txt_macungcap";
            txt_macungcap.Size = new Size(235, 27);
            txt_macungcap.TabIndex = 9;
            // 
            // txt_thuonghieu
            // 
            txt_thuonghieu.Location = new Point(144, 211);
            txt_thuonghieu.Name = "txt_thuonghieu";
            txt_thuonghieu.Size = new Size(235, 27);
            txt_thuonghieu.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 278);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 7;
            label3.Text = "Mã nhà cung cấp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 214);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 6;
            label4.Text = "Thương hiệu:";
            // 
            // txt_danhmuc
            // 
            txt_danhmuc.Location = new Point(144, 152);
            txt_danhmuc.Name = "txt_danhmuc";
            txt_danhmuc.Size = new Size(235, 27);
            txt_danhmuc.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 159);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Danh mục:";
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(144, 94);
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(235, 27);
            txt_tensp.TabIndex = 3;
            // 
            // txt_masp
            // 
            txt_masp.Location = new Point(144, 34);
            txt_masp.Name = "txt_masp";
            txt_masp.Size = new Size(235, 27);
            txt_masp.TabIndex = 2;
            // 
            // lbl_tensp
            // 
            lbl_tensp.AutoSize = true;
            lbl_tensp.Location = new Point(19, 101);
            lbl_tensp.Name = "lbl_tensp";
            lbl_tensp.Size = new Size(103, 20);
            lbl_tensp.TabIndex = 1;
            lbl_tensp.Text = "Tên sản phẩm:";
            // 
            // lbl_masp
            // 
            lbl_masp.AutoSize = true;
            lbl_masp.Location = new Point(19, 37);
            lbl_masp.Name = "lbl_masp";
            lbl_masp.Size = new Size(101, 20);
            lbl_masp.TabIndex = 0;
            lbl_masp.Text = "Mã sản phẩm:";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(txt_timkiemsp);
            panel2.Controls.Add(lbl_timkiemsp);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(dtg_thanhtoan);
            panel2.Controls.Add(dtg_sanpham);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(419, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 957);
            panel2.TabIndex = 1;
            // 
            // txt_timkiemsp
            // 
            txt_timkiemsp.Location = new Point(217, 13);
            txt_timkiemsp.Name = "txt_timkiemsp";
            txt_timkiemsp.Size = new Size(226, 27);
            txt_timkiemsp.TabIndex = 10;
            // 
            // lbl_timkiemsp
            // 
            lbl_timkiemsp.AutoSize = true;
            lbl_timkiemsp.Location = new Point(6, 16);
            lbl_timkiemsp.Name = "lbl_timkiemsp";
            lbl_timkiemsp.Size = new Size(205, 20);
            lbl_timkiemsp.TabIndex = 9;
            lbl_timkiemsp.Text = "Nhập sản phẩm cần tìm kiếm:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(459, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // dtg_thanhtoan
            // 
            dtg_thanhtoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_thanhtoan.Location = new Point(6, 533);
            dtg_thanhtoan.Name = "dtg_thanhtoan";
            dtg_thanhtoan.RowHeadersWidth = 51;
            dtg_thanhtoan.Size = new Size(703, 346);
            dtg_thanhtoan.TabIndex = 7;
            // 
            // dtg_sanpham
            // 
            dtg_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sanpham.Location = new Point(6, 46);
            dtg_sanpham.Name = "dtg_sanpham";
            dtg_sanpham.RowHeadersWidth = 51;
            dtg_sanpham.Size = new Size(703, 466);
            dtg_sanpham.TabIndex = 6;
            // 
            // Form_Ql_Banhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 957);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Ql_Banhang";
            Text = "Form_Ql_Banhang";
            panel1.ResumeLayout(false);
            grB_chucnag.ResumeLayout(false);
            grb_thongtinsp.ResumeLayout(false);
            grb_thongtinsp.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_thanhtoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grb_thongtinsp;
        private Label lbl_donvi;
        private Label lbl_tongtien;
        private Label lbl_thanhtien;
        private TextBox txt_chietkhau;
        private Label label8;
        private TextBox txt_soluong;
        private Label label7;
        private TextBox txt_mavach;
        private Label label5;
        private TextBox txt_tonkho;
        private Label label6;
        private TextBox txt_gia;
        private Label label2;
        private TextBox txt_macungcap;
        private TextBox txt_thuonghieu;
        private Label label3;
        private Label label4;
        private TextBox txt_danhmuc;
        private Label label1;
        private TextBox txt_tensp;
        private TextBox txt_masp;
        private Label lbl_tensp;
        private Label lbl_masp;
        private GroupBox grB_chucnag;
        private Button button3;
        private Button btn_xoa;
        private Button btn_sua;
        private Button button1;
        private Panel panel2;
        private TextBox txt_timkiemsp;
        private Label lbl_timkiemsp;
        private DateTimePicker dateTimePicker1;
        private DataGridView dtg_thanhtoan;
        private DataGridView dtg_sanpham;
    }
}