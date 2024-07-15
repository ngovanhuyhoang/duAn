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
    }
}
