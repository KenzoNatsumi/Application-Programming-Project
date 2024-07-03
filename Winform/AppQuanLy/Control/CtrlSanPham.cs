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
    internal class CtrlSanPham
    {
        SqlConnection cnn = null;
        public CtrlSanPham()
        {

            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public List<CSanPham>finaAll()
        {
            string sql = "select * from SANPHAM";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CSanPham> arrs = new List<CSanPham>();
            while (reader.Read())
            {
                CSanPham SP = new CSanPham();
                SP.MaSP1 = reader.GetString(0);
                SP.TenSP1 = reader.GetString(1);
                SP.MaNCC1 = reader.GetString(2);
                SP.SoLuong1 = reader.GetInt32(3);
                SP.GiaNhap1 = (double)reader.GetDecimal(4);
                SP.GiaBan1 = (double)reader.GetDecimal(5);
                SP.GhiChu1 = reader.GetString(6);
                arrs.Add(SP);
            }
            reader.Close();
            return arrs;
        }
        public List<string> GetAllMaNCC()
        {
            string sql = "select MaNCC from NHACUNGCAP";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> maNCCs = new List<string>();
            while (reader.Read())
            {
                maNCCs.Add(reader.GetString(0));
            }
            reader.Close();
            return maNCCs;
        }


        public bool IsDuplicate(string MaSP)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM SANPHAM WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@MaSP", MaSP);
                int count = (int)cmd.ExecuteScalar();
                return (count > 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }



        public CSanPham GetProductByTenSPAndMaNCC(string TenSP, string MaNCC)
        {
            string sql = "SELECT * FROM SANPHAM WHERE TenSP = @TenSP AND MaNCC = @MaNCC";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@TenSP", TenSP);
            cmd.Parameters.AddWithValue("@MaNCC", MaNCC);
            SqlDataReader reader = cmd.ExecuteReader();
            CSanPham sp = null;
            if (reader.Read())
            {
                sp = new CSanPham();
                sp.MaSP1 = reader.GetString(0);
                sp.TenSP1 = reader.GetString(1);
                sp.MaNCC1 = reader.GetString(2);
                sp.SoLuong1 = reader.GetInt32(3);
                sp.GiaNhap1 = (double)reader.GetDecimal(4);
                sp.GiaBan1 = (double)reader.GetDecimal(5);
                sp.GhiChu1 = reader.GetString(6);
            }
            reader.Close();
            return sp;
        }

        public bool UpdateSoLuong(string MaSP, int additionalQuantity)
        {
            try
            {
                string sql = "UPDATE SANPHAM SET SoLuong = SoLuong + @AdditionalQuantity WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@MaSP", MaSP);
                cmd.Parameters.AddWithValue("@AdditionalQuantity", additionalQuantity);
                int row = cmd.ExecuteNonQuery();
                return (row > 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }


        public bool Insert(CSanPham obj)
        {
            try
            {
                if (IsDuplicate(obj.MaSP1))
                {
                    MessageBox.Show("Dữ liệu đã tồn tại.");
                    return false;
                }
                string sql = " insert into SANPHAM values(@MaSP, @TenSP, @MaNCC, @SoLuong, @GiaNhap, @GiaBan, @GhiChu)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaSP", obj.MaSP1);
                cmd.Parameters.AddWithValue("@TenSP", obj.TenSP1);
                cmd.Parameters.AddWithValue("@MaNCC", obj.MaNCC1);
                cmd.Parameters.AddWithValue("@SoLuong", obj.SoLuong1);
                cmd.Parameters.AddWithValue("@GiaNhap", obj.GiaNhap1);
                cmd.Parameters.AddWithValue("@GiaBan", obj.GiaBan1);
                cmd.Parameters.AddWithValue("@GhiChu", obj.GhiChu1);
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



        public bool update(CSanPham obj)
        {
            try
            {
                string sql = "update SANPHAM set TenSP=@TenSP, MaNCC=@MaNCC, SoLuong=@SoLuong, GiaNhap=@GiaNhap, GiaBan=@GiaBan, GhiChu=@GhiChu where MaSP=@MaSP";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaSP", obj.MaSP1);
                cmd.Parameters.AddWithValue("@TenSP", obj.TenSP1);
                cmd.Parameters.AddWithValue("@MaNCC", obj.MaNCC1);
                cmd.Parameters.AddWithValue("@SoLuong", obj.SoLuong1);
                cmd.Parameters.AddWithValue("@GiaNhap", obj.GiaNhap1);
                cmd.Parameters.AddWithValue("@GiaBan", obj.GiaBan1);
                cmd.Parameters.AddWithValue("@GhiChu", obj.GhiChu1);
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
        public void UpdateMaNCCAfterDeletion(string deletedMaSP)
        {
            try
            {
                int deletedIndex = int.Parse(deletedMaSP.Replace("SP", ""));
                string sql = "UPDATE SANPHAM SET MaSP = @NewMaSP WHERE MaSP = @OldMaSP";
                SqlCommand cmd = new SqlCommand(sql, cnn);

                for (int i = deletedIndex + 1; ; i++)
                {
                    string oldMaSP = "SP" + i.ToString("D2");
                    string newMaSP = "SP" + (i - 1).ToString("D2");

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@NewMaSP", newMaSP);
                    cmd.Parameters.AddWithValue("@OldMaSP", oldMaSP);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating MaSP: " + ex.Message);
            }
        }
        public bool delete(CSanPham obj)
        {
            try
            {
                string sql = "delete SANPHAM where MaSP=@MaSP";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@MaSP", obj.MaSP1);
                cmd.Parameters.AddWithValue("@TenSP", obj.TenSP1);
                cmd.Parameters.AddWithValue("@MaNCC", obj.MaNCC1);
                cmd.Parameters.AddWithValue("@SoLuong", obj.SoLuong1);
                cmd.Parameters.AddWithValue("@GiaNhap", obj.GiaNhap1);
                cmd.Parameters.AddWithValue("@GiaBan", obj.GiaBan1);
                cmd.Parameters.AddWithValue("@GhiChu", obj.GhiChu1);
                cmd.Connection = cnn;
                int row = cmd.ExecuteNonQuery();
                return (row > 0);

            }
            catch
            {

                return false;
            }
        }

        public List<CSanPham> findMaSP(string DK)
        {
            string sql = "select * from SANPHAM where MaSP like @DK";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CSanPham> arrs = new List<CSanPham>();
            while (reader.Read())
            {
                CSanPham SP = new CSanPham();
                SP.MaSP1 = reader.GetString(0);
                SP.TenSP1 = reader.GetString(1);
                SP.MaNCC1 = reader.GetString(2);
                SP.SoLuong1 = reader.GetInt32(3);
                SP.GiaNhap1 = (double)reader.GetDecimal(4);
                SP.GiaBan1 = (double)reader.GetDecimal(5);
                SP.GhiChu1 = reader.GetString(6);
                arrs.Add(SP);
            }
            reader.Close();
            return arrs;
        }


        public List<CSanPham> FindByTenSP(string TenSP)
        {
            string sql = "SELECT * FROM SANPHAM WHERE TenSP LIKE @TenSP or masp LIKE @TenSP";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@TenSP", "%" + TenSP + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CSanPham> products = new List<CSanPham>();
            while (reader.Read())
            {
                CSanPham sp = new CSanPham();
                sp.MaSP1 = reader.GetString(0);
                sp.TenSP1 = reader.GetString(1);
                sp.MaNCC1 = reader.GetString(2);
                sp.SoLuong1 = reader.GetInt32(3);
                sp.GiaNhap1 = (double)reader.GetDecimal(4);
                sp.GiaBan1 = (double)reader.GetDecimal(5);
                sp.GhiChu1 = reader.GetString(6);
                products.Add(sp);
            }
            reader.Close();
            return products;
        }
            }
        }
