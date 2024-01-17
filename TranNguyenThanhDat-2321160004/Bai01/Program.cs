using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class NhanVien
    {
        public string HoTen { get; set; }
        public int SoNgayCong { get; set; }
        public int SoNgayLamThem { get; set; }
        public string XepLoai { get; set; }
        public string BoPhan { get; set; }
        public NhanVien()
        {

        }
        public NhanVien(string hoTen, int soNgayCong, int soNgayLamThem, string xepLoai, string boPhan)
        {
            HoTen = hoTen;
            SoNgayCong = soNgayCong;
            SoNgayLamThem = soNgayLamThem;
            XepLoai = xepLoai;
            BoPhan = boPhan;
        }
        public double TinhLuong()
        {
            double phanTramTang = (BoPhan == "TrucTiep") ? 3.0 : 2.0;
            double luongMotNgay = 100000;
            return (SoNgayCong + SoNgayLamThem * (phanTramTang / 100)) * luongMotNgay;
        }
        public double TinhThuNhap()
        {
            switch (XepLoai)
            {
                case "A":
                    return 1.5 * TinhLuong();
                case "B":
                    return 1.2 * TinhLuong();
                case "C":
                    return TinhLuong();
                default:
                    return 0;
            }
        }
        public void InThongTin()
        {
            Console.WriteLine($"Ho Ten: {HoTen}");
            Console.WriteLine($"Bo Phan: {BoPhan}");
            Console.WriteLine($"Thu Nhap: {TinhThuNhap()}VND");
        }

        class Program
        {
            static void Main(string[] args)
            {
                NhanVien nhanVien1 = new NhanVien();
                Console.Write("Nhap Ho Ten: ");
                nhanVien1.HoTen = Console.ReadLine();
                Console.Write("Nhap so ngay cong: ");
                nhanVien1.SoNgayCong = int.Parse(Console.ReadLine());
                Console.Write("Nhap so ngay lam them: ");
                nhanVien1.SoNgayLamThem = int.Parse(Console.ReadLine());
                Console.Write("Nhap Xep Loai (A/B/C): ");
                nhanVien1.XepLoai = Console.ReadLine();
                Console.Write("Nhap Bo Phan (TrucTiep/GianTiep): ");
                nhanVien1.BoPhan = Console.ReadLine();
                nhanVien1.InThongTin();
                NhanVien nhanVien2 = new NhanVien("Nguyen Van B", 25, 5, "B", "GianTiep");
                nhanVien2.InThongTin();
                Console.ReadLine();
            }
        }
    }
}