using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;

namespace DOAN1.BusinessLayer
{
    class HangBanBLL : IHangBanBLL
    {
        private IHangBanDAL hsDA = new HangBanDAL();
        public List<hangBan> GetAllHangban()
        {
            return hsDA.GetAllHangBan();
        }
        public void ThemHangban(hangBan hb)
        {
            if (!string.IsNullOrEmpty(hb.maHb))
            {
                hsDA.ThemHangBan(hb);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void SuaHangban(hangBan hb)
        {
            int i;
            List<hangBan> list = GetAllHangban();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHb == hb.maHb)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hb);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void XoaHangban(string mahb)
        {
            int i;
            List<hangBan> list = GetAllHangban();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHb == mahb)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public List<hangBan> TimHangban(hangBan hb)
        {
            List<hangBan> list = GetAllHangban();
            List<hangBan> kq = new List<hangBan>();
            if (string.IsNullOrEmpty(hb.maHb) && hb.sLg == 0 && hb.Gia == 0)
            {
                kq = list;
            }
            //tim theo ma
            if (!string.IsNullOrEmpty(hb.maHb))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].maHb.IndexOf(hb.maHb) >= 0)
                    {
                        kq.Add(new hangBan(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
