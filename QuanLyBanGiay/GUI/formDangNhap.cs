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
    public partial class formDangNhap : Form
    {
        private formDangNhap dn;

        public formDangNhap()
        {
            InitializeComponent();
        }

        private void ctrClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            dtoTaiKhoan tk = new dtoTaiKhoan();
            tk.Username = txtUser.Text.Trim();
            tk.Password = txtPass.Text.Trim();

            dn = this;

            //Kiểm tra đối tượng đăng nhập
            bllTaiKhoan btk = new bllTaiKhoan();
            bool kt = btk.DangNhap(tk);

            //Nếu đúng thực hiện chuyển đổi form
            if (kt)
            {
                string admin = btk.TaiKhoanDangNhap(tk).ChucVu;
                dn = this;
                if(admin == "Admin")
                {
                    Hide();
                    txtPass.Clear();
                    formMenuAdmin mna = new formMenuAdmin(tk, dn);
                    mna.ShowDialog();
                }
                else
                {
                    Hide();
                    txtPass.Clear();
                    formMenu mn = new formMenu(tk,dn);
                    mn.ShowDialog();
                }
            }
            else
            {
                //hiển thị thông báo khi mật khẩu hoặc tên đăng nhập sai
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
