using System;
using System.Collections.Generic;
using System.Text;
using HangBan.Entities;

namespace HangBan.BusinessLayer
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
