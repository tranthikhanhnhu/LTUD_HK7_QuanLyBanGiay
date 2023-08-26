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
    public partial class formHDNhapGiay : Form
    {
        private bllHoaDonNhapGiay bllHD;

        public formHDNhapGiay()
        {
            InitializeComponent();
        }

        private void formHDNhapGiay_Load(object sender, EventArgs e)
        {
            bllHD = new bllHoaDonNhapGiay();
            dtList.DataSource = bllHD.HienThiDanhHoaDon();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            formThemHD them = new formThemHD();
            them.ShowDialog();
        }
    }
}
