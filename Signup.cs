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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void signup_btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_password_signup_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password_signup.UseSystemPasswordChar = false;
        }

        private void pictureBox_password_signup_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password_signup.UseSystemPasswordChar = true;
        }

        private void btn_loginhere_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string username = txtUsername_Signup.Text;
            string password = txt_password_signup.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Hãy điền đủ các trường thông tin.");
                return;
            }

            using (var context = new MyContext())
            {
                // Kiểm tra xem tên đăng nhập đã tồn tại hay chưa
                var existingUser = context.NhanViens.FirstOrDefault(nv => nv.Username == username);
                if (existingUser != null)
                {
                    MessageBox.Show("Username đã tồn tại.");
                    return;
                    var newUser = new NhanVien
                    {
                        Username = username,
                        Password = password,
                    };

                    context.NhanViens.Add(newUser);
                    context.SaveChanges();

                    MessageBox.Show("Tài khoản của bạn đã được tạo thành công!");
                }

            }
        }

        
    }
}
