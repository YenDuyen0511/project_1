using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;

namespace DOAN1.BusinessLayer
{
    public class HangHoaBLL : IHangHoaBLL
    {
        private IHangHoaDAL hsDA = new HangHoaDAL();
        public List<hanghoa> GetAllHanghoa()
        {
            return hsDA.GetAllHanghoa();
        }
        public void ThemHanghoa(hanghoa hh)
        {
            if (!string.IsNullOrEmpty(hh.tenHang))
            {
                hsDA.ThemHanghoa(hh);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void SuaHanghoa(hanghoa hh)
        {
            int i;
            List<hanghoa> list = GetAllHanghoa();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHang == hh.maHang)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hh);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void XoaHanghoa(string mahang)
        {
            int i;
            List<hanghoa> list = GetAllHanghoa();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHang == mahang)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma hang nay");
        }
        public List<hanghoa> TimHanghoa(hanghoa hh)
        {
            List<hanghoa> list = GetAllHanghoa();
            List<hanghoa> kq = new List<hanghoa>();
            if (string.IsNullOrEmpty(hh.maHang) && string.IsNullOrEmpty(hh.tenHang) && string.IsNullOrEmpty(hh.maLoai)&& hh.slgnhap==0 && hh.slgco ==0)
            {
                kq = list;
            }
            //tim theo ma
            if (!string.IsNullOrEmpty(hh.maHang))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].maHang.IndexOf(hh.maHang) >= 0)
                    {
                        kq.Add(new hanghoa(list[i]));
                    }
            }
            //tim theo ten
            else if (!string.IsNullOrEmpty(hh.tenHang))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].tenHang.IndexOf(hh.tenHang) >= 0)
                    {
                        kq.Add(new hanghoa(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
