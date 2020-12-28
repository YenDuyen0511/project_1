using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.BusinessLayer;

namespace DOAN1.Presentation
{
    public class frmHangBan
    {
        private IHangBanBLL hbBLL = new HangBanBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN HANG BAN");
            hangBan hb = new hangBan();
            Console.Write("Nhap so luong:"); hb.sLg = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia:"); hb.Gia = int.Parse(Console.ReadLine());
            hbBLL.ThemHangban(hb);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN HANG BAN");
            List<hangBan> list = hbBLL.GetAllHangban();
            foreach (var hb in list)
                Console.WriteLine(hb.maHb + "\t" + hb.sLg + "\t" + hb.Gia);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HANG BAN");
            List<hangBan> list = hbBLL.GetAllHangban();
            string mahb;
            Console.Write("Nhap ma hang ban can sua:");
            mahb = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].maHb == mahb)
                    break;
            if (i < list.Count)
            {
                hangBan hb = new hangBan(list[i]);
                Console.Write("Nhap so luong moi:");
                int slg = int.Parse(Console.ReadLine());
                if (slg > 0)
                    hb.sLg = slg;
                Console.Write("Nhap gia moi:");
                int gia = int.Parse(Console.ReadLine());
                if (gia > 0)
                    hb.Gia = gia;
                hbBLL.SuaHangban(hb);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma nay");
            }
        }
    }
}
