using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Loaihang.BusinessLayer;
using Loaihang.Entities;

namespace Loaihang.Presentation
{
    public class frmLoaiHang
    {
        private ILoaiHangBLL lhDLL = new LoaiHangBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN LOAI HANG");
            loaihang lh = new loaihang();
            Console.Write("Nhap ten loai hang"); lh.tenLoai = Console.ReadLine();
            Console.Write("Nhap mau sac:"); lh.mauSac = Console.ReadLine();
            lhDLL.ThemLoaihang(lh);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN LOAI HANG");
            List<loaihang> list = lhDLL.GetAllLoaihang();
            foreach (var lh in list)
                Console.WriteLine(lh.maLoai + "\t" + lh.tenLoai + "\t" + lh.mauSac);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN LOAI HANG");
            List<loaihang> list = lhDLL.GetAllLoaihang();
            string maloai;
            Console.Write("Nhap ma loai can sua:");
            maloai = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].maLoai == maloai)
                    break;
            if (i < list.Count)
            {
                loaihang lh = new loaihang(list[i]);
                Console.Write("Nhap ten moi:");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten))
                    lh.tenLoai = ten;
                Console.Write("Mau sac moi:");
                string mausac = Console.ReadLine();
                if (!string.IsNullOrEmpty(mausac))
                    lh.mauSac = mausac;
                lhDLL.SuaLoaihang(lh);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma loai nay");
            }
        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("*****************************************");
                Console.WriteLine("|     QUAN LI THONG TIN LOAI HANG       |");
                Console.WriteLine("|        F1: Nhap loai hang             |");
                Console.WriteLine("|        F2: Sua loai hang              |");
                Console.WriteLine("|        F3: Xoa loai hang              |");
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
                        Program.Menu();
                        break;
                }
            }
            while (true);
        }
    }
}
