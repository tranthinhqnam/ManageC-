using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCN
{
    public class HocVien
    {
        public string MaHV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public double DiemTB { get; set; }
        public virtual double TinhHocPhi(int soTietHoc)
        {
            return soTietHoc * 10000;
        }
    }
}
