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
    internal class CtrlNhaCungCap
    {
        SqlConnection cnn = null;
        public CtrlNhaCungCap()
        {

            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public List<CNhaCungCap> finAll()
        {
            string sql = "select * from NHACUNGCAP";

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CNhaCungCap> arrs = new List<CNhaCungCap>();
            while (reader.Read())
            {
                CNhaCungCap NCC = new CNhaCungCap();
                NCC.MaNCC1 = reader.GetString(0);
                NCC.TenNCC1 = reader.GetString(1);
                arrs.Add(NCC);
            }
            reader.Close();
            return arrs;
        }
        public bool IsDuplicate(string maNCC, string tenNCC)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM NHACUNGCAP WHERE MaNCC = @MaNCC OR TenNCC = @TenNCC";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
                int count = (int)cmd.ExecuteScalar();
                return (count > 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool Insert(CNhaCungCap obj)
        {
            try
            {
                if (IsDuplicate(obj.MaNCC1,obj.TenNCC1))
                {
                    MessageBox.Show("Dữ liệu đã tồn tại.");
                    return false;
                }
                string sql = " insert into NHACUNGCAP values(@MaNCC, @TenNCC)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaNCC", obj.MaNCC1);
                cmd.Parameters.AddWithValue("@TenNCC", obj.TenNCC1);
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



        public bool IsDuplicate1( string tenNCC)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM NHACUNGCAP WHERE TenNCC = @TenNCC";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
                int count = (int)cmd.ExecuteScalar();
                return (count > 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }



        public bool update(CNhaCungCap obj)
        {
            try
            {
                if (IsDuplicate1( obj.TenNCC1))
                {
                    MessageBox.Show("Dữ liệu đã tồn tại.");
                    return false;
                }
                string sql = "update NHACUNGCAP set TenNCC=@TenNCC where MaNCC=@MaNCC";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaNCC", obj.MaNCC1);
                cmd.Parameters.AddWithValue("@TenNCC", obj.TenNCC1);
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



        public void UpdateMaNCCAfterDeletion(string deletedMaNCC)
        {
        try
        {
            int deletedIndex = int.Parse(deletedMaNCC.Replace("NCC", ""));
            string sql = "UPDATE NHACUNGCAP SET MaNCC = @NewMaNCC WHERE MaNCC = @OldMaNCC";
            SqlCommand cmd = new SqlCommand(sql, cnn);

            for (int i = deletedIndex + 1; ; i++)
            {
                string oldMaNCC = "NCC" + i.ToString("D2");
                string newMaNCC = "NCC" + (i - 1).ToString("D2");

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NewMaNCC", newMaNCC);
                cmd.Parameters.AddWithValue("@OldMaNCC", oldMaNCC);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                    break;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating MaNCC: " + ex.Message);
        }
    }
       


        public bool delete(CNhaCungCap obj)
        {
            try
            {
                string sql = "delete NHACUNGCAP where MaNCC=@MaNCC";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaNCC", obj.MaNCC1);
                cmd.Parameters.AddWithValue("@TenNCC", obj.TenNCC1);
                cmd.Connection = cnn;
                int row = cmd.ExecuteNonQuery();
                return (row > 0);

            }
            catch
            {

                return false;
            }
        }
        public List<CNhaCungCap> findMaNCC(string DK)
        {
            string sql = "select * from NHACUNGCAP where MaNCC like @DK";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CNhaCungCap> arrs = new List<CNhaCungCap>();
            while (reader.Read())
            {
                CNhaCungCap NCC = new CNhaCungCap();
                NCC.MaNCC1 = reader.GetString(0);
                NCC.TenNCC1 = reader.GetString(1);
                arrs.Add(NCC);
            }
            reader.Close();
            return arrs;
        }
    }
}

