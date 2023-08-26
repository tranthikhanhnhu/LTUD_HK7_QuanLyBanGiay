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
    public class dalHoaDonNhapHang : Database
    {
        public DataTable HienThiDanhSach()
        {
            OpenConnection();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Giày INNER JOIN [Hóa đơn nhập hàng] ON Giày.[Mã giày] = [Hóa đơn nhập hàng].[Mã giày] INNER JOIN [Nhà phân phối] ON [Hóa đơn nhập hàng].[Mã nhà phân phối] = [Nhà phân phối].[Mã nhà phân phối]", sqlCon);
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
            sqlCmd.CommandText = "SELECT * FROM Giày INNER JOIN [Hóa đơn nhập hàng] ON Giày.[Mã giày] = [Hóa đơn nhập hàng].[Mã giày] INNER JOIN [Nhà phân phối] ON [Hóa đơn nhập hàng].[Mã nhà phân phối] = [Nhà phân phối].[Mã nhà phân phối] WHERE [Mã hóa đơn] = @ma";

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
            sqlCmd.CommandText = "SELECT [Mã hóa đơn] FROM Giày INNER JOIN [Hóa đơn nhập hàng] ON Giày.[Mã giày] = [Hóa đơn nhập hàng].[Mã giày] INNER JOIN [Nhà phân phối] ON [Hóa đơn nhập hàng].[Mã nhà phân phối] = [Nhà phân phối].[Mã nhà phân phối]";
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

        public bool ThemHD(dtoHoaDonNhapHang hd)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO [Hóa đơn bán hàng] VALUES (@mahd, @mapp, @magiay, @soLuong)";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
            parMa.Value = hd.MaHD;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parMaPP = new SqlParameter("@mapp", SqlDbType.VarChar);
            parMaPP.Value = hd.MaPP;
            sqlCmd.Parameters.Add(parMaPP);

            SqlParameter parMaGiay = new SqlParameter("@magiay", SqlDbType.VarChar);
            parMaGiay.Value = hd.MaGiay;
            sqlCmd.Parameters.Add(parMaGiay);

            SqlParameter parSoLuong = new SqlParameter("@soLuong", SqlDbType.Int);
            parSoLuong.Value = hd.SoLuong;
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
