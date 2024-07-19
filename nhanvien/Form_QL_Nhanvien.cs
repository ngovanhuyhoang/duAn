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
            LoadData();
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
            var newNhanVien = new NhanVien
            {
                Ten = txt_tennv.Text,
                TenDangNhap = txt_username.Text,
                MatKhau = txt_mk.Text,
                SoDienThoai = txt_sdt.Text,
                Email = txt_email.Text,
                DiaChi = txt_diachi.Text,
                IsAdmin = chkIsAdmin.Checked ? 1 : 0
            };

            dbcontext.NhanViens.Add(newNhanVien);
            dbcontext.SaveChanges();
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dtg_nhanvien.SelectedRows[0].Cells["MaNhanVien"].Value;
            var nhanVien = dbcontext.NhanViens.Find(selectedId);

            if (nhanVien != null)
            {
                nhanVien.Ten = txt_tennv.Text;
                nhanVien.TenDangNhap = txt_username.Text;
                nhanVien.MatKhau = txt_mk.Text;
                nhanVien.SoDienThoai = txt_sdt.Text;
                nhanVien.Email = txt_email.Text;
                nhanVien.DiaChi = txt_diachi.Text;
                nhanVien.IsAdmin = chkIsAdmin.Checked ? 1 : 0;

                dbcontext.SaveChanges();
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dtg_nhanvien.SelectedRows[0].Cells["MaNhanVien"].Value;
            var nhanVien = dbcontext.NhanViens.Find(selectedId);

            if (nhanVien != null)
            {
                dbcontext.NhanViens.Remove(nhanVien);
                dbcontext.SaveChanges();
                LoadData();
            }
        }

        private void dtg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra nếu có hàng được chọn (RowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                var row = dtg_nhanvien.Rows[e.RowIndex];

                // Điền dữ liệu vào các TextBox từ hàng được chọn
                txt_manv.Text = row.Cells["MaNhanVien"].Value.ToString();
                txt_tennv.Text = row.Cells["Ten"].Value.ToString();
                txt_username.Text = row.Cells["TenDangNhap"].Value.ToString();
                txt_mk.Text = row.Cells["MatKhau"].Value.ToString();
                txt_sdt.Text = row.Cells["SoDienThoai"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                txt_diachi.Text = row.Cells["DiaChi"].Value.ToString();

                // Thiết lập trạng thái cho CheckBox
                int isAdminValue = (int)row.Cells["isAdmin"].Value;
                chkIsAdmin.Checked = (isAdminValue == 1);
                txt_ngaythue.Text = ((DateTime)row.Cells["NgayThue"].Value).ToString("yyyy-MM-dd");
            }
        }
        private void UpdateEmployeeCount()
        {
            int employeeCount = dbcontext.NhanViens.Count();
            lbl_hienthisoluongnv.Text = $"{employeeCount}";
        }

        private void txt_timkiemnv_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txt_timkiemnv.Text.ToLower();

            // Kiểm tra nếu searchTerm là số thì chuyển đổi sang int
            bool isNumeric = int.TryParse(searchTerm, out int maNhanVien);

            var searchResults = dbcontext.NhanViens
                .Where(nv => (isNumeric && nv.MaNhanVien == maNhanVien) ||
                             nv.Ten.ToLower().Contains(searchTerm) ||
                             nv.VaiTro.ToLower().Contains(searchTerm) ||
                             nv.TenDangNhap.ToLower().Contains(searchTerm))
                .ToList();

            dtg_nhanvien.DataSource = searchResults;
           
        }
    }
}
