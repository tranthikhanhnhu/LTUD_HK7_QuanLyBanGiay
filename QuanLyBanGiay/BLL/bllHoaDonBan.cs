using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class bllHoaDonBan
    {
        dalHoaDonBanGiay dalHD = new dalHoaDonBanGiay();

        public DataTable HienThiDanhHoaDon()
        {
            return dalHD.HienThiDanhSach();
        }

        public List<string> DanhSachMaHD()
        {
            return dalHD.DanhSachMaHD();
        }

        public bool ThemHD(dtoHoaDonBanGiay hd)
        {
            return dalHD.ThemHD(hd);
        }
    }
}
