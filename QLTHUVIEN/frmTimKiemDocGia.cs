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
    public partial class frmTimKiemDocGia : Form
    {
        public frmTimKiemDocGia()
        {
            InitializeComponent();
        } Connection t = new Connection();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from docgia");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã độc giả";
            luoi.Columns[1].HeaderText = "Họ và tên";
            luoi.Columns[2].HeaderText = "Ngày sinh";
            luoi.Columns[3].HeaderText = "Giới tính";
            luoi.Columns[4].HeaderText = "Lớp";



            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            
            luoi.Enabled = true;

        }
        private void Formtimkiemdocgia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from DocGia where MaDG like '%" + txttimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from DocGia where TenDG like '%" + txttimkiem.Text + "%'");
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
