using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmTimKiemSach : Form
    {
        public frmTimKiemSach()
        {
            InitializeComponent();
        }
        Connection t = new Connection();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from Sach");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Năm xuất bản";
            luoi.Columns[3].HeaderText = "Mã nhà xuất bản";
            luoi.Columns[4].HeaderText = "Mã thể loại";
            luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
       
            luoi.Enabled = true;

        }
        private void Formtimkiemsach_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from sach where MaSach like '%" + txttimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from Sach where TenSach like '%" + txttimkiem.Text + "%'");
            if (ramasach.Checked == true)
            {
                luoi.DataSource = dt5;
            }
            else luoi.DataSource = dt6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
