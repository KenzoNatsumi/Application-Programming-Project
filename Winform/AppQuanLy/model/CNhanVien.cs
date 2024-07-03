using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lí_cửa_hàng_máy_tính.model
{
    internal class CNhanVien
    {
        private string MaNV;
        private string TenNV;
        private string GioiTinh;
        private string DiaChi;
        private string SoDT;
        private DateTime NgaySinh;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SoDT1 { get => SoDT; set => SoDT = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }

        public CNhanVien()
        {
        }

        public CNhanVien(string maNV, string tenNV, string gioiTinh, string diaChi, string soDT, DateTime ngaySinh)
        {
            MaNV = maNV;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDT = soDT;
            NgaySinh = ngaySinh;
        }

        public override bool Equals(object? obj)
        {
            return obj is CNhanVien vien &&
                   MaNV == vien.MaNV;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MaNV);
        }

        public override string ToString()
        {
            return MaNV;
        }
    }
}
