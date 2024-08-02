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
    public partial class QLSoLuong : Form
    {
        public int SelectedQuantity { get; private set; }
        public QLSoLuong()
        {
            InitializeComponent();
        }

        private void QLSoLuong_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_chonsoluong.Text, out int quantity) && quantity > 0)
            {
                SelectedQuantity = quantity;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
