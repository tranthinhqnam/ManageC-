using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCN
{
    public class HocVienChinhThuc : HocVien
    {
        public int SoTietHocDaHoc { get; set; }
        public override double TinhHocPhi(int soTietHoc)
        {
            if (soTietHoc < SoTietHocDaHoc)
            {
                return 0;
            }
            return (soTietHoc - SoTietHocDaHoc) * 10000;
        }
    }
}
