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
            InitializeSearch(); // Gọi phương thức khởi tạo sự kiện TextChanged
            UpdateEmployeeCount();
        }
        private void InitializeSearch()
        {
            txt_timkiemnv.TextChanged += new EventHandler(txt_timkiemnv_TextChanged);
        }
        private void LoadData()
        {
            string selectedRole = cmbChucVu.SelectedItem?.ToString().ToLower() ?? "nhân viên";

            var data = dbcontext.NhanViens
                .Where(nv => (selectedRole == "nhân viên" && nv.TenChucVu != "Admin") ||
                             (selectedRole == "admin" && nv.TenChucVu == "Admin"))
                .Select(nv => new
                {
                    nv.MaNhanVien,
                    nv.TenNhanVien,
                    nv.Username,
                    nv.Password,
                    nv.Sdt,
                    nv.DiaChi,
                    nv.TenChucVu,
                    nv.NgayThue,
                    nv.DaThoiViec
                })
                .ToList();

            dtg_nhanvien.DataSource = data;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var newNhanVien = new NhanVien
            {
                MaNhanVien = txt_manv.Text,
                TenNhanVien = txt_tennv.Text,
                Username = txt_username.Text,
                Password = txt_mk.Text,
                Sdt = txt_sdt.Text,
                DiaChi = txt_diachi.Text,
                TenChucVu = cmb_role.SelectedItem.ToString(),
                DaThoiViec = chkDaThoiViec.Checked
            };

            dbcontext.NhanViens.Add(newNhanVien);
            dbcontext.SaveChanges();
            LoadData();
            UpdateEmployeeCount();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string selectedId = dtg_nhanvien.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
            var nhanVien = dbcontext.NhanViens.Find(selectedId);

            if (nhanVien != null)
            {
                nhanVien.TenNhanVien = txt_tennv.Text;
                nhanVien.Username = txt_username.Text;
                nhanVien.Password = txt_mk.Text;
                nhanVien.Sdt = txt_sdt.Text;
                nhanVien.DiaChi = txt_diachi.Text;
                nhanVien.TenChucVu = cmb_role.SelectedItem.ToString();
                nhanVien.DaThoiViec = chkDaThoiViec.Checked;
                dbcontext.SaveChanges();
                LoadData();
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

            var searchResults = dbcontext.NhanViens
                .Where(nv => nv.MaNhanVien.ToLower().Contains(searchTerm) ||
                             nv.TenNhanVien.ToLower().Contains(searchTerm) ||
                             nv.Username.ToLower().Contains(searchTerm))
                .Select(nv => new
                {
                    nv.MaNhanVien,
                    nv.TenNhanVien,
                    nv.Username,
                    nv.Password,
                    nv.Sdt,
                    nv.DiaChi,
                    nv.TenChucVu
                })
                .ToList();

            dtg_nhanvien.DataSource = searchResults;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadData();
            UpdateEmployeeCount();
        }

        private void Form_QL_Nhanvien_Load(object sender, EventArgs e)
        {
            List<string> roles = new List<string> {"Admin", "Nhân viên bán hàng", "Nhân viên kho" };
            cmb_role.DataSource = roles;
            // Đăng ký sự kiện CellEndEdit
            dtg_nhanvien.CellEndEdit += Dtg_nhanvien_CellEndEdit;

            // Các phần khác của mã khởi tạo form
            dtg_nhanvien.EditMode = DataGridViewEditMode.EditOnEnter;
            cmbChucVu.Items.Add("Nhân viên");
            cmbChucVu.Items.Add("Admin");
            cmbChucVu.SelectedIndex = 0; // Chọn mặc định
            cmbChucVu.SelectedIndexChanged += cmbChucVu_SelectedIndexChanged;

            chkDaThoiViec2.CheckedChanged += (s, ev) => SearchData();
        }

        private void Dtg_nhanvien_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtg_nhanvien.Rows[e.RowIndex];

                txt_manv.Text = row.Cells["MaNhanVien"].Value?.ToString() ?? string.Empty;
                txt_tennv.Text = row.Cells["TenNhanVien"].Value?.ToString() ?? string.Empty;
                txt_username.Text = row.Cells["Username"].Value?.ToString() ?? string.Empty;
                txt_mk.Text = row.Cells["Password"].Value?.ToString() ?? string.Empty;
                txt_sdt.Text = row.Cells["Sdt"].Value?.ToString() ?? string.Empty;
                txt_diachi.Text = row.Cells["DiaChi"].Value?.ToString() ?? string.Empty;

                // Đặt giá trị cho ComboBox hoặc không chọn mục nào nếu giá trị không tồn tại
                var role = row.Cells["TenChucVu"].Value?.ToString();
                if (!string.IsNullOrEmpty(role) && cmb_role.Items.Contains(role))
                {
                    cmb_role.SelectedItem = role;
                }
                else
                {
                    cmb_role.SelectedIndex = -1;
                }

                txt_ngaythue.Text = row.Cells["NgayThue"].Value != null ? ((DateTime)row.Cells["NgayThue"].Value).ToString("yyyy-MM-dd") : string.Empty;
                chkDaThoiViec.Checked = row.Cells["DaThoiViec"].Value != null && (bool)row.Cells["DaThoiViec"].Value;
            }
        }

        private void SearchData()
        {
            bool daThoiViec = chkDaThoiViec2.Checked;

            string selectedRole = cmbChucVu.SelectedItem?.ToString().ToLower() ?? "nhân viên";

            var searchResults = dbcontext.NhanViens
                .Where(nv => (selectedRole == "nhân viên" && nv.TenChucVu != "Admin") ||
                             (selectedRole == "admin" && nv.TenChucVu == "Admin"))
                .Where(nv => nv.DaThoiViec == daThoiViec)
                .Select(nv => new
                {
                    nv.MaNhanVien,
                    nv.TenNhanVien,
                    nv.Username,
                    nv.Password,
                    nv.Sdt,
                    nv.DiaChi,
                    nv.TenChucVu,
                    nv.NgayThue,
                    nv.DaThoiViec
                })
                .ToList();

            dtg_nhanvien.DataSource = searchResults;
        }

        private void cmbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void chkDaThoiViec2_CheckedChanged(object sender, EventArgs e)
        {
            SearchData();
        }


        private void dtg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtg_nhanvien.Rows[e.RowIndex];

                txt_manv.Text = row.Cells["MaNhanVien"].Value?.ToString() ?? string.Empty;
                txt_tennv.Text = row.Cells["TenNhanVien"].Value?.ToString() ?? string.Empty;
                txt_username.Text = row.Cells["Username"].Value?.ToString() ?? string.Empty;
                txt_mk.Text = row.Cells["Password"].Value?.ToString() ?? string.Empty;
                txt_sdt.Text = row.Cells["Sdt"].Value?.ToString() ?? string.Empty;
                txt_diachi.Text = row.Cells["DiaChi"].Value?.ToString() ?? string.Empty;
                cmb_role.SelectedItem = row.Cells["TenChucVu"].Value?.ToString() ?? string.Empty;
                txt_ngaythue.Text = row.Cells["NgayThue"].Value != null ? ((DateTime)row.Cells["NgayThue"].Value).ToString("yyyy-MM-dd") : string.Empty;
                chkDaThoiViec.Checked = row.Cells["DaThoiViec"].Value != null && (bool)row.Cells["DaThoiViec"].Value;
            }
        }

        private void cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
