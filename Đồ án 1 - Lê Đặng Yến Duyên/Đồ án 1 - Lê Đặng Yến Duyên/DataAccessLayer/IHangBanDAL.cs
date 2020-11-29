using System;
using System.Collections.Generic;
using System.Text;
using HangBan.Entities;

namespace HangBan.DataAccessLayer
{
    public interface IHangBanDAL
    {
        List<hangBan> GetAllHangBan();
        void ThemHangBan(hangBan hb);
        void Update(List<hangBan> list);
    }
}
