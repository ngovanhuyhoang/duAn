using Dal_da1.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dal_da1.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DA1_formLogin
{
    public partial class Login : Form
    {
        NhanVien NhanVien = new NhanVien();
        private MyContext dbcontext;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_password_Login_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password_login.UseSystemPasswordChar = false;
        }

        private void pictureBox_password_Login_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password_login.UseSystemPasswordChar = true;
        }

        private void btn_registerhere_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            using (var context = new MyContext())
            {
                string username = txt_Login_Username.Text;
                string password = txt_password_login.Text;

                var user = context.NhanViens
                                  .Where(nv => nv.Username == username && nv.Password == password && nv.DaThoiViec == false)
                                  .FirstOrDefault();

                if (user != null)
                {
                    bool isAdmin = user.TenChucVu == "Admin"; // Kiểm tra quyền của người dùng

                    Mainform mainform = new Mainform(isAdmin);
                    mainform.Show();
                    this.Hide();
                    mainform.Logout += Mainform_Logout;
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }


        }

        private void Mainform_Logout(object? sender, EventArgs e)
        {
            (sender as Mainform).isExit = false;
            (sender as Mainform).Close();
            this.Show();
        }

        private void btn_forgotpass_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("có mỗi cái mật khẩu cũng quên :))");
        }
    }
}
