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
    public partial class formThongTin : Form
    {
        private dtoNhanVien nv;

        public formThongTin()
        {
            InitializeComponent();
        }

        public formThongTin(dtoNhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        private void formThongTin_Load(object sender, EventArgs e)
        {
            txtID.Text = nv.MaNhanVien;
            txtTen.Text = nv.TenNV;
            dtNSinh.Value = nv.NgaySinh;
            txtSDT.Text = nv.SDT;
        }
    }
}
