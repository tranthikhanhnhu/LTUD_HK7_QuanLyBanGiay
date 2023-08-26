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
    public partial class formThemNV : Form
    {
        public formThemNV()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string id;
            bllNhanVien bllNhanVien = new bllNhanVien();
            bllTaiKhoan bllTaiKhoan = new bllTaiKhoan();

            id = txtID.Text.Trim();
            foreach (string ma in bllNhanVien.DanhSachID())
            {
                if (id.Equals(ma))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                if (id != "" && txtTen.Text.Trim() != "" && txtSDT.Text.Trim() != "" && txtMK.Text.Trim()!="")
                {
                    dtoNhanVien nv = new dtoNhanVien();
                    nv.MaNhanVien = txtID.Text.Trim();
                    nv.TenNV = txtTen.Text.Trim();
                    nv.NgaySinh = dtNSinh.Value.Date;
                    nv.SDT = txtSDT.Text.Trim();

                    dtoTaiKhoan taiKhoan = new dtoTaiKhoan();
                    taiKhoan.Username = txtID.Text.Trim();
                    taiKhoan.Password = txtMK.Text.Trim();
                    if (chkAdmin.Checked) 
                    {
                        taiKhoan.ChucVu = "Admin";
                    }
                    else
                    { 
                        taiKhoan.ChucVu = "";
                    }

                    if (bllNhanVien.ThemNV(nv) && bllTaiKhoan.ThemTK(taiKhoan))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập thông tin đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Mã giày đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
