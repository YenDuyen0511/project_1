using System;
using System.Collections.Generic;
using System.Text;
using Loaihang.Presentation;
using HangHoa.Presentation;
using NCC.Presentation;
using NhanVien.Presentation;

namespace Đồ_án_1___Lê_Đặng_Yến_Duyên
{
    public class Program
    {
        private static frmLoaiHang frmlh = new frmLoaiHang();
        private static frmHangHoa frmhh = new frmHangHoa();
        private static frmNCC frmcc = new frmNCC();
        private static frmNhanVien frmnv = new frmNhanVien();
        public static void HienMN()
        {
            ConsoleKeyInfo key;
            string[][] mn = new string[5][];
            mn[0] = new string[]
            {
                "1.QUAN LI LOAI HANG","A.NHAP LOAI HANG","B.SUA LOAI HANG","C.XOA LOAI HANG","D.HIEN THI DANH SACH LOAI HANG","E.TIM KIEM"
            };
            mn[1] = new string[]
            {
                "2.QUAN LI HANG HOA","F.NHAP HANG HOA","G.SUA HANG HOA","H.XOA HANG HOA","I.HIEN THI DANH SACH HANG HOA","J.TIM KIEM"
            };
            mn[2] = new string[]
            {
                "3.QUAN LI NCC","K.NHAP NCC","L.SUA NCC","M.XOA NCC","N.HIEN THI DANH SACH NCC","O.TIM KIEM"
            };
            mn[3] = new string[]
            {
                "4.QUAN LI NHAN VIEN","P.NHAP NHAN VIEN","Q.SUA NHAN VIEN","R.XOA NHAN VIEN","S.HIEN THI DANH SACH NHAN VIEN","T.TIM KIEM"
            };
            mn[4] = new string[]
            {
                "THOAT KHOI CHUONG TRINH(Alt+X)"
            };
            int muc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\t     CHUONG TRINH QUAN LY LUONG DON GIAN  \n\n");
                for (int i = 0; i < mn.Length; i++)
                {
                    Console.WriteLine("\t\t" + mn[i][0]);
                    if (i == muc)
                        for (int j = 1; j < mn[i].Length; j++)
                            Console.WriteLine("\t\t\t" + mn[i][j]);
                }
                key = Console.ReadKey(true);
                if (key.KeyChar >= 'A' && key.KeyChar <= 'Z')
                    muc = key.KeyChar - 49;
                else if (key.Key == ConsoleKey.X && key.Modifiers == ConsoleModifiers.Alt)
                    Environment.Exit(0);
                else { ThucHien(key.KeyChar); }
            } while (true);
        }
        public static void ThucHien(char ch)
        {
            switch (char.ToUpper(ch))
            {
                case 'A': Console.Clear(); frmlh.Nhap(); break;
                case 'B': Console.Clear(); frmlh.Sua(); break;
                case 'D': Console.Clear(); frmlh.Hien(); Console.ReadKey(); break;
                case 'F': Console.Clear(); frmhh.Nhap(); break;
                case 'G': Console.Clear(); frmhh.Sua(); break;
                case 'I': Console.Clear(); frmhh.Hien(); Console.ReadKey(); break;
                case 'K': Console.Clear(); frmcc.Nhap(); break;
                case 'L': Console.Clear(); frmcc.Sua(); break;
                case 'N': Console.Clear(); frmcc.Hien(); Console.ReadKey(); break;
                case 'P': Console.Clear(); frmnv.Nhap(); break;
                case 'Q': Console.Clear(); frmnv.Sua(); break;
                case 'S': Console.Clear(); frmnv.Hien(); Console.ReadKey(); break;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HienMN();
        }
    }
}
