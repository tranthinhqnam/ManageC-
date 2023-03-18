
using BTCN;

class Program
{
    static void Main(string[] args)
    {
        QuanLyHocVien quanLyHocVien = new QuanLyHocVien();

        // Thêm học viên chính thức
        HocVienChinhThuc hocVienChinhThuc = new HocVienChinhThuc
        {
            MaHV = "TVT1026186",
            HoTen = "Tran Van Thinh",
            NgaySinh = new DateTime(2000, 1, 1),
            DiaChi = "Quang Nam",
            DiemTB = 8.5,
            SoTietHocDaHoc = 20
        };
        quanLyHocVien.ThemHocVien(hocVienChinhThuc);

        // Thêm học viên liên kết
        HocVienLienKet hocVienLienKet = new HocVienLienKet
        {
            MaHV = "HV002",
            HoTen = "Tran Thi B",
            NgaySinh = new DateTime(2001, 2, 2),
            DiaChi = "Ho Chi Minh",
            DiemTB = 7.5,
            SoTienDaDong = 1500000
        };
        quanLyHocVien.ThemHocVien(hocVienLienKet);

        // Hiển thị thông tin của tất cả các học viên trong danh sách
        quanLyHocVien.HienThiThongTinHocVien();

        // Xóa học viên có mã HV001
        quanLyHocVien.XoaHocVien("HV001");

        // Hiển thị lại thông tin của tất cả các học viên trong danh sách sau khi xóa
        quanLyHocVien.HienThiThongTinHocVien();

        Console.ReadKey();
    }
}
