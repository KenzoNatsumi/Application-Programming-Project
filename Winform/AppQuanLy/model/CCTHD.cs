using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace quản_lí_cửa_hàng_máy_tính.model
{
    internal class CCTHD
    {
        private CHoaDon MaHD;
        private CSanPham MaSP;
        private int SoLuong;
        private double DonGia;
        private double GiamGia;
        private double ThanhTien;

        public CCTHD(CHoaDon maHD, CSanPham maSP, int soLuong, double donGia, double giamGia, double thanhTien)
        {
            MaHD = maHD;
            MaSP = maSP;
            SoLuong = soLuong;
            DonGia = donGia;
            GiamGia = giamGia;
            ThanhTien = thanhTien;
        }

        public CCTHD()
        {

        }

        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public double DonGia1 { get => DonGia; set => DonGia = value; }
        public double GiamGia1 { get => GiamGia; set => GiamGia = value; }
        public double ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
        internal CHoaDon MaHD1 { get => MaHD; set => MaHD = value; }
        internal CSanPham MaSP1 { get => MaSP; set => MaSP = value; }

        public override bool Equals(object? obj)
        {
            return obj is CCTHD cCTHD &&
                   EqualityComparer<CHoaDon>.Default.Equals(MaHD, cCTHD.MaHD) &&
                   EqualityComparer<CSanPham>.Default.Equals(MaSP, cCTHD.MaSP);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MaHD, MaSP);
        }
    }



}
