using quản_lí_cửa_hàng_máy_tính.model;
using quản_lí_cửa_hàng_máy_tính.util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lí_cửa_hàng_máy_tính.Control
{
    internal class CtrlHoaDon
    {
        SqlConnection cnn = null;
        public CtrlHoaDon()
        {

            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public List<CHoaDon> finAll()
        {
            string sql = "select * from HOADON";
            SqlCommand cmd = new SqlCommand(sql,cnn);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CHoaDon> arrs = new List<CHoaDon>();
            while (reader.Read())
            {
                CHoaDon hd = new CHoaDon();
                hd.MaHD1 = reader.GetString(0);
                hd.MaNV1 = new CNhanVien();
                hd.MaNV1.MaNV1 = reader.GetString(1);
                hd.MaKH1 = new CKhachHang();
                hd.MaKH1.MaKH1 = reader.GetString(2);
                hd.NgayBan1 = reader.GetDateTime(3);
                hd.TongTien1= (double)reader.GetDecimal(4);
                arrs.Add(hd);
            }
            reader.Close();
            return arrs;
        }
        public List<CHoaDon> findMaHD(string DK)
        {
            string sql = "select * from HOADON where mahd like @dk";
            SqlCommand cmd = new SqlCommand(sql,cnn);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CHoaDon> arrs = new List<CHoaDon>();
            while (reader.Read())
            {
                CHoaDon hd = new CHoaDon();
                hd.MaHD1 = reader.GetString(0);
                hd.MaNV1 = new CNhanVien();
                hd.MaNV1.MaNV1 = reader.GetString(1);
                hd.MaKH1 = new CKhachHang();
                hd.MaKH1.MaKH1 = reader.GetString(2);
                hd.NgayBan1 = reader.GetDateTime(3);
                hd.TongTien1 = (double)reader.GetDecimal(4);
                arrs.Add(hd);
            }
            reader.Close();
            return arrs;
        }
        public bool delete(CHoaDon obj)
        {
            try
            {
                string sql = "delete from hoadon where mahd=@MaHD1";
                SqlCommand cmd = new SqlCommand(sql);

                cmd.Parameters.AddWithValue("@MaHD1", obj.MaHD1);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);

            }
            catch
            {
                return false;
            }
        }
        public bool insert(CHoaDon obj)
        {
            try
            {
                string sql = "insert into hoadon values (@soHD,@NV,@KH,@ngHD,@TT)";
                SqlCommand cmd = new SqlCommand(sql,cnn);
                cmd.Parameters.AddWithValue("@soHD", obj.MaHD1);
                cmd.Parameters.AddWithValue("@KH", obj.MaKH1.MaKH1);
                cmd.Parameters.AddWithValue("@NV", obj.MaNV1.MaNV1);
                cmd.Parameters.AddWithValue("@ngHD", obj.NgayBan1);
                cmd.Parameters.AddWithValue("@TT", obj.TongTien1);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch
            {
                return false; 
            }

        }
    }
}
