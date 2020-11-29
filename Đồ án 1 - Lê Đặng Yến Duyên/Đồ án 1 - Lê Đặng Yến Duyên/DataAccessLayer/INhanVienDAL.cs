using System;
using System.Collections.Generic;
using System.Text;
using NhanVien.Entities;

namespace NhanVien.DataAccessLayer
{
    public interface INhanVienDAL
    {
        List<nhanvien> GetAllNhanvien();
        void ThemNhanvien(nhanvien nv);
        void Update(List<nhanvien> list);
    }
}
