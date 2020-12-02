using System;
using System.Collections.Generic;
using System.Text;
using HoaDonBan.Entities;
using HoaDonBan.DataAccessLayer;

namespace HoaDonBan.BusinessLayer
{
    class HoaDonBanBLL : IHoaDonBanBLL
    {
        private IHoaDonbanDAL hsDA = new HoaDonbanDAL();
        public List<hoadonBan> GetAllHoaDonban()
        {
            return hsDA.GetAllHoaDonban();
        }
        public void ThemHoaDonban(hoadonBan hdb)
        {
            if (!string.IsNullOrEmpty(hdb.maHdb))
            {
                hsDA.ThemHoaDonban(hdb);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void SuaHoaDonban(hoadonBan hdb)
        {
            int i;
            List<hoadonBan> list = GetAllHoaDonban();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHdb == hdb.maHdb)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hdb);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void XoaHoaDonban(string mahdb)
        {
            int i;
            List<hoadonBan> list = GetAllHoaDonban();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHdb == mahdb)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public List<hoadonBan> TimHoaDonban(hoadonBan hdb)
        {
            List<hoadonBan> list = GetAllHoaDonban();
            List<hoadonBan> kq = new List<hoadonBan>();
            if (string.IsNullOrEmpty(hdb.maHdb) && string.IsNullOrEmpty(hdb.maNv) && hdb.thanhTien== 0 && hdb.cKhau == 0)
            {
                kq = list;
            }
            //tim theo ma
            if (!string.IsNullOrEmpty(hdb.maHdb))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].maHdb.IndexOf(hdb.maHdb) >= 0)
                    {
                        kq.Add(new hoadonBan(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
