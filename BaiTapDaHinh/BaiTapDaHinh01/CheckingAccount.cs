using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDaHinh
{
    class CheckingAccount : Accout
    {
        public double InteresRate { get; private set; }
        public CheckingAccount():base()
        {

        }
        public CheckingAccount(double amount)
        {

        }
        public override bool WithDraw(double amount)
        {
            if (amount>0 && amount<=Balance)
            {
                Balance = Balance - (amount + amount * InteresRate);
                return false;
            }
            return false;
        }
        public override bool Deposit(double amount)
        {
            return false;
        }
    }
}
