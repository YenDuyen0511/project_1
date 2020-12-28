using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;

namespace DOAN1.BusinessLayer
{
    public class HoaDonNhapBLL :IHoaDonNhapBLL
    {
        private IHoaDonnhapDAL hsDA = new HoaDonnhapDAL();
        public List<hoadonNhap> GetAllHoaDonnhap()
        {
            return hsDA.GetAllHoaDonnhap();
        }
        public void ThemHoaDonnhap(hoadonNhap hdn)
        {
            if (!string.IsNullOrEmpty(hdn.maHdn))
            {
                hsDA.ThemHoaDonnhap(hdn);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void SuaHoaDonnhap(hoadonNhap hdn)
        {
            int i;
            List<hoadonNhap> list = GetAllHoaDonnhap();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHdn == hdn.maHdn)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hdn);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void XoaHoaDonnhap(string mahdn)
        {
            int i;
            List<hoadonNhap> list = GetAllHoaDonnhap();
            for (i = 0; i < list.Count; i++)
                if (list[i].maHdn == mahdn)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public List<hoadonNhap> TimHoaDonnhap(hoadonNhap hdn)
        {
            List<hoadonNhap> list = GetAllHoaDonnhap();
            List<hoadonNhap> kq = new List<hoadonNhap>();
            if (string.IsNullOrEmpty(hdn.maHdn) && string.IsNullOrEmpty(hdn.tenNvgiao) && string.IsNullOrEmpty(hdn.maNcc) && hdn.Tong==0 && hdn.VAT==0)
            {
                kq = list;
            }
            //tim theo ma
            if (!string.IsNullOrEmpty(hdn.maHdn))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].maHdn.IndexOf(hdn.maHdn) >= 0)
                    {
                        kq.Add(new hoadonNhap(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
