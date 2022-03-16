using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //admin
            //123456
            try
            {
                string taikhoan = txtTaiKhoan.Text;
                string matkhau = txtMatKhau.Text;
                if (taikhoan != "admin" || matkhau != "123456")
                {
                    throw new Exception("Tai Khoan / Mat Khau Khong Hop Le!");
                }
                throw new Exception("Dang Nhap Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var kiemtra = MessageBox.Show( "Ban co muon thoat khong?",
                "Thong Bao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (kiemtra !=DialogResult.Yes)
            {
                e.Cancel = true;
            }
            
        }
    }
}
