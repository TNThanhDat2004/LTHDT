using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDaHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Accout ac1 = new SavingAccount(200);
            Accout ac2 = new CheckingAccount(200);
            Console.ReadLine();
        }
    }
}
