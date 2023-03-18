using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCN
{
    public class HocVienLienKet : HocVien
    {
        public double SoTienDaDong { get; set; }
        public override double TinhHocPhi(int soTietHoc)
        {
            return soTietHoc * 10000 - SoTienDaDong;
        }
    }
}
