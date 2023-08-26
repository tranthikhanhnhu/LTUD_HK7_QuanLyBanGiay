using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class bllTaiKhoan
    {
        dalTaiKhoan dtk = new dalTaiKhoan();

        public bool DangNhap(dtoTaiKhoan tk)
        {           
            return dtk.KiemTraDangNhap(tk);
        }

        public dtoTaiKhoan TaiKhoanDangNhap(dtoTaiKhoan tk)
        {
            return dtk.TaiKhoanDangNhap(tk);
        }

        public bool ThemTK(dtoTaiKhoan tk)
        {
            return dtk.ThemTK(tk);
        }
    }
}
