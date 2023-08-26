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
    public partial class formThemHD : Form
    {
        private Random random = new Random();
        public formThemHD()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bllHoaDonBan hd = new bllHoaDonBan();
            bllKhachHang kh = new bllKhachHang();
            bllGiay giay = new bllGiay();

            bool flag1;
            bool flag2 = true;
            bool flag3;
            bool flag4 = false;
            string id;
            string makh;

            do
            {
                flag1 = true;
                id = 1000 + random.Next(1000) + "";
                foreach (string ma in hd.DanhSachMaHD())
                {
                    if (id.Equals(ma))
                    {
                        flag1 = false;
                        break;
                    }
                }

            } while (!flag1);

            string maGiay = txtMaGiay.Text.Trim();

            foreach (string maG in giay.DanhSachMaGiay())
            {
                if (maGiay.Equals(maG))
                {
                    flag4 = true;
                    break;
                }
            }

            string ten = txtTen.Text.Trim();

            foreach (string tenkh in kh.DanhSachTenKH())
            {
                if (ten.Equals(tenkh))
                {
                    flag2 = false;
                    break;
                }
            }

            if (flag1 && flag4)
            {
                dtoHoaDonBanGiay hoaDonBanGiay = new dtoHoaDonBanGiay();

                if(!flag2)
                {
                    makh = kh.KhachHang(ten).Ten;
                }
                else
                {

                    do
                    {
                        flag3 = true;
                        makh = 1000 + random.Next(1000) + "";
                        foreach (string idkh in kh.DanhSachMaKH())
                        {
                            if (makh.Equals(idkh))
                            {
                                flag3 = false;
                                break;
                            }
                        }

                    } while (!flag3);

                    dtoKhachHang dtoKhachHang = new dtoKhachHang();
                    dtoKhachHang.MaKH = makh;
                    dtoKhachHang.Ten = ten;
                    dtoKhachHang.DiaChi = txtDiaChi.Text.Trim();
                    dtoKhachHang.SDT = txtSDT.Text.Trim();

                    kh.ThemKH(dtoKhachHang);
                }

                hoaDonBanGiay.MaHoaDon = id;
                hoaDonBanGiay.MaKH = makh;
                hoaDonBanGiay.MaGiay = maGiay;
                hoaDonBanGiay.Soluong = int.Parse(numSoluong.Value.ToString());

                if(hd.ThemHD(hoaDonBanGiay))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã giày không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
