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
    public class dalGiay: Database
    {
        public DataTable HienThiDanhSach()
        {
            OpenConnection();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Giày", sqlCon);
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
            sqlCmd.CommandText = "SELECT * FROM Giày WHERE [Mã giày] like @ma ";

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

        public List<string> DanhSachMaGiay()
        {
            List<string> ds = new List<string>();
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from Giày";
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

        public bool ThemGiay(dtoGiay giay)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO Giày VALUES (@ma, @ten, @nsx, @size, @mau, @soLuong, @gia)";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
            parMa.Value = giay.MaGiay;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = giay.TenGiay;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parNSX = new SqlParameter("@nsx", SqlDbType.NVarChar);
            parNSX.Value = giay.NSX;
            sqlCmd.Parameters.Add(parNSX);

            SqlParameter parSize = new SqlParameter("@size", SqlDbType.Real);
            parSize.Value = giay.Size;
            sqlCmd.Parameters.Add(parSize);

            SqlParameter parMau = new SqlParameter("@mau", SqlDbType.NVarChar);
            parMau.Value = giay.Mau;
            sqlCmd.Parameters.Add(parMau);

            SqlParameter parSoLuong = new SqlParameter("@soLuong", SqlDbType.Int);
            parSoLuong.Value = giay.SoLuong;
            sqlCmd.Parameters.Add(parSoLuong);

            SqlParameter parGia = new SqlParameter("@gia", SqlDbType.Real);
            parGia.Value = giay.Gia;
            sqlCmd.Parameters.Add(parGia);

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

        public bool XoaGiay(string ma)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM Giày WHERE [Mã giày] = @ma ";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
            parMa.Value = ma;
            sqlCmd.Parameters.Add(parMa);

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

        public bool SuaGiay(dtoGiay giay)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE Giày SET [Tên giày] = @ten, [Nhà sản xuất] = @nsx, [Size] = @size, [Màu] = @mau, [Số lượng] = @soLuong, [Giá] = @gia where [Mã Giày] = @ma ";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
            parMa.Value = giay.MaGiay;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = giay.TenGiay;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parNSX = new SqlParameter("@nsx", SqlDbType.NVarChar);
            parNSX.Value = giay.NSX;
            sqlCmd.Parameters.Add(parNSX);

            SqlParameter parSize = new SqlParameter("@size", SqlDbType.Real);
            parSize.Value = giay.Size;
            sqlCmd.Parameters.Add(parSize);

            SqlParameter parMau = new SqlParameter("@mau", SqlDbType.NVarChar);
            parMau.Value = giay.Mau;
            sqlCmd.Parameters.Add(parMau);

            SqlParameter parSoLuong = new SqlParameter("@soLuong", SqlDbType.Int);
            parSoLuong.Value = giay.SoLuong;
            sqlCmd.Parameters.Add(parSoLuong);

            SqlParameter parGia = new SqlParameter("@gia", SqlDbType.Real);
            parGia.Value = giay.Gia;
            sqlCmd.Parameters.Add(parGia);

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
