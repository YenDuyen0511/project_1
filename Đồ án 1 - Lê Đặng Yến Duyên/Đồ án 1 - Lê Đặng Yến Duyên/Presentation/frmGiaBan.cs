using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.BusinessLayer;

namespace DOAN1.Presenation
{
    public class frmGiaban
    {
        private IGiaBanBLL gbBLL = new GiaBanBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN GIA BAN");
            giaban gb = new giaban();
            Console.Write("Nhap don vi:"); gb.donvi = Console.ReadLine();
            Console.Write("Nhap gia ban :"); gb.Gia = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay ap dung:"); gb.ngayad = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ngay ket thuc:");gb.ngaykt = DateTime.Parse(Console.ReadLine());
            gbBLL.Themgiaban(gb);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN GIA BAN");
            List<giaban> list = gbBLL.GetAllGiaban();
            foreach (var gb in list)
                Console.WriteLine(gb.maHang + "\t" + gb.donvi + "\t" + gb.Gia + "\t" + gb.ngayad + "\t" + gb.ngaykt);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN GIA BAN");
            List<giaban> list = gbBLL.GetAllGiaban();
            string tenh;
            Console.Write("Nhap ma hang can sua:");
            tenh = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].maHang == tenh) break;

            if (i < list.Count)
            {
                giaban gb = new giaban(list[i]);
                Console.Write("Nhap don vi moi:");
                string dvi = Console.ReadLine();
                if (!string.IsNullOrEmpty(dvi)) gb.donvi = dvi;
                Console.Write("Gia moi:");
                int gia = int.Parse(Console.ReadLine());
                if (gia > 0) gb.Gia = gia;
                gbBLL.Suagiaban(gb);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN GIA BAN ");
            List<giaban> list = gbBLL.GetAllGiaban();
            string ma;
            Console.Write("Nhap ma hang can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].maHang == ma) break;

            if (i < list.Count)
            {
                giaban gb = new giaban(list[i]);
                gbBLL.Xoagiaban(ma);
            }
        }
    }
}
