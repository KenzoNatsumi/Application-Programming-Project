using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lí_cửa_hàng_máy_tính.model
{
    internal class CNhaCungCap
    {
        private string MaNCC;
        private string TenNCC;

       

        public string MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public string TenNCC1 { get => TenNCC; set => TenNCC = value; }

        public CNhaCungCap()
        {
        }

        public CNhaCungCap(string maNCC, string tenNCC)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
        }

        public override bool Equals(object? obj)
        {
            return obj is CNhaCungCap cap &&
                   MaNCC == cap.MaNCC;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MaNCC);
        }
        public override string ToString()
        {
            return MaNCC ;
        }
    }
}
