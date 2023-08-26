using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class dalHoaDonBanGiay:Database
    {
        public DataTable HienThiDanhSach()
        {
            OpenConnection();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Giày INNER JOIN [Hóa đơn bán hàng] ON Giày.[Mã giày] = [Hóa đơn bán hàng].[Mã giày] INNER JOIN [Khách hàng] ON [Hóa đơn bán hàng].[Mã khách hàng] = [Khách hàng].[Mã khách hàng]", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CloseConnection();
            return dt;
        }

        public DataTable HienThiDanhSachTimKiem(string ma)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Giày INNER JOIN [Hóa đơn bán hàng] ON Giày.[Mã giày] = [Hóa đơn bán hàng].[Mã giày] INNER JOIN [Khách hàng] ON [Hóa đơn bán hàng].[Mã khách hàng] = [Khách hàng].[Mã khách hàng] WHERE [Mã hóa đơn] = @ma";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
            parMa.Value = ma;
            sqlCmd.Parameters.Add(parMa);

            sqlCmd.Connection = sqlCon;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CloseConnection();
            return dt;
        }

        public List<string> DanhSachMaHD()
        {
            List<string> ds = new List<string>();
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Giày INNER JOIN [Hóa đơn bán hàng] ON Giày.[Mã giày] = [Hóa đơn bán hàng].[Mã giày] INNER JOIN [Khách hàng] ON [Hóa đơn bán hàng].[Mã khách hàng] = [Khách hàng].[Mã khách hàng]";
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

        public bool ThemHD(dtoHoaDonBanGiay hd)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO [Hóa đơn bán hàng] VALUES (@mahd, @makh, @magiay, @soLuong)";

            SqlParameter parMa = new SqlParameter("@mahd", SqlDbType.VarChar);
            parMa.Value = hd.MaHoaDon;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parMaKH = new SqlParameter("@makh", SqlDbType.VarChar);
            parMaKH.Value = hd.MaKH;
            sqlCmd.Parameters.Add(parMaKH);

            SqlParameter parMaGiay = new SqlParameter("@magiay", SqlDbType.VarChar);
            parMaGiay.Value = hd.MaGiay;
            sqlCmd.Parameters.Add(parMaGiay);

            SqlParameter parSoLuong = new SqlParameter("@soLuong", SqlDbType.Int);
            parSoLuong.Value = hd.Soluong;
            sqlCmd.Parameters.Add(parSoLuong);

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
