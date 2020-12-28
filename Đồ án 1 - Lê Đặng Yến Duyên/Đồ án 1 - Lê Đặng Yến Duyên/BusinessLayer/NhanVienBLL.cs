using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;

namespace DOAN1.BusinessLayer
{
    public class NhanVienBLL : INhanVienBLL
    {
        private INhanVienDAL hsDA = new NhanVienDAL();
        public List<nhanvien> GetAllNhanvien()
        {
            return hsDA.GetAllNhanvien();
        }
        public void ThemNhanvien(nhanvien nv)
        {
            if (!string.IsNullOrEmpty(nv.tenNv))
            {
                hsDA.ThemNhanvien(nv);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void SuaNhanvien(nhanvien nv)
        {
            int i;
            List<nhanvien> list = GetAllNhanvien();
            for (i = 0; i < list.Count; i++)
                if (list[i].maNv == nv.maNv)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(nv);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void XoaNhanvien(string manv)
        {
            int i;
            List<nhanvien> list = GetAllNhanvien();
            for (i = 0; i < list.Count; i++)
                if (list[i].maNv == manv)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public List<nhanvien> TimNhanvien(nhanvien nv)
        {
            List<nhanvien> list = GetAllNhanvien();
            List<nhanvien> kq = new List<nhanvien>();
            if (string.IsNullOrEmpty(nv.maNv) && string.IsNullOrEmpty(nv.tenNv) && string.IsNullOrEmpty(nv.Pass) && string.IsNullOrEmpty(nv.loaiNv))
            {
                kq = list;
            }
            //tim theo ma
            if (!string.IsNullOrEmpty(nv.maNv))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].maNv.IndexOf(nv.maNv) >= 0)
                    {
                        kq.Add(new nhanvien(list[i]));
                    }
            }
            //tim theo ten
            else if (!string.IsNullOrEmpty(nv.tenNv))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].tenNv.IndexOf(nv.tenNv) >= 0)
                    {
                        kq.Add(new nhanvien(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
