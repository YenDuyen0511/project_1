using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public interface IHoaDonbanDAL
    {
        List<hoadonBan> GetAllHoaDonban();
        void ThemHoaDonban(hoadonBan hdb);
        void Update(List<hoadonBan> list);
    }
}
