using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class formHDBanGiay : Form
    {
        private bllHoaDonBan bllHD;

        public formHDBanGiay()
        {
            InitializeComponent();
        }

        private void formHDBanGiay_Load(object sender, EventArgs e)
        {
            bllHD = new bllHoaDonBan();
            dtList.DataSource = bllHD.HienThiDanhHoaDon();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            formThemHD hd = new formThemHD();
            hd.ShowDialog();
        }
    }
}
