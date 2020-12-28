using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.utillity
{
    //tao 1 node dang tong quát với kiểu dữ liệu là T
    public class Node<T>
    {
        private T data;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        private Node<T> link;

        public Node<T> Link
        {
            get { return link; }
            set { link = value; }
        }
        public Node() { }
        public Node(T t)
        {
            data = t;
            link = null;
        }
    }
    public class List<T>
    {
        //con tro cua danh sach lien ket
        private Node<T> head;

        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        public List()
        {
            head = null;
        }
        public void AddHead(T n)
        {
            Node<T> tg = new Node<T>(n);
            tg.Link = head;
            head = tg;
        }
        public void AddTail(T x)
        {
            Node<T> t = new Node<T>(x);
            if (head == null) head = t;
            else
            {
                Node<T> tg = head;
                while (tg.Link != null)
                {
                    tg = tg.Link;
                }
                tg.Link = t;
            }
        }
        public void Hien()
        {
            Node<T> tg = head;
            Console.WriteLine("cac phan tu cua danh sach:");
            while (tg != null)
            {
                Console.WriteLine("\t" + tg.Data);
                tg = tg.Link;
            }
            Console.WriteLine();
        }
        public void RemoveTail()
        {
            if (head == null)
            {
                Console.WriteLine("danh sach rong");
                return;
            }
            else
                if (head.Link == null)
            {
                head = null;
            }
            else
            {

                Console.WriteLine("danh sach da duoc xoa di phan tu cuoi:");
                Node<T> tg = head;
                Node<T> t = tg;
                while (tg.Link != null)
                {
                    t = tg;
                    tg = tg.Link;
                }
                t.Link = null;
            }
        }
        public void Xoaq(Node<T> q)
        {
            Node<T> tg = head;
            Node<T> t = tg;
            while (tg.Link != null)
            {
                if (tg == q) break;
                else
                {
                    t = tg;
                    tg = tg.Link;
                }
            }
            if (q == head) head = head.Link;//q la dau danh sach
            else
            {
                if (q.Link == null)
                    t.Link = null;
                else
                    t.Link = q.Link;
            }
        }
    }
}


