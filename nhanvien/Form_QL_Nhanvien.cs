using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dal_da1.Context;
using Dal_da1.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DA1_formLogin
{
    public partial class Form_QL_Nhanvien : Form
    {
        private MyContext dbcontext;

        public Form_QL_Nhanvien()
        {
            InitializeComponent();
            dbcontext = new MyContext();
            UpdateEmployeeCount();
            InitializeSearch(); // Gọi phương thức khởi tạo sự kiện TextChanged
        }
        private void InitializeSearch()
        {
            txt_timkiemnv.TextChanged += new EventHandler(txt_timkiemnv_TextChanged);
        }
        private void LoadData()
        {
            dtg_nhanvien.DataSource = dbcontext.NhanViens.ToList();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            //var newNhanVien = new NhanVien
            //{
            //    Ten = txt_tennv.Text,
            //    TenDangNhap = txt_username.Text,
            //    MatKhau = txt_mk.Text,
            //    SoDienThoai = txt_sdt.Text,
            //    Email = txt_email.Text,
            //    DiaChi = txt_diachi.Text,
            //    IsAdmin = chkIsAdmin.Checked ? 1 : 0
            //};

            //dbcontext.NhanViens.Add(newNhanVien);
            //dbcontext.SaveChanges();
            //LoadData();
            //UpdateEmployeeCount();
            //LoadComboBoxData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //int selectedId = (int)dtg_nhanvien.SelectedRows[0].Cells["MaNhanVien"].Value;
            //var nhanVien = dbcontext.NhanViens.Find(selectedId);

            //if (nhanVien != null)
            //{
            //    nhanVien.Ten = txt_tennv.Text;
            //    nhanVien.TenDangNhap = txt_username.Text;
            //    nhanVien.MatKhau = txt_mk.Text;
            //    nhanVien.SoDienThoai = txt_sdt.Text;
            //    nhanVien.Email = txt_email.Text;
            //    nhanVien.DiaChi = txt_diachi.Text;
            //    nhanVien.IsAdmin = chkIsAdmin.Checked ? 1 : 0;

            //    dbcontext.SaveChanges();
            //    LoadData();
            //}
        }


        private void dtg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra nếu có hàng được chọn (RowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                var row = dtg_nhanvien.Rows[e.RowIndex];

                // Điền dữ liệu vào các TextBox từ hàng được chọn, nếu giá trị null thì gán chuỗi rỗng
                txt_manv.Text = row.Cells["MaNhanVien"].Value?.ToString() ?? string.Empty;
                txt_tennv.Text = row.Cells["Ten"].Value?.ToString() ?? string.Empty;
                //txt.Text = row.Cells["VaiTro"].Value?.ToString() ?? string.Empty; // Thêm trường VaiTro vào form của bạn
                txt_username.Text = row.Cells["TenDangNhap"].Value?.ToString() ?? string.Empty;
                txt_mk.Text = row.Cells["MatKhau"].Value?.ToString() ?? string.Empty;
                txt_sdt.Text = row.Cells["SoDienThoai"].Value?.ToString() ?? string.Empty;
                txt_email.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
                txt_diachi.Text = row.Cells["DiaChi"].Value?.ToString() ?? string.Empty;

                // Thiết lập trạng thái cho CheckBox
                int isAdminValue = row.Cells["IsAdmin"].Value != null ? (int)row.Cells["IsAdmin"].Value : 0;
                chkIsAdmin.Checked = (isAdminValue == 1);

                txt_ngaythue.Text = row.Cells["NgayThue"].Value != null ? ((DateTime)row.Cells["NgayThue"].Value).ToString("yyyy-MM-dd") : string.Empty;
            }
        }
        private void UpdateEmployeeCount()
        {
            int employeeCount = dbcontext.NhanViens.Count();
            lbl_hienthisoluongnv.Text = $"{employeeCount}";
        }

        private void txt_timkiemnv_TextChanged(object sender, EventArgs e)
        {
            //string searchTerm = txt_timkiemnv.Text.ToLower();

            //// Kiểm tra nếu searchTerm là số thì chuyển đổi sang int
            //bool isNumeric = int.TryParse(searchTerm, out int maNhanVien);

            //var searchResults = dbcontext.NhanViens
            //    .Where(nv => (isNumeric && nv.MaNhanVien == maNhanVien) ||
            //                 nv.Ten.ToLower().Contains(searchTerm) ||
            //                 nv.VaiTro.ToLower().Contains(searchTerm) ||
            //                 nv.TenDangNhap.ToLower().Contains(searchTerm))
            //    .ToList();

            //dtg_nhanvien.DataSource = searchResults;
            //SearchData();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadData();
            UpdateEmployeeCount();
        }

        private void Form_QL_Nhanvien_Load(object sender, EventArgs e)
        {

        }
        private void LoadComboBoxData()
        {
            //var danhMucList = dbcontext.NhanViens.Select(nv => nv.VaiTro).Distinct().ToList();
            //cmbDanhMuc.DataSource = danhMucList;
            //cmbDanhMuc.DisplayMember = "VaiTro"; // Tên cột bạn muốn hiển thị
            //cmbDanhMuc.SelectedIndex = -1; // Không chọn mục nào khi khởi tạo

            //var thuongHieuList = dbcontext.NhanViens.Select(nv => nv.TenDangNhap).Distinct().ToList();
            //cmbThuongHieu.DataSource = thuongHieuList;
            //cmbThuongHieu.DisplayMember = "TenDangNhap"; // Tên cột bạn muốn hiển thị
            //cmbThuongHieu.SelectedIndex = -1; // Không chọn mục nào khi khởi tạo
        }
        private void SearchData()
        {
            //string searchTerm = txt_timkiemnv.Text.ToLower();
            //string selectedDanhMuc = cmbDanhMuc.SelectedItem != null ? cmbDanhMuc.SelectedItem.ToString() : string.Empty;
            //string selectedThuongHieu = cmbThuongHieu.SelectedItem != null ? cmbThuongHieu.SelectedItem.ToString() : string.Empty;

            //var searchResults = dbcontext.NhanViens
            //    .Where(nv => (string.IsNullOrEmpty(searchTerm) || nv.Ten.ToLower().Contains(searchTerm)) &&
            //                 (string.IsNullOrEmpty(selectedDanhMuc) || nv.VaiTro.Equals(selectedDanhMuc)) &&
            //                 (string.IsNullOrEmpty(selectedThuongHieu) || nv.TenDangNhap.Equals(selectedThuongHieu)))
            //    .ToList();

            //dtg_nhanvien.DataSource = searchResults;
        }

        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void cmbThuongHieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
