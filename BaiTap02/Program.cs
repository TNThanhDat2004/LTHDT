using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Program
    {
        static void Main(string[] args)
        {

           TaiKhoan01 my = new TaiKhoan01("900111", "Le Van Teo", 600);
            Console.Write("Inter id value:");
            string id = Console.ReadLine();
            Console.Write("Inter name value:");
            string name = Console.ReadLine();
            Console.Write("Inter balance value:");
            int balance = int.Parse(Console.ReadLine());
            TaiKhoan01 myFriend = new TaiKhoan01(id, name, balance);
            Console.WriteLine("-----Thong tin 2 tai khoan ban dau------");
            Console.WriteLine("My Account:[ id:{0}, name: {1}, balance:{2}]",
            my.getId(), my.getName(), my.getbalance());
            Console.WriteLine("My friend Account:[ id:{0}, name: {1}, balance:{2}]",
            myFriend.getId(), myFriend.getName(), myFriend.getbalance());
            int amout = 0;

            //rut tien
            Console.WriteLine("Debit 200 from my Account");
            my.debit(200);

            //Chuyển tiền
            Console.WriteLine("Inter a amount value to tranfer:");
            amout = int.Parse(Console.ReadLine());

            //Chuyen khoản từ tài khoản My đến Myfriend
            my.tranferTo(myFriend, amout);

            //Chuyen khoản từ tài khoản My friend đến My 
            my.tranferTo(myFriend, 50);

            //ket qua sau khi thuc hien mot so hanh vi (nap, rut, chuyen khoan)
            Console.WriteLine("-----Thong tin 2 tai khoan sau khi thuc hien giao dich-----");
            Console.WriteLine("My Account:[ id:{0}, name: (1}, balance: {2}]",
            my.getId(), my.getName(), my.getbalance());
            Console.WriteLine("My friend Account:[ id:{0}, name:{1}, balance:{2}]",
            myFriend.getId(), myFriend.getName(), myFriend.getbalance());
            Console.ReadLine();
        }
    }
}
