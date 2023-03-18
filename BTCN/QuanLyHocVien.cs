using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCN
{
    public class QuanLyHocVien
    {
        private List<HocVien> danhSachHocVien;

        public QuanLyHocVien()
        {
            danhSachHocVien = new List<HocVien>();
        }

        public void ThemHocVien(HocVien hocVien)
        {
            danhSachHocVien.Add(hocVien);
        }

        public void SuaHocVien(HocVien hocVien)
        {
            for (int i = 0; i < danhSachHocVien.Count; i++)
            {
                if (danhSachHocVien[i].MaHV == hocVien.MaHV)
                {
                    danhSachHocVien[i] = hocVien;
                    break;
                }

            }
        }
        public void XoaHocVien(string maHV)
        {
            danhSachHocVien.RemoveAll(x => x.MaHV == maHV);
        }
        public void HienThiThongTinHocVien()
        {
            foreach (var hocVien in danhSachHocVien)
            {
                Console.WriteLine("Mã học viên: " + hocVien.MaHV);
                Console.WriteLine("Họ tên: " + hocVien.HoTen);
                Console.WriteLine("Ngày sinh: " + hocVien.NgaySinh);
                Console.WriteLine("Địa chỉ: " + hocVien.DiaChi);
                Console.WriteLine("Điểm trung bình: " + hocVien.DiemTB);

                if (hocVien is HocVienChinhThuc)
                {
                    var hocVienChinhThuc = hocVien as HocVienChinhThuc;
                    Console.WriteLine("Số tiết học đã học: " + hocVienChinhThuc.SoTietHocDaHoc);
                }
                else if (hocVien is HocVienLienKet)
                {
                    var hocVienLienKet = hocVien as HocVienLienKet;
                    Console.WriteLine("Số tiền đã đóng học phí:" + hocVienLienKet.SoTienDaDong);
                }
                Console.WriteLine("-----------------------");
            }
        }


            }
            }

