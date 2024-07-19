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
    public partial class Mainform : Form
    {   
        public bool isExit = true;
        public event EventHandler Logout;


        public Mainform()
        {
            InitializeComponent();
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
            openChildForm(new Form_Ql_Banhang());
        }

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_QL_Hanghoa());
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_QL_Nhanvien());
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
    }
}
