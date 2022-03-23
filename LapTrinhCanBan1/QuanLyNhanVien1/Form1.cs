using QuanLyNhanVien1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NhanVien ti = new NhanVien()
            {
                Id = Guid.NewGuid(),
                Name = "Ti Tran Van",
                BOD = new DateTime(2000, 1, 1),
                Address = "HCM",
                Email = "Titv@gamil.com",
                Phone = "08000000",
                Username = "Titv",
                Password = "Titv123"

            };
            NhanVien teo = new NhanVien()
            {
                Id = Guid.NewGuid(),
                Name = "Teo Nguyen Van",
                BOD = new DateTime(2000, 1, 1),
                Address = "HCM",
                Email = "Teonv@gamil.com",
                Phone = "09000000",
                Username = "Teonv",
                Password = "Teonv123"

            };
            //List<NhanVien> dsNhanVien = new List<NhanVien>();
            //dsNhanVien.Add(ti);
            //dsNhanVien.Add(teo);
            NhanVien.DSNhanVien(ti);
            NhanVien.DSNhanVien(teo);
            dgvDSNhanVien.DataSource = NhanVien.DSNhanVien().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = CheckInput();
                NhanVien.DSNhanVien(nv);
                MessageBox.Show(nv.Id.ToString());
                dgvDSNhanVien.DataSource = NhanVien.DSNhanVien().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Kiem Tra Data
        /// </summary>
        private NhanVien CheckInput()
        {
            if (txtName.Text == "")
            {
                txtName.Focus();
                throw new Exception("Ban chua nhap ho ten");
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                throw new Exception("Ban chua nhap email");
            }
            if (txtPhone.Text == "")
            {
                txtPhone.Focus();
                throw new Exception("Ban chua nhap sdt");
            }
            if (txtAddress.Text == "")
            {
                txtAddress.Focus();
                throw new Exception("Ban chua nhap dia chi");
            }
            if (txtUsername.Text == "")
            {
                txtUsername.Focus();
                throw new Exception("Ban chua nhap username");
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                throw new Exception("Ban chua nhap password");
            }
            NhanVien nv = new NhanVien()
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                BOD = dtpBOD.Value,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Id = Guid.NewGuid()
            };
            return nv;
        }
    }
}
