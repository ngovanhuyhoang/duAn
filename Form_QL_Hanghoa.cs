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
            // Kiểm tra nếu mã sản phẩm bỏ trống
            if (string.IsNullOrWhiteSpace(txt_masp.Text))
            {
                MessageBox.Show("Mã sản phẩm không được bỏ trống!");
                return; // Không tiếp tục thực hiện thêm sản phẩm
            }

            // Thêm sản phẩm vào cơ sở dữ liệu
                var sanPham = new SanPham
                {
                    MaSanPham = txt_masp.Text,
                    TenSanPham = txt_tensp.Text,
                    MoTa = txt_mota.Text,
                    NgungKinhDoanh = chk_ngungkinhdoanh.Checked,
                    NgayThem = DateTime.Now
                };

                dbcontext.SanPhams.Add(sanPham);
                dbcontext.SaveChanges();
            

            MessageBox.Show("Thêm sản phẩm thành công!");
            UpdateProductCount();
            LoadData();
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {

            
                // Lấy mã sản phẩm cần sửa
                string maSanPham = txt_masp.Text;

                // Tìm sản phẩm theo mã
                var sanPham = dbcontext.SanPhams.Find(maSanPham);

                if (sanPham != null)
                {
                    // Cập nhật thông tin sản phẩm
                    sanPham.TenSanPham = txt_tensp.Text;
                    sanPham.MoTa = txt_mota.Text;
                    sanPham.NgungKinhDoanh = chk_ngungkinhdoanh.Checked;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbcontext.SaveChanges();
                    LoadData(); // Tải lại dữ liệu sau khi sửa thành công
                    MessageBox.Show("Sửa sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm với mã này!");
                }
            

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
                bool ngungKinhDoanh = chkNgungKinhDoanh.Checked;

                // Tìm kiếm sản phẩm theo trạng thái ngừng kinh doanh
                var sanPhams = dbcontext.SanPhams
                                      .Where(sp => sp.NgungKinhDoanh == ngungKinhDoanh)
                                      .ToList();

                // Cập nhật DataGridView
                dtg_sanpham.DataSource = sanPhams;
          
        }
    }
}
