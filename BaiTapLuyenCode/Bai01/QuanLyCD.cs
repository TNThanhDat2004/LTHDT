using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class QuanLyCD
    {
        private CD[] ds;
        private int n;
        public QuanLyCD()
        {
            ds = new CD[100];
            n = 0;
        }
        public QuanLyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        public void ThemCD(CD cd)
        {
            if (n>ds.Length)
            {
                Console.WriteLine(" Danh sach da day!");
            }
            else
            {
                if (!KiemTraTrungCD(cd.macd))
                {
                    ds[n + 1] = cd;
                }
                else
                {
                    Console.WriteLine("Trung ma CD");
                }
            }
        }
        private bool KiemTraTrungCD (int macd)
        {
            for (int i = 0; i < n; i++)
            {
                if (ds[i].macd==macd)
                {
                    return true;
                }
            }
            return false;
        }
        public double TinhGiaTB()
        {
            int TongGia = 0;
            for (int i = 0; i < n; i++)
            {
                TongGia += ds[i].dongia;
            }
            return (double)TongGia / n;
        }
        public void Xuat()
        {
            Console.WriteLine("{0, 10} {1,30} {2,30} {3,10} {4, 15}", "MaCD", "Tua CD", "Ca si", "So bai hat", "Gia thanh");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].ToString());
            }
        }
        public void SapXepTheoGiaThanh()
        {
            CD tam;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (ds[i].dongia<ds[j].dongia)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
        public void SapXepTheoTangDanTuCD()
        {
            CD tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].tuacd.CompareTo(ds[j].tuacd)>0)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
    }
}
