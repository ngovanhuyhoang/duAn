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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DA1_formLogin
{
    public partial class Form_Ql_Banhang : Form
    {
        private MyContext dbcontext;
        private BindingList<HoaDonDetail> invoiceDetails;
        private string currentUsername;

        public Form_Ql_Banhang(string username)
        {
            InitializeComponent();
            dbcontext = new MyContext();
            invoiceDetails = new BindingList<HoaDonDetail>();
            dtgview_hoadon.DataSource = invoiceDetails;
            currentUsername = username;
            LoadGrid();
            InitializeComboBox();
            SearchData();
            UpdateEmployeeCount();
            LoadEmployeeDetails(currentUsername);
        }
        private void LoadEmployeeDetails(string username)
        {
            var employee = dbcontext.NhanViens
                                    .Where(nv => nv.Username == username && nv.DaThoiViec == false)
                                    .Select(nv => new
                                    {
                                        nv.TenNhanVien,
                                        nv.TenChucVu
                                    })
                                    .FirstOrDefault();

            if (employee != null)
            {
                txt_tennv.Text = employee.TenNhanVien;
                txt_chucvu.Text = employee.TenChucVu;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên hoặc nhân viên đã thôi việc.");
            }
        }

        private void InitializeComboBox()
        {
            cmbx_chonhd.Items.Clear();
            var invoiceNumbers = dbcontext.HoaDons
                                           .Select(hd => hd.MaHoaDon)
                                           .Distinct()
                                           .ToList();
            cmbx_chonhd.Items.Add(" ");
            cmbx_chonhd.Items.Add("Tất Cả");
            foreach (var invoiceNumber in invoiceNumbers)
            {
                cmbx_chonhd.Items.Add(invoiceNumber);
            }
            cmbx_chonhd.SelectedIndex = 0;
        }

        private void LoadGrid()
        {
            dtgview_sanpham.ColumnCount = 4;
            dtgview_sanpham.Columns[0].Name = "Mã Sản Phẩm";
            dtgview_sanpham.Columns[1].Name = "Tên Sản Phẩm";
            dtgview_sanpham.Columns[2].Name = "Đơn Giá";
            dtgview_sanpham.Columns[3].Name = "Số Lượng";

            dtgview_sanpham.Rows.Clear();

            var query = from sp in dbcontext.SanPhams
                        join spct in dbcontext.SanPhamChiTiets on sp.MaSanPham equals spct.MaSanPham
                        select new
                        {
                            spct.MaSpct,
                            sp.TenSanPham,
                            spct.DonGia,
                            spct.SoLuong
                        };

            foreach (var item in query.ToList())
            {
                dtgview_sanpham.Rows.Add(item.MaSpct, item.TenSanPham, item.DonGia, item.SoLuong);
            }
        }

        private void txt_timsanpham_TextChanged(object sender, EventArgs e)
        {
            dtgview_sanpham.Rows.Clear();
            string searchText = txt_timkiem.Text.Trim().ToLower();
            var query = from spct in dbcontext.SanPhamChiTiets
                        join sp in dbcontext.SanPhams on spct.MaSanPham equals sp.MaSanPham
                        where sp.TenSanPham.ToLower().Contains(searchText) ||
                              sp.MaSanPham.ToLower().Contains(searchText)
                        select new
                        {
                            spct.MaSpct,
                            sp.TenSanPham,
                            spct.DonGia,
                            spct.SoLuong
                        };
            foreach (var item in query.ToList())
            {
                dtgview_sanpham.Rows.Add(item.MaSpct, item.TenSanPham, item.DonGia, item.SoLuong);
            }
        }

        private void SearchData()
        {
            string selectedInvoiceNumber = cmbx_chonhd.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedInvoiceNumber) || selectedInvoiceNumber.Trim() == "Tất Cả")
            {
                var query = from hdct in dbcontext.HoaDonChiTiets
                            join hd in dbcontext.HoaDons on hdct.MaHoaDon equals hd.MaHoaDon
                            select new
                            {
                                hdct.MaSpct,
                                hdct.MaHoaDon,
                                hdct.DonGia,
                                hd.Sdtkh,
                                hdct.SoLuong,

                            };

                dtgview_hoadon.DataSource = query.ToList();
                lbl_tonghd.Text = dbcontext.HoaDonChiTiets.Count().ToString();
            }
            else
            {
                var query = from hdct in dbcontext.HoaDonChiTiets
                            join hd in dbcontext.HoaDons on hdct.MaHoaDon equals hd.MaHoaDon
                            where hdct.MaHoaDon == selectedInvoiceNumber
                            select new
                            {
                                hdct.MaSpct,
                                hdct.MaHoaDon,
                                hdct.DonGia,
                                hd.Sdtkh,
                                hdct.SoLuong,

                            };

                dtgview_hoadon.DataSource = query.ToList();
                lbl_tonghd.Text = query.Count().ToString();
            }

            SumPrice();
        }

        private void cmbx_chonhd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void UpdateEmployeeCount()
        {
            string selectedInvoiceNumber = cmbx_chonhd.SelectedItem?.ToString() ?? "Tất Cả";
            int count;

            if (selectedInvoiceNumber == "Tất Cả")
            {
                count = dbcontext.HoaDonChiTiets.Count();
            }
            else
            {
                count = dbcontext.HoaDonChiTiets
                    .Where(hdct => hdct.MaHoaDon == selectedInvoiceNumber)
                    .Count();
            }

            lbl_tonghd.Text = $"{count}";
        }

        private void SumPrice()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dtgview_hoadon.Rows)
            {
                if (row.Cells["DonGia"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    totalAmount += donGia * soLuong;
                }
            }

            lbl_tongtien.Text = $"{totalAmount:C}";
        }

        private void lbl_tongtien_Click(object sender, EventArgs e)
        {
            SumPrice();
        }

        private void txt_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void CalculateChange()
        {
            decimal totalAmount = 0;
            decimal amountPaid = 0;

            if (decimal.TryParse(txt_tienkhachdua.Text, out amountPaid))
            {
                foreach (DataGridViewRow row in dtgview_hoadon.Rows)
                {
                    if (row.Cells["DonGia"].Value != null && row.Cells["SoLuong"].Value != null)
                    {
                        decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        totalAmount += donGia * soLuong;
                    }
                }

                decimal change = amountPaid - totalAmount;
                lbl_tienthua.Text = $"{change:C}";
            }
            else
            {
                lbl_tienthua.Text = "0";
            }
        }

        private void lbl_tienthua_Click(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn hủy không? Tất cả dữ liệu sẽ bị xóa.",
                                         "Xác Nhận",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                cmbx_chonhd.SelectedIndex = 0;
                dtgview_hoadon.DataSource = null;
                txt_timkiem.Text = string.Empty;
                txt_tienkhachdua.Text = string.Empty;
                lbl_tongtien.Text = "0";
                lbl_tienthua.Text = "0";
                lbl_tonghd.Text = "0";
            }
        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_sodt.Text) || string.IsNullOrWhiteSpace(txt_tenkh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng.");
                return;
            }
            if (dtgview_sanpham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm từ danh sách.");
                return;
            }
            string maHoaDon = "HD" + new Random().Next(5, 100).ToString();
            var customer = dbcontext.KhachHangs.FirstOrDefault(kh => kh.Sdtkh == txt_sodt.Text);
            if (customer == null)
            {
                customer = new KhachHang
                {
                    Sdtkh = txt_sodt.Text,
                    TenKhachHang = txt_tenkh.Text
                };
                dbcontext.KhachHangs.Add(customer);
                dbcontext.SaveChanges();
            }
            using (var quantityForm = new QLSoLuong())
            {
                if (quantityForm.ShowDialog() == DialogResult.OK)
                {
                    int soLuong = quantityForm.SelectedQuantity;
                    var selectedRow = dtgview_sanpham.SelectedRows[0];
                    string maSpct = selectedRow.Cells["Mã Sản Phẩm"].Value.ToString();
                    decimal donGia = Convert.ToDecimal(selectedRow.Cells["Đơn Giá"].Value);
                    int currentQuantity = Convert.ToInt32(selectedRow.Cells["Số Lượng"].Value);

                    if (soLuong > currentQuantity)
                    {
                        MessageBox.Show("Số lượng không đủ.");
                        return;
                    }
                    var hoaDon = new HoaDon
                    {
                        MaHoaDon = maHoaDon,
                        Sdtkh = customer.Sdtkh,
                    };
                    dbcontext.HoaDons.Add(hoaDon);

                    var hoaDonChiTiet = new HoaDonChiTiet
                    {
                        MaSpct = maSpct,
                        MaHoaDon = maHoaDon,
                        DonGia = donGia,
                        SoLuong = soLuong
                    };
                    dbcontext.HoaDonChiTiets.Add(hoaDonChiTiet);
                    var productDetail = dbcontext.SanPhamChiTiets.FirstOrDefault(spct => spct.MaSpct == maSpct);
                    if (productDetail != null)
                    {
                        productDetail.SoLuong -= soLuong;
                        dbcontext.SaveChanges();
                    }
                    invoiceDetails.Add(new HoaDonDetail
                    {
                        MaSpct = maSpct,
                        MaHoaDon = maHoaDon,
                        DonGia = donGia,
                        Sdtkh = customer.Sdtkh,
                        SoLuong = soLuong
                    });
                    if (!cmbx_chonhd.Items.Contains(maHoaDon))
                    {
                        cmbx_chonhd.Items.Add(maHoaDon);
                    }

                    MessageBox.Show("Hóa đơn đã được tạo.");
                    LoadGrid();
                    SearchData();
                }
            }
        }

        private void txt_sodt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tenkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgview_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgview_sanpham.Rows.Count)
            {
                dtgview_sanpham.CurrentRow.Selected = true;
            }
        }

        private void txt_tennv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_chucvu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            using (var countdownForm = new CountDown())
            {
                countdownForm.ShowDialog();
                if (countdownForm.IsConfirmed)
                {
                    MessageBox.Show("Đã thanh toán");
                    // You can add additional code here to handle the payment confirmation if needed
                }
                else
                {
                    MessageBox.Show("Vui lòng ấn thanh toán lại");
                    // Optionally, you can handle additional logic for the cancellation
                }
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
