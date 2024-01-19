using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKetDon
{
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
    //Định nghĩa cấu trúc DSLK đơn
    class  SingleLinkList
    {
        private Node Head;
        public SingleLinkList()
        {
            Head = null;
        }
        //Các thao tác trên danh sách LKD
        //Thêm nút mới vào đầu xâu
        public void AddHead(int x)
        {
            Node p = new Node(x);//cập nhật nút mới
            p.Next = Head;
            Head = p;
        }
        //pt duyệt danh sách(xuất)
        public void ProcessList()
        {
            Node p = Head;
            while(p!=null)
            {
                Console.Write($"{p.Info}    ");//Xuất giá trị của nút
                    p = p.Next;
            }    
        }
        public void AddLast(int x)
        {
            Node p = new Node(x);//cập nhật nút mới
            if (Head == null)
            {
                Head = p;
            }
            else
            {
                Node q = Head;
                while (q.Next != null) { q = q.Next; }
                q.Next = p;
            }    
        }
        //xoá nút đầu
        public void DeleteHead()
        {
            if(Head!=null)
            {
                Node p = Head;
                Head = Head.Next;
                p.Next = null;
            }    
        }
        //xoá nút sau
        public void DeleteLast()
        {
            if(Head!=null)
            {
                Node p = Head;
                Node q = null;
                while(p.Next!=null)
                    //duyệt ds để tìm nút cuối
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = null;
            }    
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SingleLinkList l = new SingleLinkList();
            l.AddHead(5);
            l.AddHead(3);
            l.AddLast(9);
            NhapDanhSach(l);
            Console.WriteLine("Danh sách liên kết:");
            l.ProcessList();

            l.DeleteHead();
            Console.WriteLine("\n Danh sách liên kết sau khi xoá nút đầu:");
            l.ProcessList();

            l.DeleteLast();
            Console.WriteLine("\n Danh sách liên kết sau khi xoá nút sau:");
            l.ProcessList();
            Console.ReadLine();
        }
        static void NhapDanhSach(SingleLinkList l)
        {
            string chon = "y";
            int x;
            while (chon != "n")
            {
                Console.Write("Nhập giá trị nút: ");
                x = int.Parse(Console.ReadLine());
                l.AddLast(x);
                Console.Write("Tiếp tục (y/n)?");
                chon = Console.ReadLine();
            }
        }
    }
    
}
