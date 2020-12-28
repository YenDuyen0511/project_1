using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.BusinessLayer
{
    public interface IHangBanBLL
    {
        List<hangBan> GetAllHangban();
        void ThemHangban(hangBan hb);
        void SuaHangban(hangBan hb);
        void XoaHangban(string mahb);
        List<hangBan> TimHangban(hangBan hb);
    }
}
