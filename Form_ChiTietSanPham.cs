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
            PopulateComboBox();
        }



        private bool isMessageShown = false;

        private void LoadChiTietSanPham()
        {
            try
            {
                var sanPhamChiTiet = dbcontext.SanPhamChiTiets
                                              .Where(spct => spct.MaSanPham == maSanPham)
                                              .FirstOrDefault();

                if (sanPhamChiTiet != null)
                {
                    PopulateComboBox();
                    txt_maspct.Text = sanPhamChiTiet.MaSpct;
                    txt_dongia.Text = sanPhamChiTiet.DonGia?.ToString() ?? string.Empty;
                    txt_soluong.Text = sanPhamChiTiet.SoLuong?.ToString() ?? string.Empty;
                    txt_masp.Text = sanPhamChiTiet.MaSanPham;

                    Task.Delay(100).ContinueWith(t =>
                    {
                        cbb_danhmuc.Invoke((Action)(() => cbb_danhmuc.SelectedValue = sanPhamChiTiet.MaDanhMuc));
                        cbb_thuonghieu.Invoke((Action)(() => cbb_thuonghieu.SelectedValue = sanPhamChiTiet.MaThuongHieu));
                        cbb_nhacungcap.Invoke((Action)(() => cbb_nhacungcap.SelectedValue = sanPhamChiTiet.MaNhaCungCap));
                        cbb_km1.Invoke((Action)(() => cbb_km1.SelectedValue = sanPhamChiTiet.MaKhuyenMai));
                    });
                }
                else
                {
                    if (!isMessageShown)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm chi tiết.");
                        isMessageShown = true; // Đặt cờ để đảm bảo thông báo không hiển thị nhiều lần
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin sản phẩm: {ex.Message}");
            }
        }


        private void PopulateComboBox()
        {
            try
            {
                // Lấy dữ liệu cho combobox khuyến mãi
                var khuyenMais = dbcontext.KhuyenMais.ToList();
                cbb_km1.DataSource = khuyenMais;
                cbb_km1.DisplayMember = "TenKhuyenMai";
                cbb_km1.ValueMember = "MaKhuyenMai";

                // Lấy dữ liệu cho combobox danh mục
                var danhMucs = dbcontext.DanhMucs.ToList();
                cbb_danhmuc.DataSource = danhMucs;
                cbb_danhmuc.DisplayMember = "TenDanhMuc"; // Tên cột hiển thị trong combobox
                cbb_danhmuc.ValueMember = "MaDanhMuc"; // Tên cột giá trị thực sự trong combobox

                // Lấy dữ liệu cho combobox thương hiệu
                var thuongHieus = dbcontext.ThuongHieus.ToList();
                cbb_thuonghieu.DataSource = thuongHieus;
                cbb_thuonghieu.DisplayMember = "TenThuongHieu";
                cbb_thuonghieu.ValueMember = "MaThuongHieu";

                // Lấy dữ liệu cho combobox nhà cung cấp
                var nhaCungCaps = dbcontext.NhaCungCaps.ToList();
                cbb_nhacungcap.DataSource = nhaCungCaps;
                cbb_nhacungcap.DisplayMember = "TenNhaCungCap";
                cbb_nhacungcap.ValueMember = "MaNhaCungCap";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu cho combobox: {ex.Message}");
            }
        }




        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maSPCT = txt_maspct.Text;
            string maKhuyenMai = cbb_km1.SelectedValue?.ToString();
            decimal donGia;
            int soLuong;
            string maDanhMuc = cbb_danhmuc.SelectedValue?.ToString();
            string maThuongHieu = cbb_thuonghieu.SelectedValue?.ToString();
            string maNhaCungCap = cbb_nhacungcap.SelectedValue?.ToString();

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
                MaKhuyenMai = cbb_km1.SelectedValue?.ToString(),
                MaSanPham = txt_masp.Text,
                MaDanhMuc = cbb_danhmuc.SelectedValue?.ToString(),
                MaThuongHieu = cbb_thuonghieu.SelectedValue?.ToString(),
                MaNhaCungCap = cbb_nhacungcap.SelectedValue?.ToString()
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

        private void Form_ChiTietSanPham_Load(object sender, EventArgs e)
        {
            LoadChiTietSanPham();
            PopulateComboBox();
           
        }
    }
}

