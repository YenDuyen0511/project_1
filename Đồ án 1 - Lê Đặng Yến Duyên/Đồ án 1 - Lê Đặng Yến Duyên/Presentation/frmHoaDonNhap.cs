using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.BusinessLayer;

namespace DOAN1.Presentation
{
    public class frmHoaDonNhap
    {
        private IHoaDonNhapBLL hdnBLL = new HoaDonNhapBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN HOA DON NHAP");
            hoadonNhap hdn = new hoadonNhap();
            Console.Write("Nhap ten nhan vien giao:"); hdn.tenNvgiao = Console.ReadLine();
            Console.Write("Nhap ma nha cung cap:"); hdn.maNcc = Console.ReadLine();
            Console.Write("Nhap tong tien:"); hdn.Tong= int.Parse(Console.ReadLine());
            Console.Write("Nhap VAT:"); hdn.VAT = int.Parse(Console.ReadLine());
            hdnBLL.ThemHoaDonnhap(hdn);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN HOA DON NHAP");
            List<hoadonNhap> list = hdnBLL.GetAllHoaDonnhap();
            foreach (var hdn in list)
                Console.WriteLine(hdn.maHdn + "\t" + hdn.tenNvgiao + "\t" + hdn.maNcc + "\t" + hdn.Tong + "\t" + hdn.VAT);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HOA DON NHAP");
            List<hoadonNhap> list = hdnBLL.GetAllHoaDonnhap();
            string mahdn;
            Console.Write("Nhap ma hoa don nhap can sua:");
            mahdn = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].maHdn == mahdn)
                    break;
            if (i < list.Count)
            {
                hoadonNhap hdn = new hoadonNhap(list[i]);
                Console.Write("Nhap ten nhan vien giao moi:");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten))
                    hdn.tenNvgiao = ten;
                Console.Write("Nhap ma ncc moi:");
                string mancc = Console.ReadLine();
                if (!string.IsNullOrEmpty(mancc))
                    hdn.maNcc = mancc ;
                hdnBLL.SuaHoaDonnhap(hdn);
                Console.Write("Tong tien moi:");
                int tong = int.Parse(Console.ReadLine());
                if (tong > 0)
                    hdn.Tong = tong ;
                hdnBLL.SuaHoaDonnhap(hdn);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN HOA DON NHAP ");
            List<hoadonNhap> list = hdnBLL.GetAllHoaDonnhap();
            string ma;
            Console.Write("Nhap ma hoa don nhap can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].maHdn == ma) break;

            if (i < list.Count)
            {
                hoadonNhap hdn = new hoadonNhap(list[i]);
                hdnBLL.XoaHoaDonnhap(ma);
            }
        }
    }
}
