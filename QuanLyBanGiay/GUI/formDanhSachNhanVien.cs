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
    public partial class formDanhSachNhanVien : Form
    {
        private bllNhanVien nv;
        private dtoNhanVien current;

        public formDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void formDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            nv = new bllNhanVien();
            dtList.DataSource = nv.HienThiDanhSachGiay();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            formThemNV them = new formThemNV();
            them.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int Lsize = dtList.RowCount;
            if (Lsize == 0)
            {
                MessageBox.Show("Danh sách giày rỗng, Không có đối tượng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (current != null)
            {
                DataGridViewRow row = dtList.SelectedRows[0];

                string MaNhanVien = row.Cells[0].Value.ToString();
                string TenNV = row.Cells[1].Value.ToString();
                DateTime NgaySinh = DateTime.Parse(row.Cells[2].Value.ToString());
                string SDT = row.Cells[3].Value.ToString();

                current = new dtoNhanVien(MaNhanVien, TenNV, NgaySinh, SDT);

                if (nv.XoaGiay(MaNhanVien))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtList.DataSource = nv.HienThiDanhSachGiay();
                }
            }
            else
            {
                MessageBox.Show("Đối tượng không xác định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtList_Click(object sender, EventArgs e)
        {
            int Lsize = dtList.RowCount;

            if (Lsize != 0)
            {
                DataGridViewRow row = dtList.SelectedRows[0];

                string MaNhanVien = row.Cells[0].Value.ToString();
                string TenNV = row.Cells[1].Value.ToString();
                DateTime NgaySinh = DateTime.Parse(row.Cells[2].Value.ToString());
                string SDT = row.Cells[3].Value.ToString();

                current = new dtoNhanVien(MaNhanVien, TenNV, NgaySinh, SDT);
            }
        }
    }
}
