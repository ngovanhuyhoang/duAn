using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using Dal_da1.DomainClass;

namespace DA1_formLogin

{
    public partial class CountDown : Form
    {

        private System.Windows.Forms.Timer countdownTimer;
        private int remainingTime;
        public bool IsConfirmed { get; private set; }
        private string selectedMaHoaDon; 
        public CountDown(string MaHoaDon)
        {
            InitializeComponent();
            InitializeTimer();
            selectedMaHoaDon = MaHoaDon;
        }

        private void InitializeTimer()
        {
            remainingTime = 10; //Chỉnh Giây Đếm Ngược
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
            UpdateTimerLabel();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            UpdateTimerLabel();

            if (remainingTime <= 0)
            {
                countdownTimer.Stop();
                MessageBox.Show("Thời gian thanh toán đã hết. Vui lòng ấn thanh toán lại.");
                this.Close();
            }
        }

        private void UpdateTimerLabel()
        {
            lbl_Timer.Text = $" {remainingTime} s";
        }

        private void CountDown_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            // Show MessageBox
            DialogResult result = MessageBox.Show("Bạn có muốn xuất file ra Excel không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Export to Excel
                ExportToExcel(selectedMaHoaDon);
            }
            else
            {
                // Exit the application
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsConfirmed = false;
            this.Close();
        }

        private void ExportToExcel(string maHoaDon)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("InvoiceDetails");

                // Add headers
                worksheet.Cell(1, 1).Value = "MaHoaDon";
                worksheet.Cell(1, 2).Value = "DonGia";
                worksheet.Cell(1, 3).Value = "SoLuong";
                worksheet.Cell(1, 4).Value = "Sdtkh";
                worksheet.Cell(1, 5).Value = "TenKhachHang";

                // Retrieve the invoice details for the selected MaHoaDon
                var invoiceDetails = GetInvoiceDetails(maHoaDon);

                if (invoiceDetails != null)
                {
                    // Add invoice details
                    worksheet.Cell(2, 1).Value = invoiceDetails.MaHoaDon;
                    worksheet.Cell(2, 2).Value = invoiceDetails.DonGia;
                    worksheet.Cell(2, 3).Value = invoiceDetails.SoLuong;
                    worksheet.Cell(2, 4).Value = invoiceDetails.Sdtkh;
                    worksheet.Cell(2, 5).Value = invoiceDetails.TenKhachHang;

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Save an Excel File";
                        saveFileDialog.FileName = "InvoiceDetails.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Save the workbook
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);

                            MessageBox.Show("File đã được xuất thành công: " + filePath, "Thông báo");

                            // Close the form
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn với mã: " + maHoaDon, "Lỗi");
                }
            }
        }

        // Method to get invoice details (you need to implement this)
        private InvoiceDetails GetInvoiceDetails(string maHoaDon)
        {
            // Replace with actual data retrieval logic
            // Example:
            // var invoiceDetails = dbContext.Invoices.FirstOrDefault(i => i.MaHoaDon == maHoaDon);
            return new InvoiceDetails
            {
                MaHoaDon = "HD001",  // Replace with actual MaHoaDon
                DonGia = 1000000,    // Replace with actual DonGia
                SoLuong = 5,         // Replace with actual SoLuong
                Sdtkh = "0123456789",// Replace with actual Sdtkh
                TenKhachHang = "Nguyen Van A" // Replace with actual TenKhachHang
            };
        }
    }
}
