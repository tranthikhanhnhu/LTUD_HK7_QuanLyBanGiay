using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class bllGiay
    {
        dalGiay dalGiay = new dalGiay();
        public DataTable HienThiDanhSachGiay()
        {
            return dalGiay.HienThiDanhSach();
        }

        public List<string> DanhSachMaGiay()
        {
            return dalGiay.DanhSachMaGiay();
        }

        public bool ThemGiay(dtoGiay giay)
        {
            return dalGiay.ThemGiay(giay);
        }

        public bool XoaGiay(string ma)
        {
            return dalGiay.XoaGiay(ma);
        }    

        public bool SuaGiay(dtoGiay giay)
        {
            return dalGiay.SuaGiay(giay);
        }

        public DataTable TimKiemVoiMaGiay(string ma)
        {
            return dalGiay.HienThiDanhSachTimKiem(ma);
        }

        public DataTable TimKiemVoiTen(string ten)
        {
            return dalGiay.HienThiDanhSachTimKiem(ten);
        }

        public DataTable TimKiemVoiSize(double size, string str)
        {
            return dalGiay.HienThiDanhSachTimKiem(size, str);
        }

        public DataTable TimKiemVoiGia(double gia, string str)
        {
            return dalGiay.HienThiDanhSachTimKiem(gia, str);
        }
    }
}
