using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyCD quanLyCD = new QuanLyCD();
            int luaChon = 0;
            do
            {
                Console.WriteLine("**********Chuong trinh quan ly CD*********");
                Console.WriteLine("1. Them CD");
                Console.WriteLine("2. Tinh gia thanh trung binh");
                Console.WriteLine("3. Sap xep CD giam dan them gia thanh");
                Console.WriteLine("4. Sap xep CD tang dan theo tua CD");
                Console.WriteLine("5. Xuat toan bo CD");
                Console.WriteLine("0. Thoat chuong trinh.");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Ban lua chon:");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma CD: ");
                        cd.macd = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua CD: ");
                        cd.tuacd = Console.ReadLine();
                        Console.Write("Nhap ca si: ");
                        cd.casi =Console.ReadLine();
                        Console.Write("Nhap nhap so bai hat: ");
                        cd.sobaihat = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia thanh: ");
                        cd.dongia = int.Parse(Console.ReadLine());
                        quanLyCD.ThemCD(cd);
                        break;
                    case 2:
                        double kq = quanLyCD.TinhGiaTB();
                        Console.WriteLine("Gia thanh trung binh : {0:#,##0.00}",kq);
                        break;
                    case 3:
                        quanLyCD.SapXepTheoGiaThanh();
                        Console.WriteLine("Da sap xep theo gia thanh giam dan");
                        break;
                    case 4:
                        quanLyCD.SapXepTheoTangDanTuCD();
                        Console.WriteLine("Da sap xep theo tu CD tang dan");
                        break;
                    case 5:
                        quanLyCD.Xuat();
                        break;
                    case 0:
                        Console.WriteLine("Tam biet. Hen gap lai.");
                        Console.ReadLine();
                        break;
                }
            } while (luaChon!=0);
        }
    }
}
