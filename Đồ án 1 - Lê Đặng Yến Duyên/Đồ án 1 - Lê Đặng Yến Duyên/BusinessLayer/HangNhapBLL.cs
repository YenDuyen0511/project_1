using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;

namespace DOAN1.BusinessLayer
{
    class HangNhapBLL : IHangNhapBLL
    {
        private IHangNhapDAL hsDA = new HangNhapDAL();
        public List<hangNhap> GetAllHangnhap()
        {
            return hsDA.GetAllHangnhap();
        }
        public void ThemHangnhap(hangNhap hn)
        {
            if (!string.IsNullOrEmpty(hn.maHn))
            {
                hsDA.ThemHangnhap(hn);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void SuaHangnhap(hangNhap hn)
        {
            int i;
            List<hangNhap> list = GetAllHangnhap();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHn == hn.maHn)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hn);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void XoaHangnhap(string mahn)
        {
            int i;
            List<hangNhap> list = GetAllHangnhap();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHn == mahn)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public List<hangNhap> TimHangnhap(hangNhap hn)
        {
            List<hangNhap> list = GetAllHangnhap();
            List<hangNhap> kq = new List<hangNhap>();
            if (string.IsNullOrEmpty(hn.maHn) && hn.sLg == 0 && hn.donGia == 0)
            {
                kq = list;
            }
            //tim theo ma
            if (!string.IsNullOrEmpty(hn.maHn))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].maHn.IndexOf(hn.maHn) >= 0)
                    {
                        kq.Add(new hangNhap(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
