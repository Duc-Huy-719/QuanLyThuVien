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
    public partial class frmThongKeSach : Form
    {
        public frmThongKeSach()
        {
            InitializeComponent();
        }
        Connection t = new Connection();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select Sach.MaSach, Sach.TenSach, NhaXuatBan.TenNXB,Sach.NamXB,TheLoai.TenTL from Sach, NhaXuatBan, TheLoai where (Sach.MaNXB=NhaXuatBan.MaNXB and Sach.MaTL=TheLoai.MaTL)");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
           luoi.Columns[4].HeaderText = "Thể loại";
          //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select Sach.MaSach,Sach.TenSach, NhaXuatBan.TenNXB,sach.NamXB,TheLoai.TenTL from Sach, NhaXuatBan,ChiTietPhieuMuon, TheLoai where (Sach.MaNXB=NhaXuatBan.MaNXB and Sach.MaTL=TheLoai.MaTL and Sach.MaSach=ChiTietPhieuMuon.MaSach)");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
            luoi.Columns[4].HeaderText = "Thể loại";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void loaddata2()
        {
            DataTable dt = t.docdulieu("select Sach.MaSach,Sach.TenSach, NhaXuatBan.TenNXB,Sach.NamXB,TheLoai.TenTL from Sach, NhaXuatBan,ChiTietPhieuMuon, TheLoai where (Sach.MaNXB=NhaXuatBan.MaNXB and Sach.MaTL=TheLoai.MaTL and Sach.MaSach=ChiTietPhieuMuon.MaSach and ChiTietPhieuMuon.NgayHenTra<GETDATE())");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
            luoi.Columns[4].HeaderText = "Thể loại";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void Formthongkesach_Load(object sender, EventArgs e)
        {
            tuychon.Text = "Tất cả sách";

            loaddata();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tuychon.Text == "Tất cả sách")
                loaddata();
            else if (tuychon.Text == "Sách đang mượn")
                loaddata1();
            else loaddata2();


            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            
            DataTable dt = (DataTable)luoi.DataSource;
            excel.Export(dt, "Sách", "Thống kê sách");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void tuychon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
