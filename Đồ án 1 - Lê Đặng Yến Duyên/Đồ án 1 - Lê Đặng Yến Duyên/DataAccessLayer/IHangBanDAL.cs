using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public interface IHangBanDAL
    {
        List<hangBan> GetAllHangBan();
        void ThemHangBan(hangBan hb);
        void Update(List<hangBan> list);
    }
}
