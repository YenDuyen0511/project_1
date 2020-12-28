using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Presentation;

namespace DOAN1
{
    public class frmMenuChinh
    {
        private static frmLoaiHang frmlh = new frmLoaiHang();
        private static frmHangHoa frmhh = new frmHangHoa();
        private static frmNCC frmcc = new frmNCC();
        private static frmNhanVien frmnv = new frmNhanVien();
        private static frmHoaDonNhap frmhdn = new frmHoaDonNhap();
        private static frmHangNhap frmhn = new frmHangNhap();
        private static frmHoaDonBan frmhdb = new frmHoaDonBan();
        private static frmHangBan frmhb = new frmHangBan();
        public static void HienMN()
        {
            ConsoleKeyInfo key;
            string[][] mn = new string[9][];
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
                "5.QUAN LI HOA DON NHAP","U.NHAP HOA DON NHAP","V.SUA HOA DON NHAP","W.XOA HOA DON NHAP","X.HIEN THI DANH SACH HOA DON NHAP","Y.TIM KIEM"
            };
            mn[5] = new string[]
            {
                "6.QUAN LI HANG NHAP","Z.NHAP HANG NHAP","a.SUA HANG NHAP","b.XOA HANG NHAP","c.HIEN THI DANH SACH HANG NHAP","d.TIM KIEM"
            };
            mn[6] = new string[]
            {
                "7.QUAN LI HOA DON BAN","e.NHAP HOA DON BAN","f.SUA HOA DON BAN","g.XOA HOA DON BAN","h.HIEN THI DANH SACH HOA DON BAN","i.TIM KIEM"
            };
            mn[7] = new string[]
            {
                "8.QUAN LI HANG BAN","j.NHAP HANG BAN","k.SUA HANG BAN","l.XOA HANG BAN","m.HIEN THI DANH SACH HANG BAN","n.TIM KIEM"
            };
            mn[8] = new string[]
            {
                "THOAT KHOI CHUONG TRINH(Alt+X)"
            };
            int muc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\t     QUAN LI CUA HANG QUAN AO YD \n\n");
                //Hiển thị các chức năng
                for (int i = 0; i < mn.Length; ++i)
                {
                    Console.WriteLine("\t\t" + mn[i][0]);
                    if (i == muc)
                        for (int j = 1; j < mn[i].Length; ++j)
                            Console.WriteLine("\t\t\t" + mn[i][j]);
                }
                key = Console.ReadKey(true);
                if (key.KeyChar >= '0' && key.KeyChar <= '9')
                    muc = key.KeyChar - 49;
                else if (key.Key == ConsoleKey.X && key.Modifiers == ConsoleModifiers.Alt)
                    Environment.Exit(0);
                else
                {
                    ThucHien(key.KeyChar);
                }
            } while (true);
        }
        public static void ThucHien(char ch)
        {
            switch (char.ToUpper(ch))
            {
                case 'A': Console.Clear(); frmlh.Nhap(); break;
                case 'B': Console.Clear(); frmlh.Sua(); break;
                case 'C': Console.Clear(); frmlh.xoa(); break;
                case 'D': Console.Clear(); frmlh.Hien(); Console.ReadKey(); break;
                case 'F': Console.Clear(); frmhh.Nhap(); break;
                case 'H': Console.Clear(); frmhh.xoa(); break;
                case 'G': Console.Clear(); frmhh.Sua(); break;
                case 'I': Console.Clear(); frmhh.Hien(); Console.ReadKey(); break;
                case 'K': Console.Clear(); frmcc.Nhap(); break;
                case 'L': Console.Clear(); frmcc.Sua(); break;
                case 'M': Console.Clear(); frmcc.xoa(); break;
                case 'N': Console.Clear(); frmcc.Hien(); Console.ReadKey(); break;
                case 'P': Console.Clear(); frmnv.Nhap(); break;
                case 'Q': Console.Clear(); frmnv.Sua(); break;
                case 'S': Console.Clear(); frmnv.Hien(); Console.ReadKey(); break;
                case 'U': Console.Clear(); frmhdn.Nhap(); break;
                case 'V': Console.Clear(); frmhdn.Sua(); break;
                case 'X': Console.Clear(); frmhdn.Hien(); Console.ReadKey(); break;
                case 'Z': Console.Clear(); frmhn.Nhap(); break;
                case 'a': Console.Clear(); frmhn.Sua(); break;
                case 'c': Console.Clear(); frmhn.Hien(); Console.ReadKey(); break;
                case 'e': Console.Clear(); frmhdb.Nhap(); break;
                case 'f': Console.Clear(); frmhdb.Sua(); break;
                case 'h': Console.Clear(); frmhdb.Hien(); Console.ReadKey(); break;
                case 'j': Console.Clear(); frmhb.Nhap(); break;
                case 'k': Console.Clear(); frmhb.Sua(); break;
                case 'm': Console.Clear(); frmhb.Hien(); Console.ReadKey(); break;
            }
        }
    }
}
