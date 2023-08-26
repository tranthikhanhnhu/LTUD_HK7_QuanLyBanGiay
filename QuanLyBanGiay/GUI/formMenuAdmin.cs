using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class formMenuAdmin : Form
    {
        private dtoTaiKhoan tk;
        private formDangNhap dn;
        private Form currentFormChild;

        public formMenuAdmin()
        {
            InitializeComponent();
        }

        public formMenuAdmin(dtoTaiKhoan tk, formDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }

        private void openFormChild(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pBody.Controls.Add(childForm);
            pBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            dn.Show();
            Close();
        }

        private void btGiay_Click(object sender, EventArgs e)
        {
            openFormChild(new formDanhSachGiay());
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            openFormChild(new formHDNhapGiay());
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            openFormChild(new formDanhSachNhanVien());
        }

        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            dtoNhanVien nv = new dtoNhanVien();
            bllNhanVien busNV = new bllNhanVien();

            nv.MaNhanVien = busNV.NhanVien(tk).MaNhanVien;
            nv.TenNV = busNV.NhanVien(tk).TenNV;
            nv.NgaySinh = busNV.NhanVien(tk).NgaySinh;
            nv.SDT = busNV.NhanVien(tk).SDT;

            openFormChild(new formThongTin(nv));
        }

        private void ctrClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
