using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAL;

namespace BLL
{
    public class bllKhachHang
    {
        dalKhachHang dalKH = new dalKhachHang();
        public List<string> DanhSachMaKH()
        {
            return dalKH.DanhSachMaKH();
        }

        public dtoKhachHang KhachHang(string ten)
        {
            return dalKH.KhachHang(ten);
        }

        public List<string> DanhSachTenKH()
        {
            return dalKH.DanhSachTenKH();
        }

        public bool ThemKH(dtoKhachHang kh)
        {
            return dalKH.ThemKH(kh);
        }

    }
}
