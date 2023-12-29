﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_03
{
    class PhanSo
    {
        private int tuso, mauso;
        public PhanSo()
        {
            tuso = 1;
            mauso = 1;
        }
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void setTuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int getTuso()
        {
            return tuso;
        }
        public void setMauso(int mauso)
        {
            this.mauso = mauso;
        }
        public int getMauso()
        {
            return mauso;
        }
        public void toiGian()
        {
            int x = Math.Abs(tuso);
            int y = Math.Abs(mauso);
            while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }
            tuso = tuso / x;
            mauso = mauso / y;
        }
        public PhanSo Cong(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso + ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo Tru(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso - ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo Nhan(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo Chia(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.tuso;
            return kq;
        }


    }
}