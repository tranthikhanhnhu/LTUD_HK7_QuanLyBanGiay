using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class dalKhachHang : Database
    {
        public List<string> DanhSachMaKH()
        {
            List<string> ds = new List<string>();
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT [Mã khách hàng] FROM [Khách hàng]";
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

        public dtoKhachHang KhachHang(string ten)
        {
            dtoKhachHang kh = new dtoKhachHang();
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM [Khách hàng] WHERE [Tên khách hàng] = @ten";
            sqlCmd.Connection = sqlCon;

            SqlParameter parMa = new SqlParameter("@ten", SqlDbType.Char);
            parMa.Value = ten;
            sqlCmd.Parameters.Add(parMa);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string tenkh = (string)reader.GetSqlString(1);
                string diachi = (string)reader.GetSqlString(2);
                string sdt = reader.GetString(3);

                kh.MaKH = ma;
                kh.Ten = tenkh;
                kh.DiaChi = diachi;
                kh.SDT = sdt;

            }
            reader.Close();
            return kh;
        }

        public List<string> DanhSachTenKH()
        {
            List<string> ds = new List<string>();
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT [Tên khách hàng] FROM [Khách hàng]";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string ten = (string) reader.GetSqlString(0);

                ds.Add(ten);
            }
            reader.Close();
            return ds;

        }

        public bool ThemKH(dtoKhachHang kh)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO [Khách hàng] VALUES (@ma, @ten, @diachi, @sdt)";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
            parMa.Value = kh.MaKH;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.VarChar);
            parTen.Value = kh.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parDiachi = new SqlParameter("@diachi", SqlDbType.VarChar);
            parDiachi.Value = kh.DiaChi;
            sqlCmd.Parameters.Add(parDiachi);

            SqlParameter parSDT = new SqlParameter("@sdt", SqlDbType.Int);
            parSDT.Value = kh.SDT;
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
    }
}
