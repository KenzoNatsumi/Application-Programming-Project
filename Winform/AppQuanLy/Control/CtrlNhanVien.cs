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
    internal class CtrlNhanVien
    {
        SqlConnection cnn = null;
        public CtrlNhanVien()
        {

            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public List<CNhanVien> finAll()
        {
            string sql = "select * from NHANVIEN";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CNhanVien> arrs = new List<CNhanVien>();
            while (reader.Read())
            {
                CNhanVien nv = new CNhanVien();
                nv.MaNV1 = reader.GetString(0);
                nv.TenNV1 = reader.GetString(1);
                nv.GioiTinh1 = reader.GetString(2);
                nv.DiaChi1 = reader.GetString(3);
                nv.SoDT1 = reader.GetString(4);
                nv.NgaySinh1 = reader.GetDateTime(5);
                arrs.Add(nv);
            }
            reader.Close();
            return arrs;
        }
        public bool IsDuplicate(string MaNV, string TenNV, string SoDT)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE MaNV = @MaNV OR TenNV = @TenNV OR SoDT = @SoDT";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@TenNV", TenNV);
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
        public bool Insert(CNhanVien obj)
        {
            try
            {
                if (IsDuplicate(obj.MaNV1, obj.TenNV1, obj.SoDT1))
                {
                    MessageBox.Show("Dữ liệu đã tồn tại.");
                    return false;
                }
                string sql = " insert into NHANVIEN values(@MaNV, @TenNV, @GioiTinh, @DiaChi, @SoDT, @NgaySinh)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaNV", obj.MaNV1);
                cmd.Parameters.AddWithValue("@TenNV", obj.TenNV1);
                cmd.Parameters.AddWithValue("@GioiTinh", obj.GioiTinh1);
                cmd.Parameters.AddWithValue("@DiaChi", obj.DiaChi1);
                cmd.Parameters.AddWithValue("@SoDT", obj.SoDT1);
                cmd.Parameters.AddWithValue("@NgaySinh", obj.NgaySinh1);
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
        public bool update(CNhanVien obj)
        {
            try
            {
                string sql = "update NHANVIEN set TenNV=@TenNV, GioiTinh=@GioiTinh, DiaChi=@DiaChi, SoDT=@SoDT, NgaySinh=@NgaySinh where MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaNV", obj.MaNV1);
                cmd.Parameters.AddWithValue("@TenNV", obj.TenNV1);
                cmd.Parameters.AddWithValue("@GioiTinh", obj.GioiTinh1);
                cmd.Parameters.AddWithValue("@DiaChi", obj.DiaChi1);
                cmd.Parameters.AddWithValue("@SoDT", obj.SoDT1);
                cmd.Parameters.AddWithValue("@NgaySinh", obj.NgaySinh1);
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
        public void UpdateMaNCCAfterDeletion(string deletedMaNV)
        {
            try
            {
                int deletedIndex = int.Parse(deletedMaNV.Replace("NV", ""));
                string sql = "UPDATE NHANVIEN SET MaNV = @NewMaNV WHERE MaNV = @OldMaNV";
                SqlCommand cmd = new SqlCommand(sql, cnn);

                for (int i = deletedIndex + 1; ; i++)
                {
                    string oldMaNV = "NV" + i.ToString("D2");
                    string newMaNV = "NV" + (i - 1).ToString("D2");

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@NewMaNV", newMaNV);
                    cmd.Parameters.AddWithValue("@OldMaNV", oldMaNV);

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
        public bool delete(CNhanVien obj)
        {
            try
            {
                string sql = "delete NHANVIEN where MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaNV", obj.MaNV1);
                cmd.Parameters.AddWithValue("@TenNV", obj.TenNV1);
                cmd.Parameters.AddWithValue("@GioiTinh", obj.GioiTinh1);
                cmd.Parameters.AddWithValue("@DiaChi", obj.DiaChi1);
                cmd.Parameters.AddWithValue("@SoDT", obj.SoDT1);
                cmd.Parameters.AddWithValue("@NgaySinh", obj.NgaySinh1);
                cmd.Connection = cnn;
                int row = cmd.ExecuteNonQuery();
                return (row > 0);

            }
            catch
            {

                return false;
            }
        }
        public List<CNhanVien> findMaNV(string DK)
        {
            string sql = "select * from NHANVIEN where MaNV like @DK";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CNhanVien> arrs = new List<CNhanVien>();
            while (reader.Read())
            {
                CNhanVien nv = new CNhanVien();
                nv.MaNV1 = reader.GetString(0);
                nv.TenNV1 = reader.GetString(1);
                nv.GioiTinh1 = reader.GetString(2);
                nv.DiaChi1 = reader.GetString(3);
                nv.SoDT1 = reader.GetString(4);
                nv.NgaySinh1 = reader.GetDateTime(5);
                arrs.Add(nv);
            }
            reader.Close();
            return arrs;
        }
        // phương thức dùng để xữ lí form FHoaDon
        public CNhanVien findNhanVienById(string maNV)
        {
            string sql = "select * from NHANVIEN where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@MaNV", maNV);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                CNhanVien nv = new CNhanVien();
                nv.MaNV1 = reader.GetString(0);
                nv.TenNV1 = reader.GetString(1);
                nv.GioiTinh1 = reader.GetString(2);
                nv.DiaChi1 = reader.GetString(3);
                nv.SoDT1 = reader.GetString(4);
                nv.NgaySinh1 = reader.GetDateTime(5);
                reader.Close();
                return nv;
            }
            reader.Close();
            return null;
        }
    }
}
 
