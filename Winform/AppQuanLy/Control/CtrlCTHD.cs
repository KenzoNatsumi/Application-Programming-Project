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
    internal class CtrlCTHD
    {
        SqlConnection cnn = null;
        public CtrlCTHD()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public List<CCTHD> finAll()
        {
            string sql = "select * from CTHD";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CCTHD> arrs = new List<CCTHD>();
            while (reader.Read())
            {
                CCTHD cthd = new CCTHD();
                cthd.MaHD1.MaHD1 = reader.GetString(0);
                cthd.MaSP1.MaSP1 = reader.GetString(1);
                cthd.SoLuong1 = reader.GetInt32(2);
                cthd.DonGia1 = (double)reader.GetDecimal(3);
                cthd.GiamGia1 = (double)reader.GetDecimal(4);
                cthd.ThanhTien1= (double)reader.GetDecimal(5);
                arrs.Add(cthd);
            }
            reader.Close();
            return arrs;
        }
        public List<CCTHD> find(string DK)
        {
            string sql = "select * from CTHD where mahd=@dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CCTHD> arrs = new List<CCTHD>();
            while (reader.Read())
            {
                CCTHD cthd = new CCTHD();
                cthd.MaHD1.MaHD1 = reader.GetString(0);
                cthd.MaSP1.MaSP1 = reader.GetString(1);
                cthd.SoLuong1 = reader.GetInt32(2);
                cthd.DonGia1 = (double)reader.GetDecimal(3);
                cthd.GiamGia1 = (double)reader.GetDecimal(4);
                cthd.ThanhTien1 = (double)reader.GetDecimal(5);
                arrs.Add(cthd);
            }
            reader.Close();
            return arrs;
        }
        public bool insert(CCTHD obj)
        {
            try
            {
                string sql = "insert into cthd values (@mahd,@masp,@soluong,@dongia,@giamgia,@thanhtien)";
                SqlCommand cmd = new SqlCommand(sql,cnn);
                cmd.Parameters.AddWithValue("@mahd", obj.MaHD1);
                cmd.Parameters.AddWithValue("@masp", obj.MaSP1.MaSP1);
                cmd.Parameters.AddWithValue("@soluong", obj.SoLuong1);
                cmd.Parameters.AddWithValue("@dongia", obj.DonGia1);
                cmd.Parameters.AddWithValue("@giamgia", obj.GiamGia1);
                cmd.Parameters.AddWithValue("@thanhtien", obj.ThanhTien1);
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
