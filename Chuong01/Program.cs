﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong01
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle()
        {
            length = 1.0;
            width = 1.0;
        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public void setLength(double length)
        {
            this.length = length;
        }
        public double getLength()
        {
            return length;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double getWidth()
        {
            return width;
        }
        public double findArea()
        {
            return length * width;
        }
        public double findPerimiter()
        {
            return (length + width) * 2;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Rectangle r1;
                Rectangle r2;
                r1 = new Rectangle();
                Console.Write("Cho biet chieu dai:");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Cho biet chieu rong:");
                double width = double.Parse(Console.ReadLine());
                r2 = new Rectangle(length, width);
                Console.WriteLine("-------------------Thong tin hinh chu nhat r1------------------");
                Console.WriteLine("Chieu dai: {0}\nChieu rong: {1}\nDien tich: {2}\nChu vi: {3}", r1.getLength(), r1.getWidth(), r1.findArea(), r1.findPerimiter());
                Console.WriteLine("-------------------Thong tin hinh chu nhat r2------------------");
                Console.WriteLine("Chieu dai: {0}\nChieu rong: {1}\nDien tich: {2}\nChu vi: {3}", r2.getLength(), r2.getWidth(), r2.findArea(), r2.findPerimiter());
                Console.ReadLine();
            }
        }
    }
}