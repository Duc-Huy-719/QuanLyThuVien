using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        Connection t = new Connection();
        string user = "admin";
        string pass = "123456";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khản");
                txtTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bận chưa nhập mật khẩu");
                txtMatKhau.Focus();
            }
            else if (user.Equals(txtTaiKhoan.Text) && pass.Equals(txtMatKhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Form f = new Formchinh();
                f.Show();
            }
            else { MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai"); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
