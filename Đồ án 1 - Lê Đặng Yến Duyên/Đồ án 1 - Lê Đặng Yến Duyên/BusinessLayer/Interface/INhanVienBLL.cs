using System;
using System.Collections.Generic;
using System.Text;
using NhanVien.Entities;

namespace NhanVien.BusinessLayer
{
    public interface INhanVienBLL
    {
        List<nhanvien> GetAllNhanvien();
        void ThemNhanvien(nhanvien nv);
        void SuaNhanvien(nhanvien nv);
        void XoaNhanvien(string manv);
        List<nhanvien> TimNhanvien(nhanvien nv);
    }
}
