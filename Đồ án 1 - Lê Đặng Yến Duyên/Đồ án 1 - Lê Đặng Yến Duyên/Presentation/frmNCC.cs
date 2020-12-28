using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.BusinessLayer;

namespace DOAN1.Presentation
{
    public class frmNCC
    {
        private INccBLL ccBLL = new NccBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN NHA CUNG CAP");
            ncc cc = new ncc();
            Console.Write("Nhap ten nha cung cap:"); cc.tenNcc = Console.ReadLine();
            Console.Write("Nhap dia chi:"); cc.dChi = Console.ReadLine();
            Console.Write("Nhap so dien thoai:"); cc.SDT = Console.ReadLine();
            ccBLL.ThemNcc(cc);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN NHA CUNG CAP");
            List<ncc> list = ccBLL.GetAllNcc();
            foreach (var cc in list)
                Console.WriteLine(cc.maNcc + "\t" + cc.tenNcc + "\t" + cc.dChi + "\t" + cc.SDT);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN NHA CUNG CAP");
            List<ncc> list = ccBLL.GetAllNcc();
            string mancc;
            Console.Write("Nhap ma ncc can sua:");
            mancc = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].maNcc == mancc)
                    break;
            if (i < list.Count)
            {
                ncc cc = new ncc(list[i]);
                Console.Write("Nhap ten moi:");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten))
                    cc.tenNcc = ten;
                Console.Write("Nhap dia chi moi:");
                string dchi = Console.ReadLine();
                if (!string.IsNullOrEmpty(dchi))
                    cc.dChi = dchi;
                ccBLL.SuaNcc(cc);
                Console.Write("So dien thoai moi:");
                string sdt = Console.ReadLine();
                if (!string.IsNullOrEmpty(sdt))
                    cc.SDT = sdt;
                ccBLL.SuaNcc(cc);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN NHA CUNG CAP ");
            List<ncc> list = ccBLL.GetAllNcc();
            string ma;
            Console.Write("Nhap ma nha cung cap can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].maNcc == ma) break;

            if (i < list.Count)
            {
                ncc cc = new ncc(list[i]);
                ccBLL.XoaNcc(ma);
            }
        }
    }
}
