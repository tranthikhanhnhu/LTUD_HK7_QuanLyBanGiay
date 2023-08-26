using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoGiay
    {
        private string _ma;
        private string _ten;
        private string _nsx;
        private double _size;
        private string _mau;
        private int _sLuong;
        private double _gia;

        public dtoGiay(string ma, string ten, string nsx, double size, string mau, int sLuong, double gia)
        {
            _ma = ma;
            _ten = ten;
            _nsx = nsx;
            _size = size;
            _mau = mau;
            _sLuong = sLuong;
            _gia = gia;
        }

        public dtoGiay()
        {
        }

        public string MaGiay { get; set; }
        public string TenGiay { get; set; }
        public string NSX { get; set; }
        public double Size { get; set; }
        public string Mau { get; set; }
        public int SoLuong { get; set; }
        public double Gia { get; set; }
    }
}
