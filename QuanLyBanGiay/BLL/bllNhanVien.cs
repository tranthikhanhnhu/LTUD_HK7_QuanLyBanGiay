using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class bllNhanVien
    {
        dalNhanVien nv = new dalNhanVien();
        public dtoNhanVien NhanVien(dtoTaiKhoan tk)
        {
            return nv.NhanVienDangNhap(tk);
        }

        public List<string> DanhSachID()
        {
            return nv.DanhSachID();
        }

        public DataTable HienThiDanhSachGiay()
        {
            return nv.HienThiDanhSach();
        }

        public bool ThemNV(dtoNhanVien nv)
        {
            return this.nv.ThemNV(nv);
        }

        public bool XoaGiay(string ma)
        {
            return nv.XoaNV(ma);
        }
    }
}
