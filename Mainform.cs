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
    public partial class Mainform : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        private string userRole; // Lưu tên chức vụ
        private string currentUsername;


        public Mainform(bool isAdmin, string username)
        {
            InitializeComponent();
            this.userRole = isAdmin ? "admin" : "user"; // Gán quyền của người dùng
            this.currentUsername = username;
        }
       
        private Form formchild_hientai;
        private void openChildForm(Form childForm)
        {
            if (formchild_hientai != null)
            {
                formchild_hientai.Close();
            }
            formchild_hientai = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Ql_Banhang(currentUsername));
        }

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_QL_Hanghoa());
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            if (userRole == "admin")
            {
                openChildForm(new Form_QL_Nhanvien());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (formchild_hientai != null)
            {
                formchild_hientai.Close();
            }
        }

        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("bạn muốn thoát chương trình", "cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_BaoCaoThongKe());
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_QL_KhachHang());
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_QL_NhaCungCap());
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_QL_NhapHang());
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
