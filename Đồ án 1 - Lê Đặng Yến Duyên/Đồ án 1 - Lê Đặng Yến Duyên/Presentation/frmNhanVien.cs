using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.BusinessLayer;

namespace DOAN1.Presentation
{
    public class frmNhanVien
    {
        private INhanVienBLL nvBLL = new NhanVienBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN NHAN VIEN");
            nhanvien nv = new nhanvien();
            Console.Write("Nhap ten nhan vien:"); nv.tenNv = Console.ReadLine();
            Console.Write("Nhap pass:"); nv.Pass = Console.ReadLine();
            Console.Write("Nhap loai nhan vien:"); nv.loaiNv = Console.ReadLine();
            Console.Write("Nhap ngay lam:"); nv.ngayLam = DateTime.Parse(Console.ReadLine());
            nvBLL.ThemNhanvien(nv);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN NHAN VIEN ");
            List<nhanvien> list = nvBLL.GetAllNhanvien();
            foreach (var nv in list)
                Console.WriteLine(nv.maNv + "\t" + nv.tenNv + "\t" + nv.Pass + "\t" + nv.loaiNv + "\t" + nv.ngayLam);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN NHAN VIEN");
            List<nhanvien> list = nvBLL.GetAllNhanvien();
            string manv;
            Console.Write("Nhap ma nhan vien can sua:");
            manv = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].maNv == manv)
                    break;
            if (i < list.Count)
            {
                nhanvien nv = new nhanvien(list[i]);
                Console.Write("Nhap ten moi:");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten))
                    nv.tenNv = ten;
                Console.Write("Nhap pass moi:");
                string pass = Console.ReadLine();
                if (!string.IsNullOrEmpty(pass))
                    nv.Pass = pass; ;
                nvBLL.SuaNhanvien(nv);
                Console.Write("Nhap loai nhan vien moi:");
                string loainv= Console.ReadLine();
                if (!string.IsNullOrEmpty(loainv))
                    nv.loaiNv = loainv ;
                nvBLL.SuaNhanvien(nv);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma nay");
            }
        }
    }
}
