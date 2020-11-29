using System;
using System.Collections.Generic;
using System.Text;
using HoaDonBan.Entities;

namespace HoaDonBan.DataAccessLayer
{
    public interface IHoaDonbanDAL
    {
        List<hoadonBan> GetAllHoaDonban();
        void ThemHoaDonban(hoadonBan hdb);
        void Update(List<hoadonBan> list);
    }
}
