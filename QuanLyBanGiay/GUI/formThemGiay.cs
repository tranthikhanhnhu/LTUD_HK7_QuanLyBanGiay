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
    public partial class formThemGiay : Form
    {
        public formThemGiay()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bllGiay giayBll = new bllGiay();
            bool flag = true;
            string id;

            id = txtMa.Text.Trim();
            foreach (string ma in giayBll.DanhSachMaGiay())
            {
                if (id.Equals(ma))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                if (id != "" && txtTen.Text.Trim() != "" && txtMau.Text.Trim() != "" && txtGia.Text.Trim() != "" && cbSize.SelectedItem.ToString() != "" && numSoluong.Value.ToString() != "")
                {
                    dtoGiay giay = new dtoGiay();
                    giay.MaGiay = txtMa.Text.Trim();
                    giay.TenGiay = txtTen.Text.Trim();
                    giay.NSX = txtHang.Text.Trim();
                    giay.Size = double.Parse(cbSize.SelectedItem.ToString());
                    giay.Mau = txtMau.Text.Trim();
                    giay.SoLuong = int.Parse(numSoluong.Value.ToString());
                    giay.Gia = double.Parse(txtGia.Text.Trim());

                    if (giayBll.ThemGiay(giay))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập thông tin đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Mã giày đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
