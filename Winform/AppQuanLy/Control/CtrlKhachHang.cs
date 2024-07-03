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
    internal class CtrlKhachHang
    {
        SqlConnection cnn = null;
        public CtrlKhachHang()
        {

            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public List<CKhachHang> finAll()
        {
            string sql = "select * from KHACHHANG";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CKhachHang> arrs = new List<CKhachHang>();
            while (reader.Read())
            {
                CKhachHang kh = new CKhachHang();
                kh.MaKH1 = reader.GetString(0);
                kh.TenKH1 = reader.GetString(1);
                kh.DiaChi1 = reader.GetString(2);
                kh.SoDT1 = reader.GetString(3);
                arrs.Add(kh);
            }
            reader.Close();
            return arrs;
        }



        public bool IsDuplicate(string MaKH, string TenKH , string SoDT)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM KHACHHANG WHERE MaKH = @MaKH OR TenKH = @TenKH OR SoDT = @SoDT ";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@MaKH", MaKH);
                cmd.Parameters.AddWithValue("@TenKH", TenKH);
                cmd.Parameters.AddWithValue("@SoDT", SoDT);
                int count = (int)cmd.ExecuteScalar();
                return (count > 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool Insert(CKhachHang obj)
        {
            try
            {
                if (IsDuplicate(obj.MaKH1, obj.TenKH1,obj.SoDT1))
                {
                    MessageBox.Show("Dữ liệu đã tồn tại.");
                    return false;
                }
                string sql = " insert into KHACHHANG values(@MaKH, @TenKH, @DiaChi, @SoDT)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaKH",obj.MaKH1);
                cmd.Parameters.AddWithValue("@TenKH", obj.TenKH1);
                cmd.Parameters.AddWithValue("@DiaChi", obj.DiaChi1);
                cmd.Parameters.AddWithValue("@SoDT", obj.SoDT1);
                cmd.Connection = cnn;
                int row = cmd.ExecuteNonQuery();
                return (row > 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool update(CKhachHang obj)
        {
            try
            {
                string sql = "update KHACHHANG set TenKH=@TenKH, DiaChi=@DiaChi, SoDT=@SoDT where MaKH=@MaKH";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaKH",obj.MaKH1);
                cmd.Parameters.AddWithValue("@TenKH", obj.TenKH1);
                cmd.Parameters.AddWithValue("@DiaChi", obj.DiaChi1);
                cmd.Parameters.AddWithValue("@SoDT", obj.SoDT1);
                cmd.Connection = cnn;
                int row = cmd.ExecuteNonQuery();
                return (row > 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public void UpdateMaNCCAfterDeletion(string deletedMaKH)
        {
            try
            {
                int deletedIndex = int.Parse(deletedMaKH.Replace("KH", ""));
                string sql = "UPDATE KHACHHANG SET MaKH = @NewMaKH WHERE MaKH = @OldMaKH";
                SqlCommand cmd = new SqlCommand(sql, cnn);

                for (int i = deletedIndex + 1; ; i++)
                {
                    string oldMaKH = "KH" + i.ToString("D2");
                    string newMaKH = "KH" + (i - 1).ToString("D2");

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@NewMaKH", newMaKH);
                    cmd.Parameters.AddWithValue("@OldMaKH", oldMaKH);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating MaKH: " + ex.Message);
            }
        }



        public bool delete(CKhachHang obj)
        {
            try
            {
                string sql = "delete KHACHHANG where MaKH=@MaKH";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaKH", obj.MaKH1);
                cmd.Parameters.AddWithValue("@TenKH", obj.TenKH1);
                cmd.Parameters.AddWithValue("@DiaChi", obj.DiaChi1);
                cmd.Parameters.AddWithValue("@SoDT", obj.SoDT1);
                cmd.Connection = cnn;
                int row = cmd.ExecuteNonQuery();
                return (row > 0);

            }
            catch
            {

                return false;
            }
        }
        public List<CKhachHang> findMaKH(string DK)
        {
            string sql = "select * from KHACHHANG where MaKH like @DK";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CKhachHang> arrs = new List<CKhachHang>();
            while (reader.Read())
            {
                CKhachHang kh = new CKhachHang();
                kh.MaKH1 = reader.GetString(0);
                kh.TenKH1 = reader.GetString(1);
                kh.DiaChi1 = reader.GetString(2);
                kh.SoDT1 = reader.GetString(3);
                arrs.Add(kh);
            }
            reader.Close();
            return arrs;
        }
        // phương thức để sử lí bên form FHoaDon
        public CKhachHang findKhachHangById(string maKH)
        {
            string sql = "select * from KHACHHANG where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@MaKH", maKH);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                CKhachHang kh = new CKhachHang();
                kh.MaKH1 = reader.GetString(0);
                kh.TenKH1 = reader.GetString(1);
                kh.DiaChi1 = reader.GetString(2);
                kh.SoDT1 = reader.GetString(3);
                reader.Close();
                return kh;
            }
            reader.Close();
            return null;
        }
    }
}
