using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_03
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo();
            Console.WriteLine("Nhap thong tin phan so");
            Console.Write("\t Tu so: ");
            int tuso = int.Parse(Console.ReadLine());
            Console.Write("\t Mau so: ");
            int mauso = int.Parse(Console.ReadLine());

            p1.setTuso(tuso);
            p1.setMauso(mauso);

            Console.WriteLine("Nhap thong tin phan so thu 2");
            Console.Write("\t Tu so: ");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("\t Mau so: ");
            mauso = int.Parse(Console.ReadLine());
            PhanSo p2 = new PhanSo(tuso, mauso);
            p2.toiGian();
            PhanSo tong = p1.Cong(p2);
            Console.WriteLine("Tong 2 phan so PS1:{0}/{1} va PS2:{2}/{3} = {4}/{5}",
                p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());
            PhanSo hieu = p1.Tru(p2);
            Console.WriteLine("Tru 2 phan so PS1:{0}/{1} va PS2:{2}/{3} = {4}/{5}",
                p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());
            PhanSo tich = p1.Nhan(p2);
            Console.WriteLine("Nhan 2 phan so PS1:{0}/{1} va PS2:{2}/{3} = {4}/{5}",
                p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());
            PhanSo Thuong = p1.Chia(p2);
            Console.WriteLine("Thuong 2 phan so PS1:{0}/{1} va PS2:{2}/{3} = {4}/{5}",
                p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());
            Console.ReadKey();
        }
    }
}