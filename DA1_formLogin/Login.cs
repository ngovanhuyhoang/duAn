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
    public partial class Login : Form
    {
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
            Mainform mainform = new Mainform();
            mainform.Show();
            
        }
    }
}
