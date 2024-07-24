using Dal_da1.Context;
using Dal_da1.DomainClass;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form_ChiTietSanPham : Form
    {
        private MyContext dbcontext;
        private string maSanPham;
        public bool IsUpdated { get; private set; } = false;

        public Form_ChiTietSanPham(string maSanPham)
        {
            InitializeComponent();
            dbcontext = new MyContext();
            this.maSanPham = maSanPham;
            LoadChiTietSanPham();
        }



        private void LoadChiTietSanPham()
        {
            try
            {
                var sanPhamChiTiet = dbcontext.SanPhamChiTiets
                                               .Where(spct => spct.MaSanPham == maSanPham)
                                               .FirstOrDefault();

                if (sanPhamChiTiet != null)
                {
                    var danhMuc = dbcontext.DanhMucs.Find(sanPhamChiTiet.MaDanhMuc);
                    var thuongHieu = dbcontext.ThuongHieus.Find(sanPhamChiTiet.MaThuongHieu);
                    var nhaCungCap = dbcontext.NhaCungCaps.Find(sanPhamChiTiet.MaNhaCungCap);
                    var khuyenMai = dbcontext.KhuyenMais.Find(sanPhamChiTiet.MaKhuyenMai);

                    // Hiển thị thông tin chi tiết lên các điều khiển
                    txt_maspct.Text = sanPhamChiTiet.MaSpct;
                    txt_dongia.Text = sanPhamChiTiet.DonGia?.ToString() ?? string.Empty;
                    txt_soluong.Text = sanPhamChiTiet.SoLuong?.ToString() ?? string.Empty;
                    txt_masp.Text = sanPhamChiTiet.MaSanPham;
                    txt_dm.Text = danhMuc?.MaDanhMuc ?? string.Empty;
                    txt_th.Text = thuongHieu?.MaThuongHieu ?? string.Empty;
                    txt_ncc.Text = nhaCungCap?.MaNhaCungCap ?? string.Empty;
                    txt_km.Text = khuyenMai?.MaKhuyenMai ?? string.Empty;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm chi tiết.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin sản phẩm: {ex.Message}");
            }
        }


        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maSPCT = txt_maspct.Text;
            string maKhuyenMai = txt_km.Text;
            decimal donGia;
            int soLuong;
            string maDanhMuc = txt_dm.Text;
            string maThuongHieu = txt_th.Text;
            string maNhaCungCap = txt_ncc.Text;

            if (!decimal.TryParse(txt_dongia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                return;
            }

            if (!int.TryParse(txt_soluong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            try
            {
                var sanPhamChiTiet = dbcontext.SanPhamChiTiets
                                        .Where(spct => spct.MaSpct == maSPCT)
                                        .FirstOrDefault();

                if (sanPhamChiTiet == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm chi tiết cần sửa!");
                    return;
                }

                // Cập nhật thông tin sản phẩm chi tiết
                sanPhamChiTiet.DonGia = donGia;
                sanPhamChiTiet.SoLuong = soLuong;
                sanPhamChiTiet.MaDanhMuc = maDanhMuc;
                sanPhamChiTiet.MaThuongHieu = maThuongHieu;
                sanPhamChiTiet.MaNhaCungCap = maNhaCungCap;
                sanPhamChiTiet.MaKhuyenMai = maKhuyenMai;

                dbcontext.SaveChanges();
                IsUpdated = true;
                MessageBox.Show("Cập nhật thông tin sản phẩm chi tiết thành công!");
                this.Close(); // Đóng form sau khi lưu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sản phẩm: {ex.Message}");
            }
        }




        private void btn_them_Click(object sender, EventArgs e)
        {
            var spct = new SanPhamChiTiet
            {
                MaSpct = txt_maspct.Text,
                DonGia = decimal.TryParse(txt_dongia.Text, out var donGia) ? donGia : (decimal?)null,
                SoLuong = int.TryParse(txt_soluong.Text, out var soLuong) ? soLuong : (int?)null,
                MaKhuyenMai = txt_km.Text,
                MaSanPham = txt_masp.Text,
                MaDanhMuc = txt_dm.Text,
                MaThuongHieu = txt_th.Text,
                MaNhaCungCap = txt_ncc.Text
            };

            try
            {
                dbcontext.SanPhamChiTiets.Add(spct);
                dbcontext.SaveChanges();
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }
        }

    }
}

