using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;

namespace DOAN1.BusinessLayer
{
    public class LoaiHangBLL : ILoaiHangBLL
    {
        private ILoaiHangDAL hsDA = new LoaiHangDAL();
        public List<loaihang> GetAllLoaihang()
        {
            return hsDA.GetAllLoaihang();
        }
        public void ThemLoaihang(loaihang lh)
        {
            if (!string.IsNullOrEmpty(lh.tenLoai))
            {
                //chuan hoa du lieu
                hsDA.ThemLoaihang(lh);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void SuaLoaihang(loaihang lh)
        {
            int i;
            List<loaihang> list = GetAllLoaihang();
            for (i = 0; i < list.Count; i++)
                if (list[i].maLoai == lh.maLoai)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(lh);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void XoaLoaihang(string maloai)
        {
            int i;
            List<loaihang> list = GetAllLoaihang();
            for (i = 0; i < list.Count; i++)
                if (list[i].maLoai == maloai)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma loai nay");
        }
        public List<loaihang> TimLoaihang(loaihang lh)
        {
            List<loaihang> list = GetAllLoaihang();
            List<loaihang> kq = new List<loaihang>();
            if(string.IsNullOrEmpty(lh.maLoai) && string.IsNullOrEmpty(lh.tenLoai) && string.IsNullOrEmpty(lh.mauSac))
            {
                kq = list;
            }
            //tim theo ma
            if (!string.IsNullOrEmpty(lh.maLoai))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].maLoai.IndexOf(lh.maLoai) >= 0)
                    {
                        kq.Add(new loaihang(list[i]));
                    }
            }
            //tim theo ten
            else if (!string.IsNullOrEmpty(lh.tenLoai))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].tenLoai.IndexOf(lh.tenLoai) >= 0)
                    {
                        kq.Add(new loaihang(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
