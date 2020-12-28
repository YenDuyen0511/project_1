using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.BusinessLayer;

namespace DOAN1.Presentation
{
    public class frmHangHoa
    {
        private IHangHoaBLL hhBLL = new HangHoaBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN HANG HOA");
            hanghoa hh = new hanghoa();
            Console.Write("Nhap ten hang hoa:"); hh.tenHang = Console.ReadLine();
            Console.Write("Nhap ma loai:"); hh.maLoai = Console.ReadLine();
            Console.Write("Nhap so luong nhap ve:"); hh.slgnhap = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong hien co:"); hh.slgco = int.Parse(Console.ReadLine());
            hhBLL.ThemHanghoa(hh);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN HANG HOA");
            List<hanghoa> list = hhBLL.GetAllHanghoa();
            foreach (var hh in list)
                Console.WriteLine(hh.maHang + "\t" + hh.tenHang + "\t" + hh.maLoai + "\t" + hh.slgnhap+ "\t" + hh.slgco);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HANG HOA");
            List<hanghoa> list = hhBLL.GetAllHanghoa();
            string mahang;
            Console.Write("Nhap ma hang can sua:");
            mahang = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].maHang == mahang)
                    break;
            if (i < list.Count)
            {
                hanghoa hh = new hanghoa(list[i]);
                Console.Write("Nhap ten moi:");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten))
                    hh.tenHang = ten;
                Console.Write("So luong nhap ve moi:");
                int slgnhap = int.Parse(Console.ReadLine());
                if (slgnhap > 0)
                    hh.slgnhap = slgnhap;
                hhBLL.SuaHanghoa(hh);
                Console.Write("So luong hien co moi:");
                int slgco = int.Parse(Console.ReadLine());
                if (slgco > 0)
                    hh.slgco = slgco;
                hhBLL.SuaHanghoa(hh);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma hang nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN HANG HOA ");
            List<hanghoa> list = hhBLL.GetAllHanghoa();
            string ma;
            Console.Write("Nhap ma hang can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].maHang == ma) break;

            if (i < list.Count)
            {
                hanghoa hh = new hanghoa(list[i]);
                hhBLL.XoaHanghoa(ma);
            }
        }
    }
}
