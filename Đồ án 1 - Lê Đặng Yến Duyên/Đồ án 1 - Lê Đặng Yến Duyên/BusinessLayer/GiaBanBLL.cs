using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;

namespace DOAN1.BusinessLayer
{
    public class GiaBanBLL : IGiaBanBLL
    {
        private IGiaBanDAL hsDA = new GiaBanDAL();
        public List<giaban> GetAllGiaban()
        {
            return hsDA.GetAllGiaban();
        }
        public void Themgiaban(giaban gb)
        {
            if (!string.IsNullOrEmpty(gb.maHang))
            {
                hsDA.Themgiaban(gb);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void Suagiaban(giaban gb)
        {
            int i;
            List<giaban> list = GetAllGiaban();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHang == gb.maHang)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(gb);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void Xoagiaban(string mahang)
        {
            int i;
            List<giaban> list = GetAllGiaban();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHang == mahang)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public List<giaban> Timgiaban(giaban gb)
        {
            List<giaban> list = GetAllGiaban();
            List<giaban> kq = new List<giaban>();
            if (string.IsNullOrEmpty(gb.maHang) && string.IsNullOrEmpty(gb.donvi) && gb.Gia>0 )
            {
                kq = list;
            }
            //tim theo ma
            if (!string.IsNullOrEmpty(gb.maHang))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].maHang.IndexOf(gb.maHang) >= 0)
                    {
                        kq.Add(new giaban(list[i]));
                    }
            }
            //tim theo ten
            else if (!string.IsNullOrEmpty(gb.donvi))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].donvi.IndexOf(gb.donvi) >= 0)
                    {
                        kq.Add(new giaban(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
