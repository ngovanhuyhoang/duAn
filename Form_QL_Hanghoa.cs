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
            lbl_hienthisoluongsp.Text = $"{productCount} sản phẩm";
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
            var newSanPham = new SanPham
            {
                MaSanPham = txt_masp.Text,
                TenSanPham = txt_tensp.Text,

            };

            dbcontext.SanPhams.Add(newSanPham);
            dbcontext.SaveChanges();
            LoadData();
            UpdateProductCount();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //int selectedId = (int)dtg_sanpham.SelectedRows[0].Cells["MaSanPham"].Value;
            //var sanPham = dbcontext.SanPhams.Find(selectedId);

            //if (sanPham != null)
            //{
            //    sanPham.Ten = txt_tensp.Text;
            //    sanPham.DanhMuc = txt_danhmuc.Text;
            //    sanPham.ThuongHieu = txt_thuonghieu.Text;
            //    sanPham.MaNhaCungCap = int.Parse(txt_macungcap.Text);
            //    sanPham.Gia = decimal.Parse(txt_gia.Text);
            //    sanPham.TonKho = int.Parse(txt_tonkho.Text);
            //    //sanPham.MaVach = txt_mavach.Text;

            //    dbcontext.SaveChanges();
            //    LoadData();
            //    UpdateProductCount();
            //}
        }

       

        private void dtg_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtg_sanpham.Rows[e.RowIndex];

                txt_masp.Text = row.Cells["MaSanPham"].Value?.ToString() ?? string.Empty;
                txt_tensp.Text = row.Cells["Ten"].Value?.ToString() ?? string.Empty;
                txt_danhmuc.Text = row.Cells["DanhMuc"].Value?.ToString() ?? string.Empty;
                txt_thuonghieu.Text = row.Cells["ThuongHieu"].Value?.ToString() ?? string.Empty;
                txt_macungcap.Text = row.Cells["MaNhaCungCap"].Value?.ToString() ?? string.Empty;
                txt_gia.Text = row.Cells["Gia"].Value?.ToString() ?? string.Empty;
                txt_tonkho.Text = row.Cells["TonKho"].Value?.ToString() ?? string.Empty;
                //txt_mavach.Text = row.Cells["MaVach"].Value?.ToString() ?? string.Empty;
            }
        }

        private void txt_timkiemsp_TextChanged(object sender, EventArgs e)
        {
            //string searchTerm = txt_timkiemsp.Text.ToLower();

            //var searchResults = dbcontext.SanPhams
                             

            //    .Where(sp => sp.Ten.ToLower().Contains(searchTerm) ||
            //                 sp.DanhMuc.ToLower().Contains(searchTerm) ||
            //                 sp.ThuongHieu.ToLower().Contains(searchTerm) ||
            //                 sp.MaVach.ToLower().Contains(searchTerm) )
            //    .ToList();

            //dtg_sanpham.DataSource = searchResults;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
