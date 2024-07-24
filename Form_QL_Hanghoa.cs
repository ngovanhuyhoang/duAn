using Dal_da1.Context;
using Dal_da1.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1_formLogin
{
    public partial class Form_QL_Hanghoa : Form
    {
        private MyContext dbcontext;
        public Form_QL_Hanghoa()
        {
            InitializeComponent();
            dbcontext = new MyContext();
            LoadData();
            UpdateProductCount();
            InitializeSearch();
        }
        private void UpdateProductCount()
        {
            int productCount = dbcontext.SanPhams.Count();
            lbl_hienthisoluongsp.Text = $"{productCount}";
        }
        private void InitializeSearch()
        {
            txt_timkiemsp.TextChanged += new EventHandler(txt_timkiemsp_TextChanged);
        }
        private void LoadData()
        {
            dtg_sanpham.DataSource = dbcontext.SanPhams.ToList();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Tạo một mã sản phẩm mới (có thể sử dụng GUID hoặc một cơ chế tạo mã khác)
            string newMaSanPham = Guid.NewGuid().ToString();

            // Mở form chi tiết sản phẩm để nhập thông tin chi tiết
            using (Form_ChiTietSanPham formChiTiet = new Form_ChiTietSanPham(newMaSanPham))
            {
                formChiTiet.ShowDialog();

                // Kiểm tra nếu có thay đổi thì lưu thông tin sản phẩm chi tiết
                if (formChiTiet.IsUpdated)
                {
                    // Tạo một bản ghi SanPham mới
                    var newSanPham = new SanPham
                    {
                        MaSanPham = newMaSanPham,
                    };

                    // Thêm bản ghi mới vào cơ sở dữ liệu
                    dbcontext.SanPhams.Add(newSanPham);
                    dbcontext.SaveChanges();

                    // Load lại dữ liệu sau khi thêm
                    LoadData();
                    UpdateProductCount();

                    MessageBox.Show("Thêm sản phẩm thành công!");
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maSanPham = GetSelectedMaSanPham();
            if (string.IsNullOrEmpty(maSanPham))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa!");
                return;
            }

            // Mở Form_ChiTietSanPham
            using (Form_ChiTietSanPham formChiTiet = new Form_ChiTietSanPham(maSanPham))
            {
                formChiTiet.ShowDialog();

                // Kiểm tra nếu có thay đổi thì cập nhật danh sách sản phẩm
                if (formChiTiet.IsUpdated)
                {
                    LoadData(); // Load lại dữ liệu sau khi chỉnh sửa
                    UpdateProductCount(); // Cập nhật số lượng sản phẩm
                }
            }
        }

        private string GetSelectedMaSanPham()
        {
            if (dtg_sanpham.SelectedRows.Count > 0)
            {
                return dtg_sanpham.SelectedRows[0].Cells["MaSanPham"].Value.ToString();
            }
            return null;
        }

        private void txt_timkiemsp_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txt_timkiemsp.Text.ToLower();

            var searchResults = dbcontext.SanPhams
                .Where(sp => sp.TenSanPham.ToLower().Contains(searchTerm) ||
                             sp.MaSanPham.ToLower().Contains(searchTerm)) // Cập nhật các thuộc tính tìm kiếm đúng
                .ToList();

            dtg_sanpham.DataSource = searchResults;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtg_sanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var row = dtg_sanpham.Rows[e.RowIndex];
                string maSanPham = row.Cells["MaSanPham"].Value?.ToString() ?? string.Empty;

                // Mở form chi tiết và truyền mã sản phẩm để lấy thông tin chi tiết
                Form_ChiTietSanPham chiTietForm = new Form_ChiTietSanPham(maSanPham);
                chiTietForm.ShowDialog();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            using (var context = new MyContext())
            {
                var sanPham = new SanPham
                {
                    MaSanPham = txt_masp.Text,
                    TenSanPham = txt_tensp.Text,
                    MoTa = txt_mota.Text,
                    NgungKinhDoanh = chk_ngungkinhdoanh.Checked,
                    NgayThem = DateTime.Now
                };

                context.SanPhams.Add(sanPham);
                context.SaveChanges();
            }

            MessageBox.Show("Thêm sản phẩm thành công!");
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {
            using (var context = new MyContext())
            {
                // Lấy mã sản phẩm cần sửa
                string maSanPham = txt_masp.Text;

                // Tìm sản phẩm theo mã
                var sanPham = context.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);

                if (sanPham != null)
                {
                    // Cập nhật thông tin sản phẩm
                    sanPham.TenSanPham = txt_tensp.Text;
                    sanPham.MoTa = txt_mota.Text;
                    sanPham.NgungKinhDoanh = chk_ngungkinhdoanh.Checked;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();

                    MessageBox.Show("Sửa sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm với mã này!");
                }
            }
        }

        private void dtg_sanpham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtg_sanpham.Rows[e.RowIndex];
                string maSanPham = row.Cells["MaSanPham"].Value?.ToString() ?? string.Empty;

                var sanPham = dbcontext.SanPhams
                                      .Where(sp => sp.MaSanPham == maSanPham)
                                      .FirstOrDefault();
                if (sanPham != null)
                {
                    txt_masp.Text = sanPham.MaSanPham;
                    txt_tensp.Text = sanPham.TenSanPham;
                    txt_mota.Text = sanPham.MoTa;
                    chk_ngungkinhdoanh.Checked = sanPham.NgungKinhDoanh ?? false;
                    dtp_ngaythem.Value = sanPham.NgayThem ?? DateTime.Now;
                }
            }
        }

        private void chkNgungKinhDoanh_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new MyContext())
            {
                bool ngungKinhDoanh = chkNgungKinhDoanh.Checked;

                // Tìm kiếm sản phẩm theo trạng thái ngừng kinh doanh
                var sanPhams = context.SanPhams
                                      .Where(sp => sp.NgungKinhDoanh == ngungKinhDoanh)
                                      .ToList();

                // Cập nhật DataGridView
                dtg_sanpham.DataSource = sanPhams;
            }
        }
    }
}
