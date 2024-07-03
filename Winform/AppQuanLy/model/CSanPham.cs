using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lí_cửa_hàng_máy_tính.model
{
    internal class CSanPham
    {
        private string MaSP;
        private string TenSP;
        private string MaNCC;
        private int SoLuong; 
        private double GiaNhap;
        private double GiaBan;
        private string GhiChu;

        public string MaSP1 { get => MaSP; set => MaSP = value; }
        public string TenSP1 { get => TenSP; set => TenSP = value; }
        public string MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public double GiaNhap1 { get => GiaNhap; set => GiaNhap = value; }
        public double GiaBan1 { get => GiaBan; set => GiaBan = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }

        public CSanPham()
        {
        }

        public CSanPham(string maSP, string tenSP, string maNCC, int soLuong, double giaNhap, double giaBan, string ghiChu)
        {
            MaSP = maSP;
            TenSP = tenSP;
            MaNCC = maNCC;
            SoLuong = soLuong;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            GhiChu = ghiChu;
        }

        public override bool Equals(object? obj)
        {
            return obj is CSanPham pham &&
                   MaSP == pham.MaSP;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MaSP);
        }

        public override string? ToString()
        {
            return MaSP+" "+TenSP+"("+GiaBan+")";
        }
    }
}
