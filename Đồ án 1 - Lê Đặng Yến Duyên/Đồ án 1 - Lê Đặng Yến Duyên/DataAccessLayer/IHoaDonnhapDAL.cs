using System;
using System.Collections.Generic;
using System.Text;
using HoaDonNhap.Entities;

namespace HoaDonNhap.DataAccessLayer
{
    public interface IHoaDonnhapDAL
    {
        List<hoadonNhap> GetAllHoaDonnhap();
        void ThemHoaDonnhap(hoadonNhap hdn);
        void Update(List<hoadonNhap> list);
    }
}
