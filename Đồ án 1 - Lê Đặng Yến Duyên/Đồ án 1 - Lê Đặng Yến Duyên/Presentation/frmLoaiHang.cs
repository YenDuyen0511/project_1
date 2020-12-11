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
        private ILoaiHangBLL lhBLL = new LoaiHangBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN LOAI HANG");
            loaihang lh = new loaihang();
            Console.Write("Nhap ten loai hang"); lh.tenLoai = Console.ReadLine();
            Console.Write("Nhap mau sac:"); lh.mauSac = Console.ReadLine();
            lhBLL.ThemLoaihang(lh);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN LOAI HANG");
            List<loaihang> list = lhBLL.GetAllLoaihang();
            foreach (var lh in list)
                Console.WriteLine(lh.maLoai + "\t" + lh.tenLoai + "\t" + lh.mauSac);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN LOAI HANG");
            List<loaihang> list = lhBLL.GetAllLoaihang();
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
                lhBLL.SuaLoaihang(lh);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma loai nay");
            }
        }
    }
}
