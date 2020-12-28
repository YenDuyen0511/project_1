using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.BusinessLayer
{
    public interface IHoaDonBanBLL
    {
        List<hoadonBan> GetAllHoaDonban();
        void ThemHoaDonban(hoadonBan hdb);
        void SuaHoaDonban(hoadonBan hdb);
        void XoaHoaDonban(string mahdb);
        List<hoadonBan> TimHoaDonban(hoadonBan hdb);
    }
}
