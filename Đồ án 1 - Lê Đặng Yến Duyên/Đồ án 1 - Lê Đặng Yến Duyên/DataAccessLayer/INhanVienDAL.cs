using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public interface INhanVienDAL
    {
        List<nhanvien> GetAllNhanvien();
        void ThemNhanvien(nhanvien nv);
        void Update(List<nhanvien> list);
    }
}
