using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.BusinessLayer;

namespace DOAN1.Presentation
{
    public class frmHoaDonBan
    {
        private IHoaDonBanBLL hdbBLL = new HoaDonBanBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN HOA DON BAN");
            hoadonBan hdb = new hoadonBan();
            Console.Write("Nhap ma nhan vien :"); hdb.maNv = Console.ReadLine();
            Console.Write("Nhap thanh tien"); hdb.thanhTien = int.Parse(Console.ReadLine());
            Console.Write("Nhap chiet khau:"); hdb.cKhau = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay ban:"); hdb.ngayBan = DateTime.Parse(Console.ReadLine());
            hdbBLL.ThemHoaDonban(hdb);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN HOA DON BAN");
            List<hoadonBan> list = hdbBLL.GetAllHoaDonban();
            foreach (var hdb in list)
                Console.WriteLine(hdb.maHdb + "\t" + hdb.maNv + "\t" + hdb.thanhTien + "\t" + hdb.cKhau + "\t" + hdb.ngayBan);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HOA DON BAn");
            List<hoadonBan> list = hdbBLL.GetAllHoaDonban();
            string mahdb;
            Console.Write("Nhap ma hoa don ban can sua:");
            mahdb = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].maHdb == mahdb)
                    break;
            if (i < list.Count)
            {
                hoadonBan hdb = new hoadonBan(list[i]);
                Console.Write("Nhap ma nhan vien moi:");
                string manv = Console.ReadLine();
                if (!string.IsNullOrEmpty(manv))
                    hdb.maNv = manv;
                Console.Write("Nhap chiet khau moi:");
                int ckhau = int.Parse(Console.ReadLine());
                if (ckhau>0)
                    hdb.cKhau = ckhau;
                hdbBLL.SuaHoaDonban(hdb);
                Console.Write("Thanh tien moi:");
                int thanhtien = int.Parse(Console.ReadLine());
                if (thanhtien>0)
                    hdb.thanhTien = thanhtien;
                hdbBLL.SuaHoaDonban(hdb);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma nay");
            }
        }
    }
}
