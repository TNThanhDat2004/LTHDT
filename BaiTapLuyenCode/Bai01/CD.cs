using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class CD
    {
        private int MaCD;
        private string TuaCD;
        private string CaSi;
        private int SoBaiHat;
        private int DonGia;

        public CD()
        {

        }
        public CD(int MaCD,string TuaCD, string CaSi, int SoBaiHat, int DonGia)
        {
            this.MaCD = MaCD;
            this.TuaCD = TuaCD;
            this.CaSi = CaSi;
            this.SoBaiHat = SoBaiHat;
            this.DonGia = DonGia;
        }
        public int macd
        { 
            set { this.MaCD = value; }
            get { return MaCD; }
        }
        public string tuacd
        {
            set { this.TuaCD = value; }
            get { return TuaCD; }
        }
        public string casi
        {
            set { this.CaSi = value; }
            get { return CaSi; }
        }
        public int sobaihat
        {
            set { this.SoBaiHat = value; }
            get { return SoBaiHat; }
        }
        public int dongia
        {
            set { this.DonGia = value; }
            get { return DonGia; }
        }
        public string ToString()
        {
            return string.Format("{0, 10} {1,30} {2,30} {3,10} {4, 15:#,##0}", MaCD, TuaCD, CaSi, SoBaiHat, DonGia);
        }
    }
}
