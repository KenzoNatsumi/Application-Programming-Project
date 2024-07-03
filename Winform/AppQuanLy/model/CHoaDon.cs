using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lí_cửa_hàng_máy_tính.model
{
    internal class CHoaDon
    {
        private string MaHD;
        private CNhanVien MaNV;
        private CKhachHang MaKH;
        private DateTime NgayBan;
        private double TongTien;

        public string MaHD1 { get => MaHD; set => MaHD = value; }
        public CNhanVien MaNV1 { get => MaNV; set => MaNV = value; }
        public CKhachHang MaKH1 { get => MaKH; set => MaKH = value; }
        public DateTime NgayBan1 { get => NgayBan; set => NgayBan = value; }
        public double TongTien1 { get => TongTien; set => TongTien = value; }
        public CHoaDon()
        {

        }

        public CHoaDon(string maHD, CNhanVien maNV, CKhachHang maKH, DateTime ngayBan, double tongTien)
        {
            MaHD = maHD;
            MaNV = maNV;
            MaKH = maKH;
            NgayBan = ngayBan;
            TongTien = tongTien;
        }

        public override bool Equals(object? obj)
        {
            return obj is CHoaDon don &&
                   MaHD == don.MaHD;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MaHD);
        }
    }


}
