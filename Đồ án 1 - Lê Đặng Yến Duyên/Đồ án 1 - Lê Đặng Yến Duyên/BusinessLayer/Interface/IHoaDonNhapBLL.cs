using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.BusinessLayer
{
    public interface IHoaDonNhapBLL
    {
        List<hoadonNhap> GetAllHoaDonnhap();
        void ThemHoaDonnhap(hoadonNhap hdn);
        void SuaHoaDonnhap(hoadonNhap hdn);
        void XoaHoaDonnhap(string mahdn);
        List<hoadonNhap> TimHoaDonnhap(hoadonNhap hdn);
    }
}
