using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;

namespace DOAN1.BusinessLayer
{
    public class NccBLL :INccBLL
    {
        private INccDAL hsDA = new NccDAL();
        public List<ncc> GetAllNcc()
        {
            return hsDA.GetAllNcc();
        }
        public void ThemNcc(ncc cc)
        {
            if (!string.IsNullOrEmpty(cc.tenNcc))
            {
                hsDA.ThemNcc(cc);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void SuaNcc(ncc cc)
        {
            int i;
            List<ncc> list = GetAllNcc();
            for (i = 0; i < list.Count; i++)
                if (list[i].maNcc == cc.maNcc)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(cc);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void XoaNcc(string mancc)
        {
            int i;
            List<ncc> list = GetAllNcc();
            for (i = 0; i < list.Count; i++)
                if (list[i].maNcc == mancc)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public List<ncc> TimNcc(ncc cc)
        {
            List<ncc> list = GetAllNcc();
            List<ncc> kq = new List<ncc>();
            if (string.IsNullOrEmpty(cc.maNcc) && string.IsNullOrEmpty(cc.tenNcc) && string.IsNullOrEmpty(cc.dChi) && string.IsNullOrEmpty(cc.SDT))
            {
                kq = list;
            }
            //tim theo ma
            if (!string.IsNullOrEmpty(cc.maNcc))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].maNcc.IndexOf(cc.maNcc) >= 0)
                    {
                        kq.Add(new ncc(list[i]));
                    }
            }
            //tim theo ten
            else if (!string.IsNullOrEmpty(cc.tenNcc))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].tenNcc.IndexOf(cc.tenNcc) >= 0)
                    {
                        kq.Add(new ncc(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
