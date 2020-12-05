using System;
using System.Collections.Generic;
using System.Text;
using HangHoa.Entities;
using HangHoa.BusinessLayer;

namespace HangHoa.Presentation
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
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("*****************************************");
                Console.WriteLine("|     QUAN LI THONG TIN LOAI HANG       |");
                Console.WriteLine("|        F1: Nhap hang hoa              |");
                Console.WriteLine("|        F2: Sua hang hoa               |");
                Console.WriteLine("|        F3: Xoa hang hoa               |");
                Console.WriteLine("|        F4: Hien danh sach             |");
                Console.WriteLine("|        F5: Tim kiem                   |");
                Console.WriteLine("|        F6: Thoat                      |");
                Console.WriteLine("*****************************************");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        Nhap();
                        Hien();
                        Console.WriteLine("Nhap phim bat ki de tiep tuc...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F4:
                        Hien();
                        Console.WriteLine("Nhap phim bat ki de tiep tuc...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F2:
                        Sua();
                        Hien();
                        Console.WriteLine("Nhap phim bat ki de tiep tuc...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F6:
                        Program2.Menu();
                        break;
                }
            }
            while (true);
        }
    }
}
