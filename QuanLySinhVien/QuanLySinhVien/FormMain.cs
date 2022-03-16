using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput();
                double a = double.Parse(txtNhapA.Text.Trim());
                double b = double.Parse(txtNhapB.Text.Trim());
                double c = double.Parse(txtNhapC.Text.Trim());
                string nghiem = PTB2(a, b, c);
                txtKetQua.Text = nghiem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string PTB2(double a, double b, double c)
        {
            #region Cach1
            //try
            //{
            //    double a = NhapSo("Nhap So a:");
            //    double b = NhapSo("Nhap So b:");
            //    double c = NhapSo("Nhap So c:");
            //    if (a == 0)
            //    {
            //        //Console.WriteLine("PTB1");
            //        //return;
            //        //throw new Exception("PTB1");
            //        PhuongTrinhBac1(b, c);
            //        return;
            //    }
            //    double detal = Math.Pow(b, 2) - 4 * a * c;
            //    if (detal < 0)
            //    {
            //        throw new Exception("PT VN");
            //    }
            //    double x1 = (-b + Math.Sqrt(detal)) / (2 * a);
            //    double x2 = (-b - Math.Sqrt(detal)) / (2 * a);
            //    Console.WriteLine("Nghiem 1 {0}", x1);
            //    Console.WriteLine("Nghiem 2 {0}", x2);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region Cach 2
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d<0)
            {
                return string.Format("Phuong Trinh Vo Nghiem");

            }
            double x1 = (-b + Math.Sqrt(d))/(2*a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return string.Format("x1={0}, \n x2={1}", x1, x2);
            #endregion
        }

        private void CheckInput()
        {
            #region Kiem Tra Da Nhap Data
            string soA = txtNhapA.Text.Trim(); //Trim xoa khoang trang o 2 dau
            if (soA == "")
            {
                txtNhapA.Focus();
                throw new Exception("So A nhap khong hop le!");
            }
            string soB = txtNhapB.Text.Trim();
            if (soB == "")
            {
                txtNhapB.Focus();
                throw new Exception("So B nhap khong hop le!");
            }
            string soC = txtNhapC.Text.Trim();
            if (soC == "")
            {
                txtNhapC.Focus();
                throw new Exception("So C nhap khong hop le!");
            }
            #endregion
            #region Kiem Tra Nhap Co Phai La So Khong
            double a, b, c;
            if (double.TryParse(soA, out a) == false)
            {
                txtNhapA.Focus();
                txtNhapA.SelectAll();
                throw new Exception("So A Khong Hop Le!");
            }
            if (double.TryParse(soB, out b) == false)
            {
                txtNhapB.Focus();
                txtNhapB.SelectAll();
                throw new Exception("So B Khong Hop Le!");
            }
            if (double.TryParse(soC, out c) == false)
            {
                txtNhapC.Focus();
                txtNhapC.SelectAll();
                throw new Exception("So C Khong Hop Le!");
            }
            #endregion

        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
            txtNhapC.Text = "";
            txtKetQua.Text = "";
        }
    }
}
