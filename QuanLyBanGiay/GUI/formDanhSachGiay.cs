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
    public partial class formDanhSachGiay : Form
    {

        private bllGiay giayBll;

        private dtoGiay current = new dtoGiay() ;

        public formDanhSachGiay()
        {
            InitializeComponent();
        }

        private void formDanhSachGiay_Load(object sender, EventArgs e)
        {
            //Khởi tạo đối tượng bllGiay mới
            giayBll = new bllGiay();
            //Đưa các giá trị lên DataGridView bằng các giá trị có trong DataTable
            dtList.DataSource = giayBll.HienThiDanhSachGiay();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            formThemGiay themGiay = new formThemGiay();
            themGiay.ShowDialog();
            dtList.DataSource = giayBll.HienThiDanhSachGiay();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int Lsize = dtList.RowCount-1;
            if (Lsize == 0)
            {
                MessageBox.Show("Danh sách giày rỗng, vui lòng thêm thông tin giày trước khi thực hiện thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                formSuaTTGiay sua = new formSuaTTGiay(current);
                sua.ShowDialog();
                dtList.DataSource = giayBll.HienThiDanhSachGiay();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int Lsize = dtList.RowCount-1;
            if (Lsize == 0)
            {
                MessageBox.Show("Danh sách giày rỗng, Không có đối tượng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (current != null)
            {
                if (giayBll.XoaGiay(current.MaGiay))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtList.DataSource = giayBll.HienThiDanhSachGiay();
                }
            }
            else
            {
                MessageBox.Show("Đối tượng không xác định!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtFind.Text.Trim() == "")
            {
                dtList.DataSource = giayBll.HienThiDanhSachGiay();
            }
            else
            {
                if(cbOP.SelectedItem.ToString().Equals("Mã giày"))
                {
                    string str = "%" + txtFind.Text.Trim() + "%";
                    dtList.DataSource = giayBll.TimKiemVoiMaGiay(str);
                } 
                else if(cbOP.SelectedItem.ToString().Equals("Tên giày"))
                {
                    string str = "%" + txtFind.Text.Trim() + "%";
                    dtList.DataSource = giayBll.TimKiemVoiTen(str);
                }
                else if (cbOP.SelectedItem.ToString().Equals("Size"))
                {
                    double val = double.Parse(txtFind.Text.Trim());
                    dtList.DataSource = giayBll.TimKiemVoiSize(val, cbOP.SelectedItem.ToString());
                }
                else if(cbOP.SelectedItem.ToString().Equals("Giá"))
                {
                    double val = double.Parse(txtFind.Text.Trim());
                    dtList.DataSource = giayBll.TimKiemVoiGia(val, cbOP.SelectedItem.ToString());
                }
            }
        }

        private void dtList_Click(object sender, EventArgs e)
        {

            int Lsize = dtList.RowCount-1;

            if (Lsize != 0)
            {
                DataGridViewRow row = dtList.SelectedRows[0];

                current.MaGiay = row.Cells[0].Value.ToString();
                current.TenGiay = row.Cells[1].Value.ToString();
                current.NSX = row.Cells[2].Value.ToString();
                current.Size = double.Parse(row.Cells[3].Value.ToString());
                current.Mau = row.Cells[4].Value.ToString();
                current.SoLuong = int.Parse(row.Cells[5].Value.ToString());
                current.Gia = double.Parse(row.Cells[6].Value.ToString());
            }
        }
    }
}
