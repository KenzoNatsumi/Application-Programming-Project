using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lí_cửa_hàng_máy_tính.model
{
    internal class CKhachHang
    {
        private string MaKH;
        private string TenKH;
        private string DiaChi;
        private string SoDT;

        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SoDT1 { get => SoDT; set => SoDT = value; }

        public CKhachHang()
        {
        }

        public CKhachHang(string maKH, string tenKH, string diaChi, string soDT)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            SoDT = soDT;
        }

        public override bool Equals(object? obj)
        {
            return obj is CKhachHang hang &&
                   MaKH == hang.MaKH;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MaKH);
        }

        public override string? ToString()
        {
            return MaKH;
        }
    }
}
