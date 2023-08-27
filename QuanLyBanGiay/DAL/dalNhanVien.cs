using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class dalNhanVien : Database
    {
        public dtoNhanVien NhanVienDangNhap(dtoTaiKhoan tk)
        {
            dtoNhanVien nv = new dtoNhanVien();
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM [Nhân viên] WHERE [Mã Nhân viên] = @ma";
            sqlCmd.Connection = sqlCon;

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Char);
            parMa.Value = tk.Username;
            sqlCmd.Parameters.Add(parMa);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = (string)reader.GetSqlString(1);
                DateTime ngaySinh = reader.GetDateTime(2);
                string sdt = reader.GetString(3);

                nv.MaNhanVien = ma;
                nv.TenNV = ten;
                nv.NgaySinh = ngaySinh;
                nv.SDT = sdt;

            }
            reader.Close();
            return nv;
        }

        public List<string> DanhSachID()
        {
            List<string> ds = new List<string>();
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from [Nhân viên]";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader.GetString(0);

                ds.Add(ma);
            }
            reader.Close();
            return ds;

        }

        public DataTable HienThiDanhSach()
        {
            OpenConnection();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Nhân viên]", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CloseConnection();
            return dt;
        }

        public bool ThemNV(dtoNhanVien nv)
        {
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO [Nhân viên] VALUES (@ma, @ten, @ngaysinh, @sdt)";
            sqlCmd.Connection = sqlCon;

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
            parMa.Value = nv.MaNhanVien;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = nv.TenNV;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parNS = new SqlParameter("@ngaysinh", SqlDbType.Date);
            parNS.Value = nv.NgaySinh;
            sqlCmd.Parameters.Add(parNS);

            SqlParameter parSDT = new SqlParameter("@sdt", SqlDbType.VarChar);
            parSDT.Value = nv.SDT;
            sqlCmd.Parameters.Add(parSDT);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool XoaNV(string ma)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "Xoa_NV";
            sqlCmd.Parameters.AddWithValue("@MaNhanVien", ma);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
