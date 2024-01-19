﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKetDon
{
    // Dinh nghia cau truc 1 node cua DSLK Don luu tru gia tri so nguyen
    class Node
    {
        private int info;
        private Node next;

        public Node(int x)
        {
            info = x;
            next = null;
        }

        public int Info
        {
            set { this.info = value; }
            get { return info; }
        }

        public Node Next
        {
            set { this.next = value; }
            get { return next; }
        }
    }

    // Dinh nghia cau truc DSLK Don
    class SingleLinkList
    {
        private Node Head;
        public SingleLinkList()
        {
            Head = null;
        }

        // Cac thao tac tren danh sach lien ket don
        // Phuong thuc them nut moi vao dau xau
        public void AddHead(int x)
        {
            Node p = new Node(x); // Cap phat nut moi
            p.Next = Head;
            Head = p;
        }

        // Phuong thuc them nut moi vao cuoi xau
        public void AddLast(int x)
        {
            Node p = new Node(x);
            if (Head == null) // Danh sach lien ket rong
            {
                Head = p;
            }
            else
            {
                Node q = Head;
                // Xac dinh nut cuoi xau
                while (q.Next != null)
                {
                    q = q.Next;
                }
                // Moc noi nut moi vao nut cuoi
                q.Next = p;
            }
        }
        // Phuong thuc xoa nut dau xau
        public void DeleteHead()
        {
            if (Head != null)
            {
                Node p = Head;
                Head = Head.Next;
                p.Next = null;
            }
        }
        // Phuong thuc xoa nut cuoi xau
        public void DeleteLast()
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null; // nut tam de xac dinh nut truoc p
                // Duyet danh sach de tim nut cuoi
                while (p.Next != null)
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = null;
            }
        }
        // Phuong thuc duyet danh sach (Xuat danh sach)
        public void ProcessList()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write($"{ p.Info }"); // Xuat gia tri cua nut
                p = p.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList l = new SingleLinkList();
            l.AddHead(9);
            l.AddHead(6);
            l.AddHead(5);
            l.AddHead(7);
            l.AddLast(3);
            l.AddHead(10);
            l.AddLast(15);

            Console.WriteLine("Danh sach lien ket duoc tao:");
            l.ProcessList();
            l.DeleteHead();
            Console.WriteLine("\n Danh sach lien ket sau khi xoa nut dau:");
            l.ProcessList();
            l.DeleteLast();
            Console.WriteLine("\n Danh sach lien ket sau khi xoa nut cuoi:");
            l.ProcessList();
            Console.ReadLine();
        }
    }
}
