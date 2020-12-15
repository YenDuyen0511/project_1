using System;
using System.Collections.Generic;
using System.Text;
using HangNhap.Entities;
using HangNhap.BusinessLayer;

namespace HangNhap.Presentation
{
    public class frmHangNhap
    {
        private IHangNhapBLL hnBLL = new HangNhapBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN HANG NHAP");
            hangNhap hn = new hangNhap();
            Console.Write("Nhap so luong:"); hn.sLg = int.Parse(Console.ReadLine());
            Console.Write("Nhap don gia:"); hn.donGia = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay san xuat:"); hn.ngaySX = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ngay het han:"); hn.ngayHH = DateTime.Parse(Console.ReadLine());
            hnBLL.ThemHangnhap(hn);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN HANG NHAP");
            List<hangNhap> list = hnBLL.GetAllHangnhap();
            foreach (var hn in list)
                Console.WriteLine(hn.maHn + "\t" + hn.sLg + "\t" + hn.donGia + "\t" + hn.ngaySX + "\t" + hn.ngayHH);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HANG NHAP");
            List<hangNhap> list = hnBLL.GetAllHangnhap();
            string mahn;
            Console.Write("Nhap ma hang nhap can sua:");
            mahn = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].maHn == mahn)
                    break;
            if (i < list.Count)
            {
                hangNhap hn = new hangNhap(list[i]);
                Console.Write("Nhap so luong moi:");
                int slg = int.Parse(Console.ReadLine());
                if (slg > 0)
                    hn.sLg = slg;
                Console.Write("Nhap don gia moi:");
                int dongia = int.Parse(Console.ReadLine());
                if (dongia > 0)
                    hn.donGia = dongia;
                hnBLL.SuaHangnhap(hn);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma nay");
            }
        }
    }
}
