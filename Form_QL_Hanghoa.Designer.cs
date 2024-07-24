namespace DA1_formLogin
{
    partial class Form_QL_Hanghoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QL_Hanghoa));
            panel1 = new Panel();
            grB_chucnag = new GroupBox();
            btn_luu = new Button();
            btn_suasp = new Button();
            grb_thongtinsp = new GroupBox();
            dtp_ngaythem = new DateTimePicker();
            chk_ngungkinhdoanh = new CheckBox();
            label4 = new Label();
            txt_mota = new TextBox();
            label1 = new Label();
            txt_tensp = new TextBox();
            txt_masp = new TextBox();
            lbl_tensp = new Label();
            lbl_masp = new Label();
            panel2 = new Panel();
            chkNgungKinhDoanh = new CheckBox();
            btn_load = new Button();
            lbl_donvisp = new Label();
            lbl_hienthisoluongsp = new Label();
            lbl_soluongsp = new Label();
            dtg_sanpham = new DataGridView();
            txt_timkiemsp = new TextBox();
            lbl_timkiemsp = new Label();
            panel1.SuspendLayout();
            grB_chucnag.SuspendLayout();
            grb_thongtinsp.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(419, 747);
            panel1.TabIndex = 1;
            // 
            // grB_chucnag
            // 
            grB_chucnag.Controls.Add(btn_luu);
            grB_chucnag.Controls.Add(btn_suasp);
            grB_chucnag.Location = new Point(3, 337);
            grB_chucnag.Name = "grB_chucnag";
            grB_chucnag.Size = new Size(403, 132);
            grB_chucnag.TabIndex = 3;
            grB_chucnag.TabStop = false;
            grB_chucnag.Text = "Chức năng";
            // 
            // btn_luu
            // 
            btn_luu.BackColor = Color.FromArgb(10, 154, 86);
            btn_luu.Cursor = Cursors.Hand;
            btn_luu.FlatAppearance.BorderSize = 0;
            btn_luu.FlatStyle = FlatStyle.Flat;
            btn_luu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_luu.ForeColor = Color.White;
            btn_luu.Image = Properties.Resources.add;
            btn_luu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_luu.Location = new Point(58, 46);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(120, 48);
            btn_luu.TabIndex = 2;
            btn_luu.Text = "lưu";
            btn_luu.UseVisualStyleBackColor = false;
            btn_luu.Click += btn_luu_Click;
            // 
            // btn_suasp
            // 
            btn_suasp.BackColor = Color.FromArgb(0, 164, 232);
            btn_suasp.Cursor = Cursors.Hand;
            btn_suasp.FlatAppearance.BorderSize = 0;
            btn_suasp.FlatStyle = FlatStyle.Flat;
            btn_suasp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_suasp.ForeColor = Color.White;
            btn_suasp.Image = Properties.Resources.wrench;
            btn_suasp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_suasp.Location = new Point(228, 46);
            btn_suasp.Name = "btn_suasp";
            btn_suasp.Size = new Size(120, 48);
            btn_suasp.TabIndex = 2;
            btn_suasp.Text = "Sửa";
            btn_suasp.UseVisualStyleBackColor = false;
            btn_suasp.Click += btn_suasp_Click;
            // 
            // grb_thongtinsp
            // 
            grb_thongtinsp.Controls.Add(dtp_ngaythem);
            grb_thongtinsp.Controls.Add(chk_ngungkinhdoanh);
            grb_thongtinsp.Controls.Add(label4);
            grb_thongtinsp.Controls.Add(txt_mota);
            grb_thongtinsp.Controls.Add(label1);
            grb_thongtinsp.Controls.Add(txt_tensp);
            grb_thongtinsp.Controls.Add(txt_masp);
            grb_thongtinsp.Controls.Add(lbl_tensp);
            grb_thongtinsp.Controls.Add(lbl_masp);
            grb_thongtinsp.Location = new Point(3, 12);
            grb_thongtinsp.Name = "grb_thongtinsp";
            grb_thongtinsp.Size = new Size(403, 319);
            grb_thongtinsp.TabIndex = 2;
            grb_thongtinsp.TabStop = false;
            grb_thongtinsp.Text = "Thông tin sản phẩm";
            // 
            // dtp_ngaythem
            // 
            dtp_ngaythem.Location = new Point(144, 207);
            dtp_ngaythem.Name = "dtp_ngaythem";
            dtp_ngaythem.Size = new Size(235, 27);
            dtp_ngaythem.TabIndex = 15;
            // 
            // chk_ngungkinhdoanh
            // 
            chk_ngungkinhdoanh.AutoSize = true;
            chk_ngungkinhdoanh.Location = new Point(19, 262);
            chk_ngungkinhdoanh.Name = "chk_ngungkinhdoanh";
            chk_ngungkinhdoanh.Size = new Size(154, 24);
            chk_ngungkinhdoanh.TabIndex = 14;
            chk_ngungkinhdoanh.Text = "Ngừng kinh doanh";
            chk_ngungkinhdoanh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 214);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 6;
            label4.Text = "ngày thêm:";
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(144, 150);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(235, 27);
            txt_mota.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 155);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "Mô tả:";
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(144, 92);
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
            lbl_tensp.Location = new Point(19, 96);
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
            panel2.Controls.Add(chkNgungKinhDoanh);
            panel2.Controls.Add(btn_load);
            panel2.Controls.Add(lbl_donvisp);
            panel2.Controls.Add(lbl_hienthisoluongsp);
            panel2.Controls.Add(lbl_soluongsp);
            panel2.Controls.Add(dtg_sanpham);
            panel2.Controls.Add(txt_timkiemsp);
            panel2.Controls.Add(lbl_timkiemsp);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(419, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 747);
            panel2.TabIndex = 2;
            // 
            // chkNgungKinhDoanh
            // 
            chkNgungKinhDoanh.AutoSize = true;
            chkNgungKinhDoanh.Location = new Point(536, 547);
            chkNgungKinhDoanh.Name = "chkNgungKinhDoanh";
            chkNgungKinhDoanh.Size = new Size(154, 24);
            chkNgungKinhDoanh.TabIndex = 19;
            chkNgungKinhDoanh.Text = "Ngừng kinh doanh";
            chkNgungKinhDoanh.UseVisualStyleBackColor = true;
            chkNgungKinhDoanh.CheckedChanged += chkNgungKinhDoanh_CheckedChanged;
            // 
            // btn_load
            // 
            btn_load.BackColor = Color.FromArgb(7, 167, 233);
            btn_load.Cursor = Cursors.Hand;
            btn_load.FlatAppearance.BorderSize = 0;
            btn_load.FlatStyle = FlatStyle.Flat;
            btn_load.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_load.ForeColor = Color.White;
            btn_load.Image = (Image)resources.GetObject("btn_load.Image");
            btn_load.ImageAlign = ContentAlignment.MiddleLeft;
            btn_load.Location = new Point(507, 12);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(111, 27);
            btn_load.TabIndex = 18;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = false;
            btn_load.Click += btn_load_Click;
            // 
            // lbl_donvisp
            // 
            lbl_donvisp.AutoSize = true;
            lbl_donvisp.Location = new Point(203, 551);
            lbl_donvisp.Name = "lbl_donvisp";
            lbl_donvisp.Size = new Size(73, 20);
            lbl_donvisp.TabIndex = 16;
            lbl_donvisp.Text = "sản phẩm";
            // 
            // lbl_hienthisoluongsp
            // 
            lbl_hienthisoluongsp.AutoSize = true;
            lbl_hienthisoluongsp.Location = new Point(152, 551);
            lbl_hienthisoluongsp.Name = "lbl_hienthisoluongsp";
            lbl_hienthisoluongsp.Size = new Size(45, 20);
            lbl_hienthisoluongsp.TabIndex = 15;
            lbl_hienthisoluongsp.Text = "............";
            // 
            // lbl_soluongsp
            // 
            lbl_soluongsp.AutoSize = true;
            lbl_soluongsp.Location = new Point(6, 551);
            lbl_soluongsp.Name = "lbl_soluongsp";
            lbl_soluongsp.Size = new Size(140, 20);
            lbl_soluongsp.TabIndex = 14;
            lbl_soluongsp.Text = "Số lượng sản phẩm:";
            // 
            // dtg_sanpham
            // 
            dtg_sanpham.BackgroundColor = Color.WhiteSmoke;
            dtg_sanpham.BorderStyle = BorderStyle.Fixed3D;
            dtg_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sanpham.Location = new Point(6, 62);
            dtg_sanpham.Name = "dtg_sanpham";
            dtg_sanpham.RowHeadersWidth = 51;
            dtg_sanpham.Size = new Size(694, 466);
            dtg_sanpham.TabIndex = 13;
            dtg_sanpham.CellClick += dtg_sanpham_CellClick;
            dtg_sanpham.CellDoubleClick += dtg_sanpham_CellDoubleClick;
            // 
            // txt_timkiemsp
            // 
            txt_timkiemsp.Location = new Point(214, 12);
            txt_timkiemsp.Name = "txt_timkiemsp";
            txt_timkiemsp.Size = new Size(287, 27);
            txt_timkiemsp.TabIndex = 12;
            txt_timkiemsp.TextChanged += txt_timkiemsp_TextChanged;
            // 
            // lbl_timkiemsp
            // 
            lbl_timkiemsp.AutoSize = true;
            lbl_timkiemsp.Location = new Point(3, 15);
            lbl_timkiemsp.Name = "lbl_timkiemsp";
            lbl_timkiemsp.Size = new Size(205, 20);
            lbl_timkiemsp.TabIndex = 11;
            lbl_timkiemsp.Text = "Nhập sản phẩm cần tìm kiếm:";
            // 
            // Form_QL_Hanghoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1198, 747);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_QL_Hanghoa";
            Text = "Form_QL_Hanghoa";
            panel1.ResumeLayout(false);
            grB_chucnag.ResumeLayout(false);
            grb_thongtinsp.ResumeLayout(false);
            grb_thongtinsp.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grB_chucnag;
        private GroupBox grb_thongtinsp;
        private Label label4;
        private TextBox txt_mota;
        private Label label1;
        private TextBox txt_tensp;
        private TextBox txt_masp;
        private Label lbl_tensp;
        private Label lbl_masp;
        private Panel panel2;
        private TextBox txt_timkiemsp;
        private Label lbl_timkiemsp;
        private DataGridView dtg_sanpham;
        private Label lbl_hienthisoluongsp;
        private Label lbl_soluongsp;
        private Label lbl_donvisp;
        private Button btn_load;
        private CheckBox chk_ngungkinhdoanh;
        private DateTimePicker dtp_ngaythem;
        private Button btn_luu;
        private Button btn_suasp;
        private CheckBox chkNgungKinhDoanh;
    }
}