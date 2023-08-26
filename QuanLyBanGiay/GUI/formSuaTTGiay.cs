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
    public partial class formSuaTTGiay : Form
    {
        private dtoGiay giay;

        public formSuaTTGiay()
        {
            InitializeComponent();
        }

        public formSuaTTGiay(dtoGiay giay)
        {
            this.giay = giay;
            InitializeComponent();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() != "" && txtMau.Text.Trim() != "" && txtGia.Text.Trim() != "" && cbSize.SelectedItem.ToString() != "" && numSoLuong.Value.ToString() != "")
            {
                dtoGiay giay = new dtoGiay();
                giay.MaGiay = this.giay.MaGiay;
                giay.TenGiay = txtTen.Text.Trim();
                giay.NSX = txtNSX.Text.Trim();
                giay.Size = double.Parse(cbSize.SelectedItem.ToString());
                giay.Mau = txtMau.Text.Trim();
                giay.SoLuong = int.Parse(numSoLuong.Value.ToString());
                giay.Gia = double.Parse(txtGia.Text.Trim());

                bllGiay giayBll = new bllGiay();

                if (giayBll.SuaGiay(giay))
                {
                    MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Vui long nhập thông tin đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formSuaTTGiay_Load(object sender, EventArgs e)
        {
            txtMa.Text = giay.MaGiay;
            txtTen.Text = giay.TenGiay;
            txtNSX.Text = giay.NSX;
            txtMau.Text = giay.Mau;
            txtGia.Text = giay.Gia+"";
            cbSize.Text = giay.Size+"";
            numSoLuong.Value = giay.SoLuong;

        }
    }
}
